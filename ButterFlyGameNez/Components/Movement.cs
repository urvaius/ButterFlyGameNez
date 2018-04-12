using Microsoft.Xna.Framework;
using Nez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace ButterFlyGameNez.Components
{
    public class Movement : Component, IUpdatable
    {
        public float speed = 100f;
        public void update()
        {
            var moveDir = Vector2.Zero;
            if (Input.isKeyDown(Keys.Left))
            {
                moveDir.X = -1f;
            }
            else if (Input.isKeyDown(Keys.Right))
            {
                moveDir.X = 1f;
            }

            if (Input.isKeyDown(Keys.Up))
            {
                moveDir.Y = -1f;
            }
            else if (Input.isKeyDown(Keys.Down))
            {
                moveDir.Y = 1f;

            }
            entity.transform.position += moveDir * speed * Time.deltaTime;
        }
    }
}
