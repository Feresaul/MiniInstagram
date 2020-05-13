using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Globalization;

namespace MiniInstagram.Modelos
{
    public class Comentario : IObjeto
    {
        private const int EM_GETLINECOUNT = 0xba;
        [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);
        private Panel panel = new Panel();
        private Label _autor = new Label();
        private TextBox comment = new TextBox();
        private string autor;
        private string comentario;
        private Action<string> PerfilUsuario;
        public Comentario(string autor, string comentario, Action<string> PerfilUsuario)
        {
            this.autor = autor;
            this.comentario = comentario;
            this.PerfilUsuario = PerfilUsuario;
        }

        public void crearPanel()
        {
            _autor.Text = autor;
            _autor.Font = new Font("Calibri", 9, FontStyle.Bold);
            _autor.Cursor = Cursors.Hand;
            _autor.Click += (s, ev) => { PerfilUsuario(autor); };
            _autor.Location = new Point(0, 0);
            _autor.Width = _autor.Text.Length * 7+2;

            comment.Multiline = true;
            comment.Text = comentario;
            comment.Location = new Point(_autor.Location.X + _autor.Width + 6, _autor.Location.Y);
            comment.Font = new Font("Calibri", 9);
            comment.AutoSize = true;
            comment.BorderStyle = BorderStyle.None;
            comment.ReadOnly = true;
            comment.Width = 258 - _autor.Width;
            comment.BackColor = Color.White;
            comment.Height = (SendMessage(comment.Handle.ToInt32(), EM_GETLINECOUNT, 0, 0)) * 15;
            comment.Cursor = Cursors.Default;
            comment.Click += (s, ev) => { panel.Focus(); };

            panel.Width = 258;
            panel.Height = (int)comment.Height;
            panel.Controls.Add(_autor);
            panel.Controls.Add(comment);
            panel.Click += (s, ev) => { panel.Focus(); };
        }

        public Panel obtenerPanel()
        {
            return panel;
        }
    }
}
