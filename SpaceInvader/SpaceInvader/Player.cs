using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvader
{
    class Player : IPlayer
    {
        private int Lives;
        private Rectangle Tank;

        public Player()
        {
            Tank = new Rectangle(475, 10, 50, 25);
            Lives = 3;
        }

        public Vector2 Velocity
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Dead
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Rectangle Hitbox
        {
            get
            {
                return Tank;
            }

            set
            {
                Tank = value;
            }
        }

        public void CheckCollisions(IMissile m)
        {
            //Gestion collision avec missile
            if (m.Hitbox.Intersects(Tank))
            {
                Lives--;
            }
            
            //Mur gauche
            if(Tank.X < 2)
            {
                Tank.X = 2;
            }

            //Mur droit
            if(Tank.Right > 998)
            {
                Tank.X = 998 - Tank.Width - 1;
            }
        }

        public void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
