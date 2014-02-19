using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Survival
{
    class Menu
    {
        Rectangle m_rectangle_playGameButton;

        MouseState m_mouseState;

        public Menu() 
        {
            Init();
        }

        private void Init() {
            m_rectangle_playGameButton = new Rectangle(1200, 500, 400, 100);
        }

        public void Update(GameTime gt) { 
            
        }

        public void Draw(SpriteBatch sb) {
            sb.Draw(TextureLibrary.m_texture_menuScreen, new Rectangle(0, 0, 1920, 1080), Color.White);
            sb.Draw(TextureLibrary.m_texture_playButton, m_rectangle_playGameButton, Color.White);
        }
    }
}
