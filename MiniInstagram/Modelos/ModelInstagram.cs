using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniInstagram.Modelos
{
    public class ModelInstagram
    {
        public class Comment
        {
            public int id { set; get; }
            public string name { set; get; }
            public string data { set; get; }
        }

        public class Storie
        {
            public DateTime date { set; get; }
            public string url { set; get; }
            public int id { set; get; }

            public Storie()
            {
                date = new DateTime();
            }
        }

        public class Stories
        {
            public List<Storie> stories { set; get; }
            public string nombre { set; get; }

            public Stories()
            {
                stories = new List<Storie>();

            }
        }

        public class Post
        {
            public int id { set; get; }
            public string usuario { set; get; }
            public string foto { set; get; }
            public string titulo { set; get; }
            public string descripcion { set; get; }
            public DateTime date { set; get; }
            public string url { set; get; }
            public int likes { set; get; }
            public List<Comment> comentarios { set; get; }

            public Post()
            {
                comentarios = new List<Comment>();
                date = new DateTime();
            }
        }
        public class Instagram
        {
            public string user { set; get; }
            public List<Post> posts { set; get; }
            public List<Post> guardado { set; get; }
            public string contrasenia { set; get; }
            public string correo { set; get; }
            public string nombre { set; get; }
            public string biografia { set; get; }
            public string foto { set; get; }
            public List<Post> publico { set; get; }
            public Stories stories { set; get; }
            public List<Stories> publicStories { set; get; }
            public List<string> seguidos { set; get; }
            public List<string> seguidores { set; get; }

            public Instagram()
            {
                contrasenia = null;
                publico = new List<Post>();
                seguidos = new List<string>();
                seguidores = new List<string>();
                posts = new List<Post>();
                guardado = new List<Post>();
                stories = new Stories();
                publicStories = new List<Stories>();
            }

        }
    }
}
