using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Survival
{

    public class Camera
    {
        public static Matrix transform;
        private Viewport view;
        private Vector2 centre;

        private const int m_halfWindowWidth = 960;
        private const int m_halfWindowHeight = 540;


        public Camera(Viewport newView)
        {
            view = newView;
        }

        public void Update()
            {
                centre = new Vector2(Player.m_player_center_X - m_halfWindowWidth, Player.m_player_center_Y - m_halfWindowHeight);
                transform = Matrix.CreateScale(new Vector3(1, 1, 0)) * Matrix.CreateTranslation(new Vector3(-centre.X, -centre.Y, 0));
            }
    }
}
