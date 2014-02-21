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

        private const int m_maxHP = 100;
        private int m_currHP = 87;
        private int m_currHPUI;
        private int m_HP_UILength = 394;

        private const int m_maxMP = 100;
        private int m_currMP = 33;
        private int m_currMPUI;
        private int m_MP_UILength = 394;

        private Rectangle m_rect_hpUIBackground = new Rectangle(760, 1000, 400, 40);
        private Rectangle m_rect_hpUI;

        private Rectangle m_rect_mpUIBackground = new Rectangle(760, 1040, 400, 40);
        private Rectangle m_rect_mpUI;

        private List<Rectangle> m_list_skillRectList = new List<Rectangle>();


        public Player() {
            Init();
        }

        public void Init() {

            m_position = new Vector2(400, 400);
            m_movement = new Vector2(3, 3);

            m_playerRectangle = new Rectangle((int)m_position.X, (int)m_position.Y, 64, 64);
            m_source_playerRectangle = new Rectangle(0, 0, 128, 128);

            m_currHPUI = m_HP_UILength / m_maxHP * m_currHP;
            m_currMPUI = m_MP_UILength / m_maxMP * m_currMP;

            m_rect_hpUI = new Rectangle(763, 1002, m_currHPUI, 36);
            m_rect_mpUI = new Rectangle(763, 1042, m_currMPUI, 36);


            for (int i = 0; i < 4; i++)
                m_list_skillRectList.Add(new Rectangle(760 + i* 100, 900, 100, 100));

        }

        public void Update(GameTime gt)
        {
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
            DrawUI(sb);
        }

        private void DrawUI(SpriteBatch sb) {

            for (int i = 0; i < m_list_skillRectList.Count; i++)
                sb.Draw(TextureLibrary.m_texture_skillBackground, m_list_skillRectList[i], Color.White);

            sb.Draw(TextureLibrary.m_texture_hpmpBackground, m_rect_hpUIBackground, Color.White);
            sb.Draw(TextureLibrary.m_texture_hpmpBackground, m_rect_mpUIBackground, Color.White);

            sb.Draw(TextureLibrary.m_texture_hp, m_rect_hpUI, Color.White);
            sb.Draw(TextureLibrary.m_texture_mp, m_rect_mpUI, Color.White);
        }
    }
}
