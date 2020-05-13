using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniInstagram.Modelos
{
    public class Seguido : IObjeto
    {
        private Panel panel = new Panel();
        private Label nombre = new Label();
        private ImagenCircular imagen = new ImagenCircular();
        private Button estado = new Button();

        private Panel SeguidoPanel = new Panel();
        private int x;
        private int y;
        private Action<string> PerfilUsuario;
        private Action Update;
        private string usuario;
        private string perfil;
        private string newURL;

        public Seguido(Panel SeguidoPanel, int x, int y, Action<string> PerfilUsuario, Action Update, string usuario, string perfil)
        {
            this.SeguidoPanel = SeguidoPanel;
            this.x = x;
            this.y = y;
            this.PerfilUsuario = PerfilUsuario;
            this.Update = Update;
            this.usuario = usuario;
            this.perfil = perfil;

            string url = Directory.GetCurrentDirectory();
            newURL = "";
            for (int i = 0; i < url.Length - 9; i++)
                newURL += url[i];
        }

        public void crearPanel()
        {
            var proxy = new ProxyInstagram();
            var user = proxy.GetUser(perfil);

            panel.SetBounds(x, y, SeguidoPanel.Width - 20, 46);

            var urlimage = newURL + user.foto;
            Image image = Image.FromFile(urlimage);
            imagen.Image = image;
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            imagen.SetBounds(26, 0, panel.Height - 8, panel.Height - 8);
            panel.Controls.Add(imagen);

            nombre.Text = "" + perfil;
            nombre.SetBounds(imagen.Location.X + 50, panel.Height / 2 - (int)nombre.Font.Size, (perfil.Length + 1) * 7 - 2, panel.Height / 3);
            panel.Controls.Add(nombre);

            panel.Controls.Add(estado);
            estado.SetBounds(nombre.Location.X + nombre.Width + (12 / perfil.Length), panel.Height / 2 - 16, 100, 26);
            estado.ForeColor = Color.LightSkyBlue;
            estado.FlatStyle = FlatStyle.Flat;
            bool res = proxy.SeguirEstado(usuario, perfil);
            if (!res) estado.Text = "Seguir";
            else estado.Text = "Siguiendo";
            estado.Width = estado.Text.Length * 9;
            ColorBoton();

            if (usuario == perfil) estado.Visible = false;

            nombre.Click += (s, ev) => { PerfilUsuario(nombre.Text); };
            estado.Click += (s, ev) => {
                proxy.SeguirCambiar(usuario, perfil);
                if (estado.Text == "Seguir")
                {
                    estado.Text = "Siguiendo";
                }
                else
                {
                    estado.Text = "Seguir";
                }
                estado.Width = estado.Text.Length * 9;
                ColorBoton();
                Update();
            };
            nombre.Cursor = Cursors.Hand;
            estado.Cursor = Cursors.Hand;
        }
        public Panel obtenerPanel()
        {
            return panel;
        }
        void ColorBoton()
        {
            if (estado.Text == "Seguir")
            {
                estado.ForeColor = Color.DeepSkyBlue;
                estado.BackColor = Color.White;
            }
            else
            {
                estado.ForeColor = Color.White;
                estado.BackColor = Color.DeepSkyBlue;
            }
        }
    }
}
