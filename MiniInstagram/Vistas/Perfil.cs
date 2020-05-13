using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MiniInstagram.Vistas;
using MiniInstagram.Modelos;
using System.IO;
using static MiniInstagram.Modelos.ModelInstagram;

namespace MiniInstagram
{
    public partial class Perfil : Form
    {
        private const int EM_GETLINECOUNT = 0xba;
        [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private string _name;
        private string perfil;
        private int x = 30;
        private int y = 12;
        private Instagram res = new Instagram();
        private ProxyInstagram proxy = new ProxyInstagram();
        private string newURL;
        private Panel SPanel = new Panel();
        private Panel SPanelHeader = new Panel();
        private Label SPanelText = new Label();
        private bool publicaciones;
        private ImagenCircular ImagenPerfil = new ImagenCircular();
        public Perfil(bool miPerfil, string name, string cuenta)
        {
            perfil = name;

            string url = Directory.GetCurrentDirectory();
            newURL = "";
            for (int i = 0; i < url.Length - 9; i++)
                newURL += url[i];

            SPanel.SetBounds(292,150,420,300);
            SPanel.Visible = false;
            SPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(SPanel);
            SPanelHeader.SetBounds(292, 162, 420, 34);
            SPanelHeader.Visible = false;
            SPanelHeader.BackColor = Color.AliceBlue;
            SPanelHeader.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(SPanelHeader);
            SPanelHeader.Controls.Add(SPanelText);
            SPanelText.Location = new Point(10, 10);

            res = proxy.GetUser(name);
            _name = cuenta;

            var urlimage = newURL + res.foto;
            Image image = Image.FromFile(urlimage);
            ImagenPerfil.Image = image;
            ImagenPerfil.SetBounds(224, 72, 140, 130);
            ImagenPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(ImagenPerfil);

            InitializeComponent();
            TopPanel.SendToBack();
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            ConfigPanel.Visible = false;
            ImagesPanel.AutoScroll = true;

            ConfigPanel.BorderStyle = BorderStyle.FixedSingle;

            BPanel.AutoScroll = true;
            BPanel.Visible = false;
            BPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(BPanel);

            if (!miPerfil)
            {
                BGuardado.Visible = false;
                GuardadoPic.Visible = false;
            }
            else
            {
                SeguirB.Visible = false;
            }

            // Resuperar estado boton Seguir
            InfoPerfil();
            NombreCompleto.Text = res.nombre;
            SeguirB.Location = new Point(NombreUsuario.Location.X+NombreUsuario.Text.Length*12+20-NombreUsuario.Text.Length,SeguirB.Location.Y);

            //Publicaciones DEFAULT
            publicaciones = true;
            PostsPic.Image = Image.FromFile(newURL + "Imagenes/Posts.png");
            GuardadoPic.Image = Image.FromFile(newURL + "Imagenes/GuardadoUnactive.png");

            CargarPublicaciones();
        }

        private void PerfilUsuario(string user)
        {
            this.Hide();
            Form perfil;
            if (user == _name) perfil = new Perfil(true, user, _name);
            else perfil = new Perfil(false, user, _name);
            perfil.StartPosition = FormStartPosition.Manual;
            perfil.Location = this.Location;
            perfil.ShowDialog();
            this.Close();
        }

        void InfoPerfil()
        {
            var estado = proxy.SeguirEstado(_name, res.user);
            if (!estado) SeguirB.Text = "Seguir";
            else SeguirB.Text = "Siguiendo";
            ColorSeguirB();

            //CargarImagenes();
            Seguidores.Text = res.seguidores.Count() + "  seguidores";
            Seguidos.Text = res.seguidos.Count() + "  seguidos";
            Publicaciones.Text = res.posts.Count() + "  publicaciones";
            NombreUsuario.Text = res.user;

            Biografia.Multiline = true;
            Biografia.Text = res.biografia;
            Biografia.Font = new Font("Calibri", 9);
            Biografia.AutoSize = true;
            Biografia.BorderStyle = BorderStyle.None;
            Biografia.ReadOnly = true;
            Biografia.Width = 350;
            Biografia.BackColor = Color.White;
            Biografia.Height = (SendMessage(Biografia.Handle.ToInt32(), EM_GETLINECOUNT, 0, 0)) * 15;
            Biografia.Cursor = Cursors.Default;
            Biografia.Location = new Point(NombreUsuario.Location.X, Biografia.Location.Y);
            Biografia.Click += (s, ev) => { TopPanel.Focus(); SPanel.Visible = false; SPanelHeader.Visible = false; };
        }
        private void Perfil_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            TopPanel.Focus();
            ConfigPanel.Visible = false;
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form inicio = new Inicio(_name);
            inicio.StartPosition = FormStartPosition.Manual;
            inicio.Location = this.Location;
            inicio.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            TopPanel.Focus();
            ConfigPanel.Visible = false;
            SPanel.Controls.Clear();
            SPanel.BringToFront();
            SPanel.Visible = true;
            SPanel.AutoScroll = true;
            SPanelHeader.Visible = false;
            SPanelText.Text = "Seguidores";
            int y = 8;
            var tamanio = 0;
            SPanel.Height = tamanio;
            foreach (var item in res.seguidores)
            {
                var temp = new ConstructorSeguido(SPanel, 0, y, PerfilUsuario, UpdatePerfil, _name, item).CrearObjeto();
                temp.crearPanel();
                tamanio += temp.obtenerPanel().Height;
                if (tamanio < 248)
                    SPanel.Height = tamanio + 8;
                SPanel.Controls.Add(temp.obtenerPanel());
                y += 48;
                SPanelHeader.Visible = true;
                SPanel.Location = new Point(SPanel.Location.X, 160);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            TopPanel.Focus();
            ConfigPanel.Visible = false;
            SPanel.Controls.Clear();
            SPanel.BringToFront();
            SPanel.Visible = true;
            SPanel.AutoScroll = true;
            SPanelHeader.Visible = false;
            SPanelText.Text = "Seguidos";
            int y = 8;
            var tamanio = 0;
            SPanel.Height = tamanio;
            foreach (var item in res.seguidos)
            {
                var temp = new ConstructorSeguido(SPanel, 0, y, PerfilUsuario, UpdatePerfil, _name, item).CrearObjeto();
                temp.crearPanel();
                tamanio += temp.obtenerPanel().Height;
                if (tamanio < 248)
                    SPanel.Height = tamanio + 8;
                SPanel.Controls.Add(temp.obtenerPanel());
                y += 48;
                SPanelHeader.Visible = true;
                SPanel.Location = new Point(SPanel.Location.X, 160);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BPanel.Controls.Clear();
            BPanel.BringToFront();
            y = 6;
            var tamanio = 0;
            BPanel.Height = tamanio;
            if (TBuscar.Text != "" && TBuscar.Text != "Buscar")
            {
                BPanel.Visible = false;
                var lista = proxy.Buscar(_name,TBuscar.Text);
                foreach (var item in lista)
                {
                    var perfil = new ConstructorPerfilBusqueda(BPanel, 0, y, PerfilUsuario, item).CrearObjeto();
                    perfil.crearPanel();
                    tamanio += perfil.obtenerPanel().Height;
                    if (tamanio < 220)
                        BPanel.Height = tamanio+8;
                    BPanel.Controls.Add(perfil.obtenerPanel());
                    y += 44;
                }
                BPanel.Visible = true;
            }
            else
            {
                BPanel.Visible = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (TBuscar.Text == "")
            {
                TBuscar.Text = "Buscar";
                TBuscar.ForeColor = Color.Silver;
            }
            BPanel.Visible = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (TBuscar.Text == "Buscar")
            {
                TBuscar.Text = "";
                TBuscar.ForeColor = Color.Black;
            }
            ConfigPanel.Visible = false;
            BPanel.Visible = true;
            SPanelHeader.Visible = false;
            SPanel.Visible = false;
        }

        private void Perfil_Click(object sender, EventArgs e)
        {
            if (TBuscar.Text == "")
            {
                TBuscar.Text = "Buscar";
                TBuscar.ForeColor = Color.Silver;
            }
            TopPanel.Focus();
            ConfigPanel.Visible = false;
            SPanel.Visible = false;
            SPanelHeader.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (ConfigPanel.Visible) ConfigPanel.Visible = false;
            else ConfigPanel.Visible = true;
            ConfigPanel.Focus();
            SPanelHeader.Visible = false;
            SPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new LogIn();
            login.StartPosition = FormStartPosition.Manual;
            login.Location = this.Location;
            login.ShowDialog();
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            ConfigPanel.Visible = false;
            SPanel.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Guardado
            SPanelHeader.Visible = false;
            SPanel.Visible = false;
            PostsPic.Image = Image.FromFile(newURL + "Imagenes/PostsUnactive.png"); 
            GuardadoPic.Image = Image.FromFile(newURL + "Imagenes/Guardado.png"); 
            TopPanel.Focus();
            ConfigPanel.Visible = false;
            CargarImagenes();
            CargarGuardado();
            publicaciones = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Publicaciones
            SPanelHeader.Visible = false;
            SPanel.Visible = false;
            PostsPic.Image = Image.FromFile(newURL + "Imagenes/Posts.png");
            GuardadoPic.Image = Image.FromFile(newURL + "Imagenes/GuardadoUnactive.png");
            TopPanel.Focus();
            ConfigPanel.Visible = false;
            CargarImagenes();
            CargarPublicaciones();
            publicaciones = true;
        }

        void CargarPublicaciones()
        {
            foreach (var item in res.posts)
            {
                PictureBox boton = new PictureBox();
                boton.Cursor = Cursors.Hand;
                ImagesPanel.Controls.Add(boton);
                var urlimage = newURL + item.url;
                var image = Image.FromFile(urlimage);
                boton.SizeMode = PictureBoxSizeMode.Zoom;
                boton.BackColor = Color.Black;
                boton.Image = image;
                boton.SetBounds(x, y, 160, 160);
                x += 172;
                if (x >= 600)
                {
                    x = 30;
                    y += 172;
                }
                boton.Click += (s, ev) => {
                    item.likes = proxy.ObtenerPost(item.usuario, item.id).likes;
                    var ventana = new VentanaPost(PerfilUsuario, item, _name, UpdatePerfil, this, null, item.likes);
                };
            }
        }

        void CargarGuardado()
        {
            foreach (var item in res.guardado)
            {
                PictureBox boton = new PictureBox();
                boton.Cursor = Cursors.Hand;
                var post = proxy.ObtenerPost(item.usuario, item.id);
                var urlimage = newURL + post.url;
                var image = Image.FromFile(urlimage);
                boton.Image = image;
                boton.SizeMode = PictureBoxSizeMode.Zoom;
                boton.BackColor = Color.Black;
                boton.SetBounds(x, y, 160, 160);
                ImagesPanel.Controls.Add(boton);
                x += 172;
                if (x >= 600)
                {
                    x = 30;
                    y += 172;
                }
                boton.Click += (s, ev) => {
                    item.likes = proxy.ObtenerPost(item.usuario, item.id).likes;
                    var ventana = new VentanaPost(PerfilUsuario, item, _name, UpdatePerfil, this, null, item.likes);
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Editar Perfil
            ConfigPanel.Visible = false;
            var editar = new EditarPerfil(_name, this, UpdatePerfilData);
        }

        private void UpdatePerfilData()
        {
            res = proxy.GetUser(_name);
            var urlimage = newURL + res.foto;
            Image image = Image.FromFile(urlimage);
            ImagenPerfil.Image = image;
            Biografia.Text = res.biografia;
        }

        private void CargarImagenes()
        {
            ImagesPanel.Controls.Clear();
            x = 30;
            y = 12;
            Panel panel = new Panel();
            panel.Dock = DockStyle.Bottom;
            panel.SetBounds(0, 322, 1060, 20);
            ImagesPanel.Controls.Add(panel);
        }

        private void ControlPanel_Click(object sender, EventArgs e)
        {
            TopPanel.Focus();
            SPanel.Visible = false;
            SPanelHeader.Visible = false;
        }

        private void ImagesPanel_Click(object sender, EventArgs e)
        {
            TopPanel.Focus();
            SPanel.Visible = false;
            SPanelHeader.Visible = false;
        }

        public void UpdatePerfil()
        {
            res = proxy.GetUser(perfil);
            InfoPerfil();
            CargarImagenes();
            if (publicaciones) CargarPublicaciones();
            else CargarGuardado();
        } 

        private void SeguirB_Click(object sender, EventArgs e)
        {
            SPanel.Visible = false;
            SPanelHeader.Visible = false;
            proxy.SeguirCambiar(_name, res.user);
            if (SeguirB.Text == "Seguir") 
            {
                SeguirB.Text = "Siguiendo";
            }
            else
            {
                SeguirB.Text = "Seguir";
            }
            ColorSeguirB();
            UpdatePerfil();
        }

        private void ColorSeguirB()
        {
            if (SeguirB.Text == "Seguir")
            {
                SeguirB.ForeColor = Color.DeepSkyBlue;
                SeguirB.BackColor = Color.White;
            }
            else
            {
                SeguirB.ForeColor = Color.White;
                SeguirB.BackColor = Color.DeepSkyBlue;
            }
        }
    }
}
