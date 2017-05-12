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
        private List<IMissile> m_Missiles;
        private byte m_ShouldChange; // 000000[direction][should change] (0x03 = should change all to right), (0x01 = should change all to left)
        private IPlayer m_player;

        public Invader[,] Invaders
        {
            get { return m_Invaders; }
        }

        public List<IMissile> Missiles
        {
            get { return m_Missiles; }
            set { m_Missiles = value; }
        }

        public void AddMissile(IMissile m)
        {
            m_Missiles.Add(m);
        }
        public void RemoveMissile(IMissile m)
        {
            m_Missiles.Remove(m);
        }

        public void Init(IPlayer p)
        {
            m_player = p;
            m_Invaders = new Invader[12, 5];
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 12; x++)
                {
                    m_Invaders[x, y] = new Invader(x, y);
                }
            }
        }

        public void Update(GameTime gameTime)
        {
            foreach (IMissile m in m_Missiles)
            {
                m.Update(gameTime);
            }

            foreach (Invader i in m_Invaders)
            {
                i.Update(gameTime);
                foreach (IMissile m in m_Missiles)
                {
                    i.CheckCollisions(m);
                }
            }

            if (m_ShouldChange != 0)
            {
                bool GoingRight = (m_ShouldChange & 0x2) == 0x2;
                foreach (Invader i in m_Invaders)
                {
                    i.ChangeDirection(GoingRight);
                }
            }
        }

        public void ChangeDirection(bool DirRight)
        {
            m_ShouldChange = (byte)(1 | (DirRight ? 2 : 0));
        }
    }
}
