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
        MonsterManager m_monsterManager;

        public Play() {
            Init();
        }

        public void Init() {
            m_player = new Player();
            m_monsterManager = new MonsterManager();
        }

        public void Update(GameTime gt) {
            m_player.Update(gt);
            m_monsterManager.Update(gt);
        }

        public void Draw(SpriteBatch sb) {
            sb.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, Camera.transform);
            sb.Draw(TextureLibrary.m_texture_background, new Rectangle(-2000, -1000, 4000, 2000), Color.White);
            m_monsterManager.Draw(sb);
            sb.End();
            m_player.Draw(sb);
        }
    }
}
