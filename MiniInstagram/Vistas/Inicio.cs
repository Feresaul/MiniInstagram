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
using MiniInstagram.Modelos;
using System.Diagnostics.Tracing;
using static MiniInstagram.Modelos.ModelInstagram;
using System.IO;
using System.Threading;

namespace MiniInstagram.Vistas
{
    public partial class Inicio : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private int y = 0;
        private int y2 = 10;
        private string name;
        private ProxyInstagram proxy = new ProxyInstagram();
        private string newURL;
        public Inicio(string data)
        {
            string url = Directory.GetCurrentDirectory();
            for (int i = 0; i < url.Length - 9; i++)
                newURL += url[i];
            proxy = new ProxyInstagram();
            var res = proxy.GetUser(data);

            name = res.user; // DB User

            InitializeComponent();
            TopPanel.SendToBack();
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            ConfigPanel.Visible = false;
            PostsPanel.AutoScroll = true;
            StoryPanel.AutoScroll = true;
            this.ActiveControl = PostsPanel;

            BPanel.BringToFront();
            BPanel.AutoScroll = true;
            BPanel.Visible = false;
            BPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(BPanel);

            ConfigPanel.BorderStyle = BorderStyle.FixedSingle;

            NombreUsuario.Text = res.user;
            NombreCompleto.Text = res.nombre;

            var urlimage = newURL + res.foto;
            Image image = Image.FromFile(urlimage);
            ImagenPerfil.Image = image;
            ImagenPerfil.Width = 44;
            ImagenPerfil.Height = 44;

            //Cargar Feed DB
            var insta = proxy.GetFeed(res.user);
            foreach (Post item in insta.publico)
            {
                var post = new ConstructorPosts(PostsPanel, 0, y, PerfilUsuario, item, name, UpdatePosts, this).CrearObjeto();
                post.crearPanel();
                PostsPanel.Controls.Add(post.obtenerPanel());
                y += post.obtenerPanel().Height + 20;
            }

            // My Stories
            if (insta.stories.stories.Count > 0)
            {
                var Mystory = new ConstructorStories(StoryPanel, 0, y2, StorieUsuario, insta.stories, res.user, UpdateStories).CrearObjeto();
                Mystory.crearPanel();
                StoryPanel.Controls.Add(Mystory.obtenerPanel());
                y2 += StoryPanel.Height / 6 + 10;
            }
            //

            foreach (Stories item in insta.publicStories)
            {
                var story = new ConstructorStories(StoryPanel, 0, y2, StorieUsuario, item, res.user, UpdateStories).CrearObjeto();
                story.crearPanel();
                StoryPanel.Controls.Add(story.obtenerPanel());
                y2 += StoryPanel.Height / 6 + 10;
            }
        }
        private void PerfilUsuario(string user)
        {
            this.Hide();
            Form perfil;
            if (user == name) perfil = new Perfil(true, user, name);
            else  perfil = new Perfil(false, user, name);
            perfil.StartPosition = FormStartPosition.Manual;
            perfil.Location = this.Location;
            perfil.ShowDialog();
            this.Close();
        }

        public void UpdateStories()
        {
            var insta = proxy.GetFeed(NombreUsuario.Text);
            StoryPanel.Controls.Clear();
            y2 = 10;

            if (insta.stories.stories.Count > 0)
            {
                var Mystory = new ConstructorStories(StoryPanel, 0, y2, StorieUsuario, insta.stories, name, UpdateStories).CrearObjeto();
                Mystory.crearPanel();
                StoryPanel.Controls.Add(Mystory.obtenerPanel());
                y2 += StoryPanel.Height / 6 + 10;
            }

            foreach (Stories item in insta.publicStories)
            {
                var story = new ConstructorStories(StoryPanel, 0, y2, StorieUsuario, item, name, UpdateStories).CrearObjeto();
                story.crearPanel();
                StoryPanel.Controls.Add(story.obtenerPanel());
                y2 += StoryPanel.Height / 6 + 10;
            }
            StoryPanel.Focus();
        }

        private void UpdatePosts()
        {
            var position = PostsPanel.VerticalScroll.Value;
            var insta = proxy.GetFeed(NombreUsuario.Text);
            PostsPanel.Controls.Clear();
            y = 0;
            foreach (Post item in insta.publico)
            {
                var post = new ConstructorPosts(PostsPanel, 0, y, PerfilUsuario, item, name, UpdatePosts, this).CrearObjeto();
                post.crearPanel();
                PostsPanel.Controls.Add(post.obtenerPanel());
                y += post.obtenerPanel().Height + 20;
            }
            PostsPanel.AutoScrollPosition = new Point(0, position);
            PostsPanel.Focus();
        }

        private void StorieUsuario(List<Storie> stories, string usuario)
        {
            var panel = new StoriesPanel(stories, PerfilUsuario, this, usuario, TopPanel);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            ConfigPanel.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (ConfigPanel.Visible) ConfigPanel.Visible = false;
            else ConfigPanel.Visible = true;
            ConfigPanel.Focus();
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

        private void NombreUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form perfil = new Perfil(true, name, name);
            perfil.StartPosition = FormStartPosition.Manual;
            perfil.Location = this.Location;
            perfil.ShowDialog();
            this.Close();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            TopPanel.Focus();
            ConfigPanel.Visible = false;
        }

        private void PostsPanel_Click(object sender, EventArgs e)
        {
            PostsPanel.Focus();
            ConfigPanel.Visible = false;
        }

        private void StoryPanel_MouseClick(object sender, MouseEventArgs e)
        {
            PostsPanel.Focus();
            ConfigPanel.Visible = false;
        }

        private void TopPanel_MouseClick(object sender, EventArgs e)
        {
            TopPanel.Focus();
            ConfigPanel.Visible = false;
        }

        private void TBuscarI_Enter(object sender, EventArgs e)
        {
            if (TBuscarI.Text == "Buscar")
            {
                TBuscarI.Text = "";
                TBuscarI.ForeColor = Color.Black;
            }
            ConfigPanel.Visible = false;
            BPanel.Visible = true;
        }

        private void TBuscarI_Leave(object sender, EventArgs e)
        {
            if (TBuscarI.Text == "")
            {
                TBuscarI.Text = "Buscar";
                TBuscarI.ForeColor = Color.Silver;
            }
            BPanel.Visible = false;
        }

        private void EditarPerfil_Click(object sender, EventArgs e)
        {

        }

        private void TBuscarI_TextChanged(object sender, EventArgs e)
        {
            BPanel.Controls.Clear();
            BPanel.BringToFront();
            y = 6;
            var tamanio = 0;
            BPanel.Height = tamanio;
            if (TBuscarI.Text != "" && TBuscarI.Text != "Buscar")
            {
                BPanel.Visible = false;
                var proxy = new ProxyInstagram();
                var lista = proxy.Buscar(name,TBuscarI.Text);
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

        private void button8_Click(object sender, EventArgs e)
        {
            var publicar = new Publicar(this, TopPanel, name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stories = new AddStories(this, TopPanel, name, UpdateStories);
        }
    }
}
