using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Survival
{
    class Play
    {

        Player m_player;

        public Play() {
            Init();
        }

        public void Init() {
            m_player = new Player();
        }

        public void Update(GameTime gt) {
            m_player.Update(gt);   
        }

        public void Draw(SpriteBatch sb) {
            sb.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, Camera.transform);
            sb.Draw(TextureLibrary.m_texture_background, new Rectangle(0, 0, 1920, 1080), Color.White);
            sb.End();
            m_player.Draw(sb);
        }
    }
}
