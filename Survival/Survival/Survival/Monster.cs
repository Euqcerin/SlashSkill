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

            DrawUI(sb);
        }

        private void DrawUI(SpriteBatch sb) {
            Rectangle hpRectangle = new Rectangle((int)base_position.X, (int)base_position.Y - 10, base_size, 10);
            sb.Draw(TextureLibrary.m_texture_hp, hpRectangle, Color.White);
        }
    }
}
