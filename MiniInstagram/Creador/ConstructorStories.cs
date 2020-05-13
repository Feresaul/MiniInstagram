using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MiniInstagram.Modelos.ModelInstagram;

namespace MiniInstagram.Modelos
{
    public class ConstructorStories : Constructor
    {
        private Panel StoryPanel;
        private int x;
        private int y;
        private Action<List<Storie>, string> StoriesUsuario;
        private Stories storie;
        private string name;
        private Action Update;
        public ConstructorStories(Panel StoryPanel, int x, int y, Action<List<Storie>, string> StoriesUsuario, Stories storie, string name, Action Update)
        {
            this.StoryPanel = StoryPanel;
            this.x = x;
            this.y = y;
            this.StoriesUsuario = StoriesUsuario;
            this.storie = storie;
            this.name = name;
            this.Update = Update;
        }
        public override IObjeto CrearObjeto()
        {
            return new StoriesP(StoryPanel, x, y, StoriesUsuario, storie, name, Update);
        }
    }
}
