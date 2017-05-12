using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvader
{
    public interface IMoveable
    {
        Vector2 Position { get; set; }
        Vector2 Velocity { get; set; }
        void Update(GameTime gameTime);
        Vector2 Size { get; set; }
    }
}
