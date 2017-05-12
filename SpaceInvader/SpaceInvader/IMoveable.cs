using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvader
{
    public interface IMoveable
    {
        Rectangle Hitbox { get; set; }
        Vector2 Velocity { get; set; }
        void Update(GameTime gameTime);
    }
}
