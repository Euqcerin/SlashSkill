using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Survival
{
    class Tile
    {
        public enum TileType { 
            Grass,
            Stone,
            Water
        }

        private const int m_size = 64;
        private Vector2 m_pos;
        public Texture2D m_texture;
        public TileType m_tileType = TileType.Grass;

        public Tile() { 
        
        }

        public void Draw(SpriteBatch sb, Texture2D text) {
            sb.Draw(text, new Rectangle((int)m_pos.X, (int)m_pos.Y, m_size, m_size), Color.White);
        }

        public Vector2 tile_position {
            get { return m_pos; }
            set { m_pos = value; }
        }
    }
}
