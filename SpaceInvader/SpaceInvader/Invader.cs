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
        private bool m_GoingRight; // True if going right, false if going left
        private bool m_BottomMost; // True if it's the bottom-most entity in its column
        private Vector2 m_Velocity;
        private double m_NextShootTime;
        private Rectangle m_Hitbox;

        private int m_ArrayPosX;
        private int m_ArrayPosY;
        private bool m_Dead;
        private EntityManager m_Manager;


        public Invader(int x, int y, EntityManager em)
        {
            m_ArrayPosX = x;
            m_ArrayPosY = y;
            m_BottomMost = y == 4;
            this.ChangeDirection(true);
            m_Manager = em;
            m_Hitbox = new Rectangle(x * 15 + x * 50 + 15, y * 40 + y * 25 + 40, 50, 25);
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

        public Rectangle Hitbox
        {
            get
            {
                return m_Hitbox;
            }

            set
            {
                m_Hitbox = value;
            }
        }

        public void Update(GameTime gameTime)
        {
            m_Hitbox.Location += m_Velocity.ToPoint();
            if (m_BottomMost && gameTime.TotalGameTime.TotalMilliseconds > m_NextShootTime)
            {
                Shoot(gameTime);
            }

            if (m_Hitbox.Right > 998 || m_Hitbox.Left < 2)
            {
                
            }

        }

        public void Shoot(GameTime gametime)
        {
            m_NextShootTime = gametime.TotalGameTime.TotalMilliseconds + 500;
            // TODO - ADD MISSILE CREATION HERE
        }

        public void Die()
        {
            m_Dead = true;

            // TODO, TELL INVADER ABOVE THAT HE'S BOTTOM MOST
        }

        public void ChangeDirection(bool Right)
        {
            m_GoingRight = Right;
            m_Velocity = (Right ? new Vector2(20, 0) : new Vector2(-20, 0));
        }

        public void CheckCollisions(IMissile m)
        {
            if (m.GoingUp)
            {
                if (this.Hitbox.Intersects(m.Hitbox))
                {
                    this.Die();
                }
            }
        }
    }
}
