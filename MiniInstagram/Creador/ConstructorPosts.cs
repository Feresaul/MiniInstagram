using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MiniInstagram.Modelos.ModelInstagram;

namespace MiniInstagram.Modelos
{
    public class ConstructorPosts : Constructor
    {
        private Panel PostsPanel = new Panel();
        private int x;
        private int y;
        private Action<string> PerfilUsuario;
        private Post post = new Post();
        private string user;
        private Action UpdatePosts;
        private Form Principal;
        public ConstructorPosts(Panel PostsPanel, int x, int y, Action<string> PerfilUsuario, Post post, string user, Action UpdatePosts, Form Principal)
        {
            this.PostsPanel = PostsPanel;
            this.x = x;
            this.y = y;
            this.PerfilUsuario = PerfilUsuario;
            this.post = post;
            this.user = user;
            this.UpdatePosts = UpdatePosts;
            this.Principal = Principal;
        }
        public override IObjeto CrearObjeto()
        {
            return new Posts(PostsPanel, x, y, PerfilUsuario, post, user, UpdatePosts, Principal);
        }
    }
}
