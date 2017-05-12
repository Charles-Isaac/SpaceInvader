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

        public void Update()
        {

        }

        public void Shoot()
        {

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
