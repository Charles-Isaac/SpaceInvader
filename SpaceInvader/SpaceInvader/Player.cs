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
        private Vector2 Pos;
        private Vector2 PlayerSize;

        public Player()
        {
            Pos.X = 500;
            Pos.Y = 10;

            Lives = 3;

            PlayerSize.X = 50;
            PlayerSize.Y = 25;  
        }

        public Vector2 Position
        {
            get
            {
                return Pos;
            }

            set
            {
                Pos = value;
            }
        }

        public Vector2 Size
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

        public Vector2 Size
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

        public void CheckCollisions(IMissile m)
        {
            //Création des "hitbox"
            Rectangle missile = new Rectangle((int)m.Position.X,
                (int)m.Position.Y, (int)m.Size.X, (int)m.Size.Y);
            Rectangle Tank = new Rectangle((int)this.Position.X, (int)this.Position.Y,
                (int)this.Size.X, (int)this.Size.Y);

            //Gestion collision avec missile
            if (missile.Intersects(Tank))
            {
                Lives--;
            }
            
            //Mur gauche
            if(Pos.X < 2)
            {
                Pos.X = 2;
            }

            //Mur droit
            if(Pos.X + Size.X > 998)
            {
                Pos.X = 998 - Size.X - 1;
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
