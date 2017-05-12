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
    public class Invader : IMoveable
    {
        private Vector2 m_Position;
        private bool m_GoingRight; // True if going right, false if going left
        private bool m_BottomMost; // True if it's the bottom-most entity in its column

        public bool GoingRight
        {
            get
            {
                return m_GoingRight;
            }

            set
            {
                m_GoingRight = value;
            }
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

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Shoot()
        {

        }

        public void Die()
        {

        }

    }
}
