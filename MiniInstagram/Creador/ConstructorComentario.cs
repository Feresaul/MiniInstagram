using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniInstagram.Modelos
{
    public class ConstructorComentario : Constructor
    {
        private string _autor;
        private string _comentario;
        Action<string> _PerfilUsuario;

        public ConstructorComentario(string autor, string comentario, Action<string> PerfilUsuario)
        {
            _autor = autor;
            _comentario = comentario;
            _PerfilUsuario = PerfilUsuario;
        }
        public override IObjeto CrearObjeto()
        {
            return new Comentario(_autor, _comentario, _PerfilUsuario);
        }
    }
}
