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
    public class AddStories
    {
        private Panel panelPrincipal = new Panel();
        private Button salir = new Button();
        private ProxyInstagram proxy = new ProxyInstagram();
        private Button add = new Button();
        private Button select = new Button();
        private PictureBox imagenPrincipal = new PictureBox();
        private string newURL;

        public AddStories(Form inicio, Panel top, string user, Action Update)
        {
            string url = Directory.GetCurrentDirectory();
            newURL = "";
            for (int i = 0; i < url.Length - 9; i++)
                newURL += url[i];

            panelPrincipal.SetBounds(202, 62, 328, 418);
            inicio.Controls.Add(panelPrincipal);
            panelPrincipal.BringToFront();
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;

            salir.Text = "X";
            salir.Cursor = Cursors.Hand;
            panelPrincipal.Controls.Add(salir);
            salir.SetBounds(panelPrincipal.Width - 42, 8, 28, 22);
            salir.FlatStyle = FlatStyle.Flat;
            salir.FlatAppearance.BorderSize = 0;
            salir.Click += (s, ev) => { inicio.Controls.Remove(panelPrincipal); inicio.ActiveControl = top; };

           
            var filePath = string.Empty;
            Image image = Image.FromFile(newURL + "\\Imagenes\\FotoPerfil.jpg");

            panelPrincipal.Controls.Add(select);
            panelPrincipal.Controls.Add(imagenPrincipal);
            imagenPrincipal.SetBounds(0, 0, panelPrincipal.Width, panelPrincipal.Height);
            imagenPrincipal.BackColor = Color.Black;
            imagenPrincipal.SizeMode = PictureBoxSizeMode.Zoom;

            var label = new Label();
            select.Text = "+";
            select.Font = new Font("Calibri", 8);
            select.SetBounds(0, 0, 20, 20);
            select.FlatStyle = FlatStyle.Flat;
            select.Click += (s, ev) =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = " Image files|*.bmp;*.jpg;*.png;";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    panelPrincipal.Controls.Remove(label);
                    filePath = openFileDialog.FileName;
                    image = Image.FromFile(filePath);
                    imagenPrincipal.Image = image;
                }
            };
            
            add.Text = "Publicar";
            add.Cursor = Cursors.Hand;
            panelPrincipal.Controls.Add(add);
            add.BackColor = Color.DeepSkyBlue;
            add.ForeColor = Color.White;
            add.SetBounds(panelPrincipal.Width - 110, panelPrincipal.Height - 56, 80, 30);
            add.FlatStyle = FlatStyle.Flat;
            add.FlatAppearance.BorderSize = 0;
            add.BringToFront();
            add.Click += (s, ev) =>
            {
                var data = filePath.Split('\\');
                var urlImage = "Imagenes\\" + data[data.Length - 1];

                if (urlImage.Length > 10)
                {
                    image.Save(newURL + urlImage);
                    proxy.CrearStorie(user, urlImage);
                    inicio.Controls.Remove(panelPrincipal);
                    inicio.ActiveControl = top;
                    Update();
                }
            };
        }
    }
}
