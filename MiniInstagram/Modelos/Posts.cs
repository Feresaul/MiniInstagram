using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MiniInstagram.Modelos.ModelInstagram;

namespace MiniInstagram.Modelos
{
    public class Posts : IObjeto
    {
        private Panel principalPanel = new Panel();
        private Panel topPanel = new Panel();
        private Panel dataPanel = new Panel();
        private Label nombre = new Label();
        private ImagenCircular imagen = new ImagenCircular();
        private Label titulo = new Label();
        private TextBox comment = new TextBox();
        private ProxyInstagram proxy = new ProxyInstagram();
        private static int scroll = 0;

        private Panel PostsPanel = new Panel();
        private int x;
        private int y;
        private Action<string> PerfilUsuario;
        private Post post = new Post();
        private string user;
        private Action UpdatePosts;
        private Form Principal;
        private string newURL;
        public Posts(Panel PostsPanel, int x, int y, Action<string> PerfilUsuario, Post post, string user, Action UpdatePosts, Form Principal)
        {
            this.PostsPanel = PostsPanel;
            this.x = x;
            this.y = y;
            this.PerfilUsuario = PerfilUsuario;
            this.post = post;
            this.user = user;
            this.UpdatePosts = UpdatePosts;
            this.Principal = Principal;

            string url = Directory.GetCurrentDirectory();
            newURL = "";
            for (int i = 0; i < url.Length - 9; i++)
                newURL += url[i];
        }
        public int getScroll()
        {
            return scroll;
        }
        public void crearPanel()
        {
            principalPanel.SetBounds(x + 2, y + 2, PostsPanel.Width - 22, PostsPanel.Height - 4);


            topPanel.Dock = DockStyle.Top;
            topPanel.BackColor = Color.White;
            topPanel.Height = 46;
            imagen.SetBounds(14, 7, topPanel.Height - 14, topPanel.Height - 14);
            var urlimage = newURL + post.foto;
            Image image = Image.FromFile(urlimage);
            imagen.Image = image;
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            topPanel.Controls.Add(imagen);
            
            principalPanel.Controls.Add(topPanel);

            nombre.Cursor = Cursors.Hand;
            nombre.Click += (s, ev) => { PerfilUsuario(nombre.Text); };

            nombre.Text = "" + post.usuario;
            nombre.Font = new Font("Calibri", 10, FontStyle.Bold);
            nombre.SetBounds(topPanel.Width / 5, topPanel.Height / 2 - (int)nombre.Font.Size - 5, (topPanel.Width / 4) * 3, (int)nombre.Font.Size + 5);
            topPanel.Controls.Add(nombre);

            titulo.Text = "" + post.titulo;
            titulo.Font = new Font("Calibri", 8);
            titulo.SetBounds(topPanel.Width / 5, topPanel.Height / 2 + 2, (topPanel.Width / 4) * 3, (int)titulo.Font.Size + 5);
            topPanel.Controls.Add(titulo);

            Label likes = new Label();
            int likesCount = post.likes;
            likes.Text = likesCount + " Me gusta"; // Contar Likes
            likes.Font = new Font("Calibri", 8);
            likes.SetBounds(60, 14, (topPanel.Width / 4) * 2, (int)likes.Font.Size + 5);
            dataPanel.Controls.Add(likes);

            PictureBox like = new PictureBox();
            Image newImagen2;
            bool meGusta = proxy.LikeEstado(user, post.usuario, post.id);
            if (!meGusta) newImagen2 = Image.FromFile(newURL + "Imagenes/like.png");
            else newImagen2 = Image.FromFile(newURL + "Imagenes/liked.png");
            like.Image = newImagen2;
            like.SizeMode = PictureBoxSizeMode.Zoom;
            dataPanel.Controls.Add(like);
            like.SetBounds(comment.Location.X + 26, 10, 25, 25);
            like.Cursor = Cursors.Hand;
            like.Click += (s, ev) => {
                proxy.LikeCambiar(user, post.usuario, post.id);
                if (meGusta)
                {
                    newImagen2 = Image.FromFile(newURL + "Imagenes/like.png");
                    likesCount -= 1;
                    meGusta = false;
                }
                else
                {
                    newImagen2 = Image.FromFile(newURL + "Imagenes/liked.png");
                    likesCount += 1;
                    meGusta = true;
                }
                like.Image = newImagen2;
                likes.Text = likesCount + " Me gusta";
            }; //like

            PictureBox save = new PictureBox();
            dataPanel.Controls.Add(save);
            save.SetBounds(comment.Location.X + 278, 10, 25, 25);
            Image newImagen3;
            bool guardado = proxy.GuardarEstado(user, post.usuario, post.id); ;
            if (!guardado) newImagen3 = Image.FromFile(newURL + "Imagenes/GuardadoUnactive.png");
            else newImagen3 = Image.FromFile(newURL + "Imagenes/Guardado.png");
            save.Image = newImagen3;
            save.SizeMode = PictureBoxSizeMode.Zoom;
            save.Cursor = Cursors.Hand;
            save.Click += (s, ev) => {
                proxy.GuardarCambiar(user, post.usuario, post.id);
                if (guardado)
                {
                    guardado = false;
                    newImagen3 = Image.FromFile(newURL + "Imagenes/GuardadoUnactive.png");
                }
                else
                {
                    guardado = true;
                    newImagen3 = Image.FromFile(newURL + "Imagenes/Guardado.png");
                }
                save.Image = newImagen3;
            }; //save

            var newComentario = new ConstructorComentario(post.usuario, post.descripcion, PerfilUsuario).CrearObjeto();
            newComentario.crearPanel();
            Panel descripcion = newComentario.obtenerPanel();
            descripcion.Location = new Point(24, 48);
            dataPanel.Controls.Add(descripcion);

            var Offset = 50 + descripcion.Height + 2;

            if (post.comentarios.Count > 3)
            {
                var cargarTodos = new Label();
                dataPanel.Controls.Add(cargarTodos);
                cargarTodos.Text = $"Ver los {post.comentarios.Count} comentarios";
                cargarTodos.ForeColor = Color.Gray;
                cargarTodos.SetBounds(28, Offset, cargarTodos.Text.Length * 7, 12);
                cargarTodos.Cursor = Cursors.Hand;
                Offset += 18;
                cargarTodos.Click += (s, ev) => {
                    // Mostrar panel 
                    var ventana = new VentanaPost(PerfilUsuario, post, user, UpdatePosts, Principal, PostsPanel, likesCount);
                };
            }
            //Ultimos 3 comentarios
            int aux = post.comentarios.Count - 3;
            if (aux < 0) aux = 0;
            for (int i = aux; i < post.comentarios.Count; i++)
            {
                var com = post.comentarios[i];
                var newComentario2 = new ConstructorComentario(com.name, com.data, PerfilUsuario).CrearObjeto();
                newComentario2.crearPanel();
                Panel descripciones = newComentario2.obtenerPanel();
                descripciones.Location = new Point(24, Offset);
                dataPanel.Controls.Add(descripciones);
                if (com.name == user)
                {
                    PictureBox opciones = new PictureBox();
                    Image imagen = Image.FromFile(newURL + "Imagenes/config.png");
                    opciones.Image = imagen;
                    opciones.Cursor = Cursors.Hand;
                    opciones.SizeMode = PictureBoxSizeMode.Zoom;
                    dataPanel.Controls.Add(opciones);
                    opciones.SetBounds(descripciones.Location.X + descripciones.Width + 4, descripciones.Location.Y, 28, 10);
                    var activo = false;
                    Button borrar = new Button();
                    opciones.Click += (s, ev) => {
                        if (!activo)
                        {
                            borrar.Visible = true;
                            borrar.Text = "Eliminar";
                            borrar.FlatStyle = FlatStyle.Flat;
                            dataPanel.Controls.Add(borrar);
                            borrar.BringToFront();
                            borrar.Focus();
                            borrar.Location = new Point(opciones.Location.X - 70, opciones.Location.Y - 8);
                            borrar.Click += (se, eve) =>
                            {
                                proxy.BorrarComentario(post.usuario, post.id, com.id);
                                UpdatePosts();
                                borrar.Visible = false;
                            };
                            borrar.LostFocus += (se, eve) =>
                            {
                                borrar.Visible = false;
                                activo = false;
                            };
                            activo = true;
                        }
                        else
                        {
                            borrar.Visible = false;
                            activo = false;
                        }
                    };
                }

                Offset += descripciones.Height + 2;
            }

            dataPanel.Click += (s, ev) => { dataPanel.Focus(); };
            dataPanel.Controls.Add(comment);
            comment.SetBounds(26, Offset + 10, dataPanel.Width + 20, 12);
            comment.BackColor = Color.WhiteSmoke;
            comment.ForeColor = Color.DarkGray;
            comment.BorderStyle = BorderStyle.None;
            comment.Font = new Font("Calibri", 9);
            comment.Text = "Agregar un comentario...";
            comment.Enter += (s, ev) => { if (comment.Text == "Agregar un comentario...") { comment.Text = ""; comment.ForeColor = Color.Black; } };
            comment.Leave += (s, ev) => { if (comment.Text == "") { comment.Text = "Agregar un comentario..."; comment.ForeColor = Color.DarkGray; } };

            PictureBox enviar = new PictureBox();
            Image newImagen = Image.FromFile(newURL + "Imagenes/send.png");
            enviar.Image = newImagen;
            enviar.SizeMode = PictureBoxSizeMode.Zoom;
            enviar.SetBounds(comment.Location.X + 230, comment.Location.Y - 5, 25, 25);
            dataPanel.Controls.Add(enviar);
            enviar.Cursor = Cursors.Hand;
            enviar.Click += (s, ev) => {
                if (comment.Text != "" && comment.Text != "Agregar un comentario...")
                    proxy.GuardarComentario(user, post.usuario, post.id, comment.Text);
                UpdatePosts();
                comment.Text = "Agregar un comentario...";
            };

            Offset += 28;

            PictureBox imagenPrincipal = new PictureBox();
            urlimage = newURL + post.url;
            image = Image.FromFile(urlimage);
            imagenPrincipal.Image = image;
            imagenPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            imagenPrincipal.BackColor = Color.Black;
            imagenPrincipal.SetBounds(0, 46, principalPanel.Width, principalPanel.Height-66);
            principalPanel.Controls.Add(imagenPrincipal);

            dataPanel.Dock = DockStyle.Bottom;
            dataPanel.Height = Offset + 20;
            principalPanel.Height += dataPanel.Height - 20;
            dataPanel.BackColor = Color.White;
            principalPanel.Controls.Add(dataPanel);

            PostsPanel.Controls.Add(principalPanel);
        }
        public Panel obtenerPanel()
        {
            return principalPanel;
        }
    }
}
