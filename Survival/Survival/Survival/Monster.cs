using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Survival
{
    class Monster : Entity
    {
        public Monster(Vector2 pos, int size, int hp) 
            : base(TextureLibrary.m_texture_playerTexture, pos, size, hp) { 
        
        }

        public override void Update(GameTime gt)
        {
            base.Update(gt);
        }

        public override void Draw(SpriteBatch sb)
        {
            base.Draw(sb);
        }
    }
}
