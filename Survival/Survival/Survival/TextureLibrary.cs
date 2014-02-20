using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Survival
{
    class TextureLibrary
    {
        public static Texture2D m_texture_menuScreen;
        public static Texture2D m_texture_startScreen;

        public static Texture2D m_texture_playButton;
        public static Texture2D m_texture_playButtonHL;

        //Player
        public static Texture2D m_texture_playerTexture;

        public TextureLibrary(ContentManager Content){

            m_texture_menuScreen = Content.Load<Texture2D>(@"Textures/menuScreen");
            m_texture_startScreen = Content.Load<Texture2D>(@"Textures/startupScreen");
            m_texture_playButton = Content.Load<Texture2D>(@"Textures/playGameButton");
            m_texture_playButtonHL = Content.Load<Texture2D>(@"Textures/playGameButtonHL");

            m_texture_playerTexture = Content.Load<Texture2D>(@"Textures/playerTexture");
        }

    }
}
