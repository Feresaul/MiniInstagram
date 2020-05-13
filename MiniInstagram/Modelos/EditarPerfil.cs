using Org.BouncyCastle.Crypto.Agreement.JPake;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniInstagram.Modelos
{
    public class EditarPerfil
    {
        private string newURL;
        private Panel principalPanel = new Panel();
        private Button salir = new Button();
        private Button aceptar = new Button();
        private Button add = new Button();
        private string filetype;
        public EditarPerfil(string perfil, Form Perfil, Action UpdatePerfil)
        {
            string url = Directory.GetCurrentDirectory();
            newURL = "";
            for (int i = 0; i < url.Length - 9; i++)
                newURL += url[i];
 
            var proxy = new ProxyInstagram();
            var user = proxy.GetUser(perfil);

            Perfil.Controls.Add(principalPanel);
            principalPanel.BorderStyle = BorderStyle.FixedSingle;
            principalPanel.SetBounds(Perfil.Width / 3-25, 70, Perfil.Width / 3+50, 400);
            principalPanel.BringToFront();


            salir.Text = "X";
            salir.Cursor = Cursors.Hand;
            principalPanel.Controls.Add(salir);
            salir.SetBounds(principalPanel.Width - 50, 8, 40, 30);
            salir.FlatStyle = FlatStyle.Flat;
            salir.FlatAppearance.BorderSize = 0;
            salir.Click += (s, ev) => { Perfil.Controls.Remove(principalPanel); };


            PictureBox imagenPrincipal = new ImagenCircular();
            var urlimage = newURL + user.foto;
            var image = Image.FromFile(urlimage);
            imagenPrincipal.Image = image;
            imagenPrincipal.BorderStyle = BorderStyle.FixedSingle;
            imagenPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenPrincipal.SetBounds(principalPanel.Width/4, 40, (principalPanel.Width / 4)*2, (principalPanel.Width/4)*2);
            principalPanel.Controls.Add(imagenPrincipal);

            var label = new Label();
            var fileContent = string.Empty;
            var filePath = string.Empty;
            principalPanel.Controls.Add(add);
            add.Text = "+";
            add.Font = new Font("Calibri", 8);
            add.SetBounds(imagenPrincipal.Location.X + imagenPrincipal.Width, imagenPrincipal.Location.Y + imagenPrincipal.Height-20, 20, 20);
            add.FlatStyle = FlatStyle.Flat;
            add.Click += (s, ev) => {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = " Image files|*.bmp;*.jpg;*.png;";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    principalPanel.Controls.Remove(label);
                    filePath = openFileDialog.FileName;
                    var data = filePath.Split('.');
                    filetype = data[data.Length - 1];
                    urlimage = filePath;
                    image = Image.FromFile(urlimage);
                    imagenPrincipal.Image = image;
                }
            };

            Label biografia = new Label();
            biografia.Text = "Biografía: ";
            principalPanel.Controls.Add(biografia);
            biografia.SetBounds(32, imagenPrincipal.Location.Y+imagenPrincipal.Height+50, biografia.Text.Length * 6, 14);

            TextBox Tbiografia = new TextBox();
            principalPanel.Controls.Add(Tbiografia);
            Tbiografia.Text = user.biografia;
            Tbiografia.SetBounds(biografia.Location.X + 4, biografia.Location.Y + 20, 220, 50);
            Tbiografia.BackColor = Color.WhiteSmoke;
            Tbiografia.Multiline = true;
            Tbiografia.BorderStyle = BorderStyle.None;
            Tbiografia.MaxLength = 160;

            principalPanel.Controls.Add(aceptar);
            aceptar.Text = "Guardar";
            aceptar.Font = new Font("Calibri", 8);
            aceptar.SetBounds(Tbiografia.Location.X+Tbiografia.Width- aceptar.Text.Length * 8, Tbiografia.Location.Y+Tbiografia.Height+30, aceptar.Text.Length * 8, 26);
            aceptar.FlatStyle = FlatStyle.Flat;
            aceptar.Click += (s, ev) => {
                var data = filePath.Split('\\');
                var imagedata = "Imagenes\\"+data[data.Length-1];
                if (imagedata.Length >= 40)
                {
                    label.Text = "Nombre de Imagen supera 30 caracteres";
                    label.ForeColor = Color.Red;
                    principalPanel.Controls.Add(label);
                    label.SetBounds(40, imagenPrincipal.Location.Y + imagenPrincipal.Height+10, principalPanel.Width-40, 24);
                    return;
                }
                //var imagedata = "Imagenes\\" + perfil + "." + filetype; 
                image = Image.FromFile(urlimage);
                image.Save(newURL+imagedata);
                proxy.EditarPerfil(perfil, "\\"+imagedata, Tbiografia.Text);
                UpdatePerfil();
                Perfil.Controls.Remove(principalPanel);
            };
        }

        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
