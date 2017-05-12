using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    public interface IEntity : IMoveable
    {
        void CheckCollisions(IMissile m);

        bool Dead { get; set; }
    }
}
