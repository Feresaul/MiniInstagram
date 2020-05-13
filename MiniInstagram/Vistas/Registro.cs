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

namespace MiniInstagram
{
    public partial class Registro : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private bool Contrasenia;
        private bool Error;
        public Registro()
        {
            InitializeComponent();
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            Contrasenia = true;
            panel3.SendToBack();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new LogIn();
            login.StartPosition = FormStartPosition.Manual;
            login.Location = this.Location;
            login.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Contrasenia)
            {
                TContra.UseSystemPasswordChar = true;
                Contrasenia = false;
            }
            else
            {
                TContra.UseSystemPasswordChar = false;
                Contrasenia = true;
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TCorreo.Text == "") { TCorreo.Text = "*"; Error = true; }
            if (TNombreC.Text == "") { TNombreC.Text = "*"; Error = true; }
            if (TContra.Text == "") { TContra.Text = ""; Error = true; }
            if (TNombreU.Text == "") { TNombreU.Text = "*"; Error = true; }
            if (Error)
            {
                TContra.Text = "";
                Error = false;
                return;
            }
            // Nombre de Usuario en DB disponible
            var proxy = new ProxyInstagram();
            var res = proxy.Registro(TNombreU.Text, TNombreC.Text, TCorreo.Text, TContra.Text);
            //
            if (res)
            {
                string name = TNombreU.Text;
                this.Hide();
                Form inicio = new Inicio(name);
                inicio.StartPosition = FormStartPosition.Manual;
                inicio.Location = this.Location;
                inicio.ShowDialog();
                this.Close();
            }
            else
            {
                Label label = new Label();
                label.Text = "usuario/correo ya registrados";
                label.ForeColor = Color.Red;
                Respuesta.Controls.Add(label);
                label.Width = Respuesta.Width - 50;
                label.Location = new Point(30, 0);
            }
        }
    }
}
