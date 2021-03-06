﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniInstagram.Modelos
{
    public class Publicar
    {
        private Panel panelPrincipal = new Panel();
        private Button salir = new Button();
        private ProxyInstagram proxy = new ProxyInstagram();
        private Label titulo = new Label();
        private Label descripcion = new Label();
        private TextBox Ttitulo = new TextBox();
        private TextBox Tdescripcion = new TextBox();
        private Button add = new Button();
        private Button select = new Button();
        private Panel panel = new Panel();
        private PictureBox imagenPrincipal = new PictureBox();
        private string newURL;

        public Publicar(Form inicio, Panel top, string user)
        {
            string url = Directory.GetCurrentDirectory();
            newURL = "";
            for (int i = 0; i < url.Length - 9; i++)
                newURL += url[i];

            panelPrincipal.SetBounds(42, 62, 668, 418);
            inicio.Controls.Add(panelPrincipal);
            panelPrincipal.BringToFront();
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;

            salir.Text = "X";
            salir.Cursor = Cursors.Hand;
            panelPrincipal.Controls.Add(salir);
            salir.SetBounds(panelPrincipal.Width - 50, 8, 40, 30);
            salir.FlatStyle = FlatStyle.Flat;
            salir.FlatAppearance.BorderSize = 0;
            salir.Click += (s, ev) => { inicio.Controls.Remove(panelPrincipal); inicio.ActiveControl = top; };

            titulo.Text = "Titulo: ";
            panel.Controls.Add(titulo);
            titulo.SetBounds(20, 20, titulo.Text.Length*5+2, 14);

            panel.Controls.Add(Ttitulo);
            Ttitulo.SetBounds(titulo.Location.X + 44, titulo.Location.Y, 180, 14);
            Ttitulo.BackColor = Color.WhiteSmoke;
            Ttitulo.BorderStyle = BorderStyle.None;
            Ttitulo.MaxLength = 30;

            descripcion.Text = "Descripción: ";
            panel.Controls.Add(descripcion);
            descripcion.SetBounds(20, 50, descripcion.Text.Length*6, 14);

            panel.Controls.Add(Tdescripcion);
            Tdescripcion.SetBounds(descripcion.Location.X+4, descripcion.Location.Y + 20, 220, 50);
            Tdescripcion.BackColor = Color.WhiteSmoke;
            Tdescripcion.Multiline = true;
            Tdescripcion.BorderStyle = BorderStyle.None;
            Tdescripcion.MaxLength = 100;


            panel.SetBounds(panelPrincipal.Width / 2 + 40, 80, panelPrincipal.Width / 2 - 60, panelPrincipal.Height / 2);

            panelPrincipal.Controls.Add(panel);
            panel.BringToFront();


            var label = new Label();
            var filePath = string.Empty;
            Image image = Image.FromFile(newURL+"\\Imagenes\\FotoPerfil.jpg");

            panelPrincipal.Controls.Add(select);
            panelPrincipal.Controls.Add(imagenPrincipal);
            imagenPrincipal.SetBounds(0, 0, panelPrincipal.Width / 2 + 20, panelPrincipal.Height);
            imagenPrincipal.BackColor = Color.Black;
            imagenPrincipal.SizeMode = PictureBoxSizeMode.Zoom;

            select.Text = "+";
            select.Font = new Font("Calibri", 8);
            select.SetBounds(0,0, 20,20);
            select.FlatStyle = FlatStyle.Flat;
            select.Click += (s, ev) => {
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
            add.SetBounds(panelPrincipal.Width - 110, panelPrincipal.Height-56, 80, 30);
            add.FlatStyle = FlatStyle.Flat;
            add.FlatAppearance.BorderSize = 0;
            add.Click += (s, ev) => {
                var data = filePath.Split('\\');
                var urlImage = "Imagenes\\" + data[data.Length - 1];
                if (urlImage.Length > 10)
                {
                    image.Save(newURL + urlImage);
                    proxy.CrearPost(user, Ttitulo.Text, Tdescripcion.Text, urlImage);
                    inicio.Controls.Remove(panelPrincipal); 
                    inicio.ActiveControl = top;
                }
            };
        }
    }
}
