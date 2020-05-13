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
    public class StoriesP : IObjeto
    {
        private Panel panel = new Panel();
        private Label nombre = new Label();
        private ImagenCircular imagen = new ImagenCircular();
        private Panel StoryPanel = new Panel();
        private int x;
        private int y;
        private Action<List<Storie>, string> StoriesUsuario;
        private Stories storie = new Stories();
        private ProxyInstagram proxy = new ProxyInstagram();
        private string newURL;
        private string name;
        private Action Update;

        public StoriesP(Panel StoryPanel, int x, int y, Action<List<Storie>, string> StoriesUsuario, Stories storie, string name, Action Update)
        {
            this.name = name;
            this.StoryPanel = StoryPanel;
            this.x = x;
            this.y = y;
            this.StoriesUsuario = StoriesUsuario;
            this.storie = storie;
            this.Update = Update;

            string url = Directory.GetCurrentDirectory();
            for (int i = 0; i < url.Length - 9; i++)
                newURL += url[i];
        }

        public void crearPanel()
        {
            var res = proxy.GetUser(storie.nombre);

            panel.SetBounds(x, y, StoryPanel.Width - 20, StoryPanel.Height / 7);

            nombre.Text = ""+storie.nombre;
            nombre.SetBounds(panel.Width / 2 - 25, panel.Height / 2 - (int)nombre.Font.Size, panel.Width / 2, panel.Height / 3);
            panel.Controls.Add(nombre);

            var urlimage = newURL + res.foto;
            Image image = Image.FromFile(urlimage);
            imagen.Image = image;
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            imagen.SetBounds(25, 0, panel.Height, panel.Height);
            panel.Controls.Add(imagen);

            panel.Click += (s, ev) => { StoriesUsuario(storie.stories, storie.nombre); };
            imagen.Click += (s, ev) => { StoriesUsuario(storie.stories, storie.nombre); };
            nombre.Click += (s, ev) => { StoriesUsuario(storie.stories, storie.nombre); };
            panel.Cursor = Cursors.Hand;
            imagen.Cursor = Cursors.Hand;
            nombre.Cursor = Cursors.Hand;

            if (name == storie.nombre)
            {
                PictureBox opciones = new PictureBox();
                Image imagen2 = Image.FromFile(newURL + "Imagenes/config.png");
                opciones.Image = imagen2;
                opciones.Cursor = Cursors.Hand;
                opciones.SizeMode = PictureBoxSizeMode.Zoom;
                panel.Controls.Add(opciones);
                opciones.SetBounds(panel.Width - 24, 8, 18, 14);
                var activo = false;
                Button borrar = new Button();
                opciones.Click += (s, ev) =>
                {
                    if (!activo)
                    {
                        borrar.Visible = true;
                        borrar.Text = "Eliminar Stories";
                        borrar.FlatStyle = FlatStyle.Flat;
                        panel.Controls.Add(borrar);
                        borrar.BringToFront();
                        borrar.Focus();
                        borrar.Width = 124;
                        borrar.Location = new Point(opciones.Location.X - 120, opciones.Location.Y - 4);
                        borrar.Click += (se, eve) =>
                        {
                            // Update Story Panel
                            proxy.BorrarStories(name);
                            Update();
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
        }
        public Panel obtenerPanel()
        {
            return panel;
        }
    }
}
