using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    public interface IMissile : IMoveable
    {
        bool GoingUp { get; set; }
    }
}
