using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniInstagram.Modelos
{
    public class ConstructorSeguido : Constructor
    {
        private Panel SeguidoPanel = new Panel();
        private int x;
        private int y;
        private Action<string> PerfilUsuario;
        private Action Update;
        private string usuario;
        private string perfil;
        public ConstructorSeguido(Panel SeguidoPanel, int x, int y, Action<string> PerfilUsuario, Action Update, string usuario, string perfil)
        {
            this.SeguidoPanel = SeguidoPanel;
            this.x = x;
            this.y = y;
            this.PerfilUsuario = PerfilUsuario;
            this.Update = Update;
            this.usuario = usuario;
            this.perfil = perfil;
        }
        public override IObjeto CrearObjeto()
        {
            return new Seguido(SeguidoPanel, x, y, PerfilUsuario, Update, usuario, perfil);
        }
    }
}
