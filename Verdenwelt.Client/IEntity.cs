using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Verdenwelt.Client
{
    interface IEntity
    {
        Vector2 Position;
        void Load();
        void Udate(VerdenweltGame g, float deltaTime);
        void Draw(SpriteBatch spriteBatch);
    }
}
