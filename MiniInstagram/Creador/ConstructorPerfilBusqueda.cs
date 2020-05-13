using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniInstagram.Modelos
{
    public class ConstructorPerfilBusqueda : Constructor
    {
        private Panel BusquedaPanel;
        private int x;
        private int y;
        private Action<string> PerfilUsuario;
        private string user;

        public ConstructorPerfilBusqueda(Panel BusquedaPanel, int x, int y, Action<string> PerfilUsuario, string user)
        {
            this.BusquedaPanel = BusquedaPanel;
            this.x = x;
            this.y = y;
            this.PerfilUsuario = PerfilUsuario;
            this.user = user;
        }
        public override IObjeto CrearObjeto()
        {
            return new PerfilBusqueda(BusquedaPanel, x, y, PerfilUsuario, user);
        }
    }
}
