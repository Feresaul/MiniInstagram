using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniInstagram.Modelos
{
    public interface IObjeto
    {
        void crearPanel();
        Panel obtenerPanel();
    }
}
