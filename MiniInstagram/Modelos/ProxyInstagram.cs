using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MiniInstagram.Modelos.ModelInstagram;

namespace MiniInstagram.Modelos
{
    public class ProxyInstagram : IProxyInstagram
    {
        private static ProxyInstagram _instance = null;
        private RestClient _client;
        private string _urlBase; 
        public static ProxyInstagram Instance  // Singleton
        {
            get{
                if (_instance == null) _instance = new ProxyInstagram();
                return _instance; 
            }
        }

        public ProxyInstagram()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();
            _urlBase = config.GetConnectionString("APIDev");
            _client = new RestClient(_urlBase);
        }
        public bool LogIn(string user, string correo, string contrasenia)
        {
            var encriptador = new Contrasenia(contrasenia);
            contrasenia = encriptador.Encriptar();
            var request = new RestRequest($"LogIn?user={user}&correo={correo}&contrasenia={contrasenia}");
            var response = _client.Get<bool>(request);
            return response.Data;
        }

        public bool Registro(string user, string nombre, string correo, string contrasenia)
        {
            var encriptador = new Contrasenia(contrasenia);
            contrasenia = encriptador.Encriptar();
            var request = new RestRequest($"Registro?user={user}&nombre={nombre}&correo={correo}&contrasenia={contrasenia}");
            var response = _client.Post<bool>(request);
            return response.Data;
        }

        public Instagram GetUser(string user)
        {
            var request = new RestRequest($"GetUser?user={user}");
            var response = _client.Get<Instagram>(request);
            return response.Data;
        }

        public bool SeguirEstado(string user, string target)
        {
            var request = new RestRequest($"SeguirEstado?user={user}&nombre={target}");
            var response = _client.Get<bool>(request);
            return response.Data;
        }

        public void SeguirCambiar(string user, string target)
        {
            var request = new RestRequest($"SeguirCambiar?user={user}&nombre={target}");
            _client.Post(request);
        }

        public List<string> Buscar(string user, string busqueda)
        {
            var request = new RestRequest($"Buscar?user={user}&busqueda={busqueda}");
            var response = _client.Get<List<string>>(request);
            return response.Data;
        }

        public Instagram GetFeed(string user)
        {
            var request = new RestRequest($"GetFeed?user={user}");
            var response = _client.Get<Instagram>(request);
            return response.Data;
        }

        public bool LikeEstado(string user, string target, int id)
        {
            var request = new RestRequest($"LikeEstado?user={user}&nombre={target}&id={id}");
            var response = _client.Get<bool>(request);
            return response.Data;
        }

        public bool GuardarEstado(string user, string target, int id)
        {
            var request = new RestRequest($"GuardarEstado?user={user}&nombre={target}&id={id}");
            var response = _client.Get<bool>(request);
            return response.Data;
        }

        public void LikeCambiar(string user, string target, int id)
        {
            var request = new RestRequest($"LikeCambiar?user={user}&nombre={target}&id={id}");
            _client.Post(request);
        }

        public void GuardarCambiar(string user, string target, int id)
        {
            var request = new RestRequest($"GuardarCambiar?user={user}&nombre={target}&id={id}");
            _client.Post(request);
        }

        public void GuardarComentario(string user, string nombre, int id, string texto)
        {
            var request = new RestRequest($"GuardarComentario?user={user}&nombre={nombre}&id={id}&texto={texto}");
            _client.Post(request);
        }

        public void BorrarComentario(string nombre,int id, int id_comment)
        {
            var request = new RestRequest($"BorrarComentario?nombre={nombre}&id={id}&id_comment={id_comment}");
            _client.Post(request);
        }

        public void CrearPost(string usuario, string titulo, string descripcion, string url)
        {
            var request = new RestRequest($"CrearPost?usuario={usuario}&titulo={titulo}&descripcion={descripcion}&url={url}");
            _client.Post(request);
        }

        public Post ObtenerPost(string usuario, int id)
        {
            var request = new RestRequest($"ObtenerPost?usuario={usuario}&id={id}");
            var response = _client.Get<Post>(request);
            return response.Data;
        }

        public void BorrarPost(string usuario, int id)
        {
            var request = new RestRequest($"BorrarPost?usuario={usuario}&id={id}");
            _client.Post(request);
        }

        public void EditarPerfil(string user, string url, string biografia)
        {
            var request = new RestRequest($"EditarPerfil?user={user}&url={url}&biografia={biografia}");
            _client.Post(request);
        }

        public void BorrarStories(string usuario)
        {
            var request = new RestRequest($"BorrarStories?usuario={usuario}");
            _client.Post(request);
        }

        public void CrearStorie(string usuario, string url)
        {
            var request = new RestRequest($"CrearStorie?usuario={usuario}&url={url}");
            _client.Post(request);
        }
    }
}
