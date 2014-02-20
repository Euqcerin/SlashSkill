using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Survival
{
    class Player
    {
        private Rectangle m_playerRectangle;
        private Rectangle m_source_playerRectangle;

        private Vector2 m_movement;
        private Vector2 m_position;

        private KeyboardState m_kState_curr;
        private KeyboardState m_kState_prev;


        public Player() {
            Init();
        }

        public void Init() {

            m_position = new Vector2(400, 400);
            m_movement = new Vector2(3, 3);

            m_playerRectangle = new Rectangle((int)m_position.X, (int)m_position.Y, 64, 64);
            m_source_playerRectangle = new Rectangle(0, 0, 128, 128);
        }

        public void Update(GameTime gt) {
            m_kState_curr = Keyboard.GetState();

            UpdateMovement();

            m_kState_prev = m_kState_curr;
        }

        public void UpdateMovement() {
            if (m_kState_curr.IsKeyDown(Keys.W))
                m_position.Y -= m_movement.Y;
            if (m_kState_curr.IsKeyDown(Keys.S))
                m_position.Y += m_movement.Y;
            if (m_kState_curr.IsKeyDown(Keys.A))
                m_position.X -= m_movement.X;
            if (m_kState_curr.IsKeyDown(Keys.D))
                m_position.X += m_movement.X;

            m_playerRectangle = new Rectangle((int)m_position.X, (int)m_position.Y, 64, 64);
        }

        public void Draw(SpriteBatch sb) {
            sb.Draw(TextureLibrary.m_texture_playerTexture, m_playerRectangle, m_source_playerRectangle, Color.White);
        }
    }
}
