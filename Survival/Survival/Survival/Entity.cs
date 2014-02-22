using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Survival
{
    class Entity
    {
        private Rectangle b_rectangle_entity;
        private Vector2 b_position_entity;
        private Vector2 b_center_entity;
        private Vector2 b_size_entity;
        private int b_max_hp;
        private int b_curr_hp;
        private Texture2D b_texture_entity;

        public Entity(Texture2D texture, Vector2 pos, Vector2 size, int hp_max, int hp_curr) {

            b_texture_entity = texture;

            b_position_entity = pos;
            b_size_entity = size;
            b_max_hp = hp_max;
            b_curr_hp = hp_curr;

            b_center_entity = new Vector2((int)(pos.X + size.X / 2), (int)(pos.Y + size.Y / 2));
            b_rectangle_entity = new Rectangle((int)pos.X, (int)pos.Y, (int)size.X, (int)size.Y);
        }

        public void Update(GameTime gt) { 
        
        }

        public void Draw(SpriteBatch sb) {
            sb.Draw(b_texture_entity, b_rectangle_entity, Color.White);
        }

        public Rectangle base_rectangle{
            get {return b_rectangle_entity ;}
            set { b_rectangle_entity = value; }
        }

        public Vector2 base_position {
            get {return b_position_entity ;}
            set { b_position_entity = value; }
            
        }

        public Vector2 base_center
        {
            get { return b_center_entity; }
            set { value = b_center_entity; }

        }
    }
}
