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
    public class Invader : IEntity
    {
        private Vector2 m_Position;
        private bool m_GoingRight; // True if going right, false if going left
        private bool m_BottomMost; // True if it's the bottom-most entity in its column
        private Vector2 m_Velocity;
        private double m_NextShootTime;

        private int m_ArrayPosX;
        private int m_ArrayPosY;
        private bool m_Dead;

        private Vector2 m_Size;


        public Invader(int x, int y)
        {
            m_ArrayPosX = x;
            m_ArrayPosY = y;
            m_BottomMost = y == 4;
            this.ChangeDirection(true);
            m_Size = new Vector2(50, 25);
            m_Position = new Vector2(x * 15 + x * 50 + 15, y * 40 + y * 25 + 40);
        }

        public Vector2 Position
        {
            get
            {
                return m_Position;
            }

            set
            {
                m_Position = value;
            }
        }

        public Vector2 Velocity
        {
            get
            {
                return m_Velocity;
            }

            set
            {
                m_Velocity = value;
            }
        }

        public Vector2 Size
        {
            get
            {
                return m_Size;
            }

            set
            {
                m_Size = value;
            }
        }

        public bool Dead
        {
            get
            {
                return m_Dead;
            }

            set
            {
                m_Dead = value;
            }
        }

        public void Update(GameTime gameTime)
        {
            m_Position += m_Velocity;
            if (gameTime.TotalGameTime.TotalMilliseconds > m_NextShootTime)
            {
                Shoot(gameTime);
            }
        }

        public void Shoot(GameTime gametime)
        {
            m_NextShootTime = gametime.TotalGameTime.TotalMilliseconds + 500;
        }

        public void Die()
        {

        }

        public void ChangeDirection(bool Right)
        {
            m_GoingRight = Right;
            m_Velocity = (Right ? new Vector2(20, 0) : new Vector2(-20, 0));
        }

        public void CheckCollisions(IMissile m)
        {
            throw new NotImplementedException();
        }
    }
}
