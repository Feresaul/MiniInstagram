using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniInstagram.Modelos
{
    public class PerfilBusqueda : IObjeto
    {
        private Panel panel = new Panel();
        private Label nombrec = new Label();
        private Label nombre = new Label();
        private ImagenCircular imagen = new ImagenCircular();
        private Panel BusquedaPanel = new Panel();
        private int x;
        private int y;
        private Action<string> PerfilUsuario;
        private string user;
        private string newURL = "";


        public PerfilBusqueda(Panel BusquedaPanel, int x, int y, Action<string> PerfilUsuario, string user)
        {
            this.BusquedaPanel = BusquedaPanel;
            this.x = x;
            this.y = y;
            this.PerfilUsuario = PerfilUsuario;
            this.user = user;

            string url = Directory.GetCurrentDirectory();
            for (int i = 0; i < url.Length - 9; i++)
                newURL += url[i];
        }

        public void crearPanel()
        {
            var proxy = new ProxyInstagram();
            var res = proxy.GetUser(user);

            panel.SetBounds(x, y, BusquedaPanel.Width - 20, 44);

            nombre.Text = "" + user;
            nombre.Font = new Font("Calibri", 10, FontStyle.Bold);
            nombre.SetBounds(panel.Width / 2 - 20, panel.Height / 2 - (int)nombre.Font.Size - 8, panel.Width / 2, 14);
            panel.Controls.Add(nombre);

            nombrec.Text = "" + res.nombre;
            nombrec.Font = new Font("Calibri", 8, FontStyle.Regular);
            nombrec.SetBounds(panel.Width / 2 - 20, panel.Height / 2 - (int)nombre.Font.Size + 8, panel.Width / 2, 14);
            panel.Controls.Add(nombrec);
            
            var urlimage = newURL + res.foto;
            Image image = Image.FromFile(urlimage);
            imagen.Image = image;
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            imagen.SetBounds(25, 0, panel.Height - 8, panel.Height - 8);
            panel.Controls.Add(imagen);

            panel.Click += (s, ev) => { PerfilUsuario(nombre.Text); };
            imagen.Click += (s, ev) => { PerfilUsuario(nombre.Text); };
            nombre.Click += (s, ev) => { PerfilUsuario(nombre.Text); };
            panel.Cursor = Cursors.Hand;
            imagen.Cursor = Cursors.Hand;
            nombre.Cursor = Cursors.Hand;
        }
        public Panel obtenerPanel()
        {
            return panel;
        }
    }
}
