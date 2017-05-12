using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvader
{
    public interface IMoveable
    {
        Vector2 Velocity { get; set; }
        Vector2 Position { get; set; }
        void Update();
    }
}
