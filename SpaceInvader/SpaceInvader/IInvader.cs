using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    public interface IInvader : IEntity
    {
        bool Dead { get; set; }
    }
}
