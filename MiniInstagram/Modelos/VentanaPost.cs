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
    public class VentanaPost 
    {
        private Panel principalPanel = new Panel();
        private Panel topPanel = new Panel();
        private Panel dataPanel = new Panel();
        private Panel comentariosPanel = new Panel();
        private Label nombre = new Label();
        private ImagenCircular imagen = new ImagenCircular();
        private Label titulo = new Label();
        private TextBox comment = new TextBox();
        private ProxyInstagram proxy = new ProxyInstagram();
        private static int scroll = 0;
        private Button salir = new Button();
        private Post post = new Post();
        private string user;
        private Action UpdatePosts;
        private string newURL;
        private Action<string> PerfilUsuario;

        public VentanaPost(Action<string> _PerfilUsuario, Post _post, string _user, Action _UpdatePosts, Form Principal, Panel Posts, int likesCount)
        {
            string url = Directory.GetCurrentDirectory();
            newURL = "";
            for (int i = 0; i < url.Length - 9; i++)
                newURL += url[i];

            post = proxy.ObtenerPost(_post.usuario,_post.id);
            user = _user;
            UpdatePosts = _UpdatePosts;
            PerfilUsuario = _PerfilUsuario;

            principalPanel.SetBounds(42, 62, 668, 418);
            principalPanel.BorderStyle = BorderStyle.FixedSingle;
            principalPanel.BringToFront();

            topPanel.BackColor = Color.White;
            topPanel.SetBounds(principalPanel.Width / 2 + 20, -2, principalPanel.Width / 2 - 20, 56);
            topPanel.BorderStyle = BorderStyle.FixedSingle;

            imagen.SetBounds(14, 10, topPanel.Height - 20, topPanel.Height - 20);
            var urlimage = newURL + post.foto;
            Image image = Image.FromFile(urlimage);
            imagen.Image = image;
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            topPanel.Controls.Add(imagen);

            salir.Text = "X";
            salir.Cursor = Cursors.Hand;
            topPanel.Controls.Add(salir);
            salir.SetBounds(topPanel.Width - 50, 8, 40, 30);
            salir.FlatStyle = FlatStyle.Flat;
            salir.FlatAppearance.BorderSize = 0;
            salir.Click += (s, ev) => { Principal.Controls.Remove(principalPanel); if (UpdatePosts != null) { Principal.ActiveControl = Posts; UpdatePosts(); } };

            principalPanel.Controls.Add(topPanel);

            nombre.Cursor = Cursors.Hand;
            nombre.Click += (s, ev) =>  { PerfilUsuario(nombre.Text); };

            nombre.Text = "" + post.usuario;
            nombre.Font = new Font("Calibri", 10, FontStyle.Bold);
            nombre.SetBounds(topPanel.Width / 5, topPanel.Height / 2 - (int)nombre.Font.Size - 5, (topPanel.Width / 4) * 3, (int)nombre.Font.Size + 5);
            topPanel.Controls.Add(nombre);

            titulo.Text = "" + post.titulo;
            titulo.Font = new Font("Calibri", 8);
            titulo.SetBounds(topPanel.Width / 5, topPanel.Height / 2 + 2, (topPanel.Width / 4) * 3, (int)titulo.Font.Size + 5);
            topPanel.Controls.Add(titulo);

            Label likes = new Label();
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

            if (post.usuario != user)  
            {
                PictureBox save = new PictureBox();
                dataPanel.Controls.Add(save);
                save.SetBounds(comment.Location.X + 270, 10, 25, 25);
                Image newImagen3;
                bool guardado = proxy.GuardarEstado(user, post.usuario, post.id); ;
                if (!guardado) newImagen3 = Image.FromFile(newURL + "Imagenes/GuardadoUnactive.png");
                else newImagen3 = Image.FromFile(newURL + "Imagenes/Guardado.png");
                save.Image = newImagen3;
                save.SizeMode = PictureBoxSizeMode.Zoom;
                save.Cursor = Cursors.Hand;
                save.Click += (s, ev) =>
                {
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
            }
            else
            {
                PictureBox opciones = new PictureBox();
                Image imagen = Image.FromFile(newURL + "Imagenes/config.png");
                opciones.Image = imagen;
                opciones.Cursor = Cursors.Hand;
                opciones.SizeMode = PictureBoxSizeMode.Zoom;
                dataPanel.Controls.Add(opciones);
                opciones.SetBounds(comment.Location.X + 270, 14, 28, 16);
                var activo = false;
                Button borrar = new Button();
                opciones.Click += (s, ev) => {
                    if (!activo)
                    {
                        borrar.Visible = true;
                        borrar.Text = "Eliminar Publicación";
                        borrar.FlatStyle = FlatStyle.Flat;
                        dataPanel.Controls.Add(borrar);
                        borrar.BringToFront();
                        borrar.Focus();
                        borrar.Width = 124;
                        borrar.Location = new Point(opciones.Location.X - 120, opciones.Location.Y-4);
                        borrar.Click += (se, eve) =>
                        {
                            proxy.BorrarPost(post.usuario,post.id);
                            UpdatePosts();
                            Principal.Controls.Remove(principalPanel);
                        };
                        borrar.LostFocus += (se, eve) =>
                        {
                            borrar.Visible = false;
                            activo = false;
                            dataPanel.Focus();
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

            var newComentario = new ConstructorComentario(post.usuario, post.descripcion, PerfilUsuario).CrearObjeto();
            newComentario.crearPanel();
            Panel descripcion = newComentario.obtenerPanel();
            descripcion.Location = new Point(24+ principalPanel.Width / 2 + 20, 18+topPanel.Height);
            principalPanel.Controls.Add(descripcion);
            var renglones = post.descripcion.Length/34;

            principalPanel.Controls.Add(comentariosPanel);
            comentariosPanel.SetBounds(principalPanel.Width / 2 + 20, descripcion.Location.Y+18+(renglones*12), principalPanel.Width / 2 - 20, 216-(renglones*12));
            comentariosPanel.AutoScroll = true;
            comentariosPanel.BringToFront();

            getUpdate();

            dataPanel.Click += (s, ev) => { dataPanel.Focus(); };
            comentariosPanel.Click += (s, ev) => { dataPanel.Focus(); };
            topPanel.Click += (s, ev) => { dataPanel.Focus(); };
            principalPanel.Click += (s, ev) => { dataPanel.Focus(); };

            dataPanel.Controls.Add(comment);
            comment.SetBounds(26, 62, dataPanel.Width + 20, 12);
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
                getUpdate();
                comment.Text = "Agregar un comentario...";
                comment.ForeColor = Color.DarkGray;
            };


            PictureBox imagenPrincipal = new PictureBox();
            urlimage = newURL + post.url;
            image = Image.FromFile(urlimage);
            imagenPrincipal.Image = image;
            imagenPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            imagenPrincipal.BackColor = Color.Black;
            imagenPrincipal.SetBounds(0, 0, principalPanel.Width/2+20, principalPanel.Height);
            principalPanel.Controls.Add(imagenPrincipal);

            principalPanel.Controls.Add(dataPanel);
            dataPanel.SetBounds(topPanel.Location.X, comentariosPanel.Location.Y+comentariosPanel.Height+10,
                principalPanel.Width, principalPanel.Height-(topPanel.Height+comentariosPanel.Height));
            dataPanel.BringToFront();
            dataPanel.BorderStyle = BorderStyle.FixedSingle;

            Principal.Controls.Add(principalPanel);
            principalPanel.BringToFront();
        }

        void getUpdate()
        {
            UpdatePosts();
            var newPost = proxy.ObtenerPost(post.usuario, post.id);
            comentariosPanel.Controls.Clear();
            var Offset = 10;
            for (int i = 0; i < newPost.comentarios.Count; i++)
            {
                var com = newPost.comentarios[i]; 
                var newComentario = new ConstructorComentario(com.name, com.data, PerfilUsuario).CrearObjeto();
                newComentario.crearPanel();
                Panel descripciones = newComentario.obtenerPanel();
                descripciones.Location = new Point(20, Offset);
                comentariosPanel.Controls.Add(descripciones);
                if (com.name == user  || user == post.usuario)
                {
                    PictureBox opciones = new PictureBox();
                    Image imagen = Image.FromFile(newURL + "Imagenes/config.png");
                    opciones.Image = imagen;
                    opciones.Cursor = Cursors.Hand;
                    opciones.SizeMode = PictureBoxSizeMode.Zoom;
                    comentariosPanel.Controls.Add(opciones);
                    opciones.SetBounds(descripciones.Location.X + descripciones.Width - 8, descripciones.Location.Y, 22, 10);
                    var activo = false;
                    Button borrar = new Button();
                    opciones.Click += (s, ev) => {
                        if (!activo)
                        {
                            borrar.Visible = true;
                            borrar.Text = "Eliminar";
                            borrar.FlatStyle = FlatStyle.Flat;
                            comentariosPanel.Controls.Add(borrar);
                            borrar.BringToFront();
                            borrar.Focus();
                            borrar.Location = new Point(opciones.Location.X - 70, opciones.Location.Y - 8);
                            borrar.Click += (se, eve) =>
                            {
                                proxy.BorrarComentario(post.usuario, post.id, com.id);
                                UpdatePosts();
                                getUpdate();
                                borrar.Visible = false;
                                principalPanel.Focus();
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
        }
        public int getScroll()
        {
            return scroll;
        }
    }
}
