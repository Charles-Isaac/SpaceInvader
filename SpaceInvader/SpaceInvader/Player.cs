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

        public Player()
        {
            Pos.X = 500;
            Pos.Y = 10;
            Lives = 3;   
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

        public void CheckCollisions(IMissile m)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
