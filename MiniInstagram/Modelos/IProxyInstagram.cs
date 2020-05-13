using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MiniInstagram.Modelos.ModelInstagram;

namespace MiniInstagram.Modelos
{
    public interface IProxyInstagram
    {
        bool LogIn(string user, string correo, string contrasenia);
        bool Registro(string user, string nombre, string correo, string contrasenia);
        Instagram GetUser(string user);
        Instagram GetFeed(string user);
        bool SeguirEstado(string user, string target);
        void SeguirCambiar(string user, string target);
        bool LikeEstado(string user, string target, int id);
        void LikeCambiar(string user, string target, int id);
        bool GuardarEstado(string user, string target, int id);
        void GuardarCambiar(string user, string target, int id);
        void GuardarComentario(string user, string nombre, int id, string texto);
        void BorrarComentario(string nombre, int id, int id_comment);
        void CrearPost(string usuario, string titulo, string descripcion, string url);
        Post ObtenerPost(string usuario, int id);
        void BorrarPost(string usuario, int id);
        void CrearStorie(string usuario, string url);
        void BorrarStories(string usuario);
        List<string> Buscar(string user, string busqueda);
        void EditarPerfil (string user, string url, string biografia);
    }
}
