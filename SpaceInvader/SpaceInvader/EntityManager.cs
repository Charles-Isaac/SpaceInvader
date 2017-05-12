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
    public class EntityManager
    {
        private Invader[,] m_Invaders; // x, 0 is top; x, 4 is bottom
        private byte m_ShouldChange; // 000000[direction][should change] (0x03 = should change all to right), (0x01 = should change all to left)

        public Invader[,] Invaders
        {
            get { return m_Invaders; }
        }

        public void Init()
        {
            m_Invaders = new Invader[12, 5];
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 12; x++)
                {

                    m_Invaders[x, y] = new Invader();
                }
            }
        }

        public bool Remove(Invader i)
        {
            return m_Invaders.Remove(i);
        }

        public void Update()
        {
            foreach (Invader i in m_Invaders)
            {

                i.Update();
            }
            if (m_ShouldChange != 0)
            {
                bool GoingRight = (m_ShouldChange & 0x2) == 0x2;
                foreach (Invader i in m_Invaders)
                {
                    i.GoingRight = GoingRight;
                }
            }
        }

        public void ChangeDirection(bool DirRight)
        {
            m_ShouldChange = (byte)(1 | (DirRight ? 2 : 0));
        }
    }
}
