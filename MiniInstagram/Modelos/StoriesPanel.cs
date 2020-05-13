using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using static MiniInstagram.Modelos.ModelInstagram;

namespace MiniInstagram.Modelos
{
    public class StoriesPanel
    {
        private Panel principalPanel = new Panel();
        private Label nombre = new Label();
        private ImagenCircular imagen = new ImagenCircular();
        private PictureBox imagenPrincipal = new PictureBox();
        private Label tiempo = new Label();
        private ProxyInstagram proxy = new ProxyInstagram();
        private Button salir = new Button();
        private string newURL;
        private Action<string> PerfilUsuario;
        private Form Principal;
        List<Storie> stories = new List<Storie>();
        private string usuario;
        private Panel top = new Panel();
        private int index;
        private static System.Timers.Timer aTimer = new System.Timers.Timer();
        Action del = () => { };

        public StoriesPanel(List<Storie> stories, Action<string> _PerfilUsuario, Form Principal, string usuario, Panel top)
        {
            this.Principal = Principal;
            this.stories = stories;
            this.usuario = usuario;
            this.top = top;
            PerfilUsuario = _PerfilUsuario;
            index = 0;


            string url = Directory.GetCurrentDirectory();
            newURL = "";
            for (int i = 0; i < url.Length - 9; i++)
                newURL += url[i];

            Principal.Controls.Add(principalPanel);
            principalPanel.BringToFront();
            principalPanel.BackColor = Color.Black;

            Update();
        }

        private void Update()
        {
            aTimer.Stop();
            if (index > stories.Count-1)
            {
                Principal.Controls.Remove(principalPanel);
                Principal.ActiveControl = top;
                return;
            }
            else
            {
                aTimer = new System.Timers.Timer(2500);
                aTimer.AutoReset = true;
                aTimer.Start();
                aTimer.Elapsed += async (sender, e) => principalPanel.Invoke(new MethodInvoker(() => { Update(); }));
            }

            var res = proxy.GetUser(usuario);
            principalPanel.Controls.Clear();

            principalPanel.SetBounds(202, 62, 328, 418);
            principalPanel.BorderStyle = BorderStyle.FixedSingle;
            principalPanel.BringToFront();

            imagen.SetBounds(14, 10, 34, 34);
            var urlimage = res.foto;
            Image image = Image.FromFile(newURL + urlimage);
            imagen.Image = image;
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            principalPanel.Controls.Add(imagen);

            nombre.Text = usuario;
            nombre.ForeColor = Color.White;
            nombre.Font = new Font("Calibri", 10, FontStyle.Bold);
            principalPanel.Controls.Add(nombre);
            nombre.Cursor = Cursors.Hand;
            nombre.SetBounds(54, 20, nombre.Text.Length * 9 + 2, 24);
            nombre.BackColor = Color.Transparent;
            nombre.Click += (s, ev) => { PerfilUsuario(usuario); };

            salir.Text = "X";
            salir.Cursor = Cursors.Hand;
            principalPanel.Controls.Add(salir);
            salir.SetBounds(principalPanel.Width - 40, 8, 30, 20);
            salir.FlatStyle = FlatStyle.Flat;
            salir.FlatAppearance.BorderSize = 0;
            salir.BackColor = Color.White;
            salir.Click += (s, ev) => { Principal.Controls.Remove(principalPanel); Principal.ActiveControl = top; };

            principalPanel.Controls.Add(imagenPrincipal);
            imagenPrincipal.SetBounds(0, 0, principalPanel.Width, principalPanel.Height);
            imagenPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            urlimage = newURL + stories[index].url;
            var image2 = Image.FromFile(urlimage);
            imagenPrincipal.Image = image2;

            var horas = Math.Truncate((DateTime.Now - stories[index].date).TotalHours);
            var minutos = Math.Truncate((DateTime.Now - stories[index].date).TotalMinutes);
            var segundos = Math.Truncate((DateTime.Now - stories[index].date).TotalSeconds);
            if (horas > 0)
                tiempo.Text = horas.ToString() + "h";
            else if (minutos > 0)
                tiempo.Text = minutos.ToString() + "m";
            else if (segundos > 0)
                tiempo.Text = segundos.ToString() + "s";
            tiempo.ForeColor = Color.White;
            tiempo.Font = new Font("Calibri", 10);
            principalPanel.Controls.Add(tiempo);
            tiempo.SetBounds(nombre.Location.X + nombre.Width + 6, 20, tiempo.Text.Length * 9 + 8, 24);
            tiempo.BackColor = Color.Transparent;
            tiempo.BringToFront();

            index++;
        }

        public Panel GetPanel()
        {
            return principalPanel;
        }

        public void killPanel()
        {
            Principal.Controls.Remove(principalPanel);
        }
    }
}