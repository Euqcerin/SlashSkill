using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Survival
{
    class Player
    {
        private Rectangle m_playerRectangle;
        private Rectangle m_source_playerRectangle;

        private Vector2 m_movement;
        private Vector2 m_position;

        public Player() {
            Init();
        }

        public void Init() {
            m_playerRectangle = new Rectangle(600, 500, 64, 64);
            m_source_playerRectangle = new Rectangle(0, 0, 128, 128);
        }

        public void Update(GameTime gt) { 
            
        }

        public void Draw(SpriteBatch sb) {
            sb.Draw(TextureLibrary.m_texture_playerTexture, m_playerRectangle, m_source_playerRectangle, Color.White);
        }
    }
}
