using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButterFlyGameNez.Scenes
{
    public class StartScene : Scene
    {

        public StartScene()
        {
            clearColor = Color.DarkGreen;
            addRenderer(new DefaultRenderer(0, null));
        }

        public override void initialize()
        {
            base.initialize();
            var texture = content.Load<Texture2D>(@"Textures\butterfly1");
            var entityOne = createEntity("butterfly");
            entityOne.addComponent(new Sprite(texture));


        }
    }
}
