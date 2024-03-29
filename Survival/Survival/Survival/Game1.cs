﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Survival
{
    public enum State { 
        Start,
        Menu,
        Play,
        Pause
    }

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        TextureLibrary m_textureLibrary;
        Menu menu;
        Play play;
        Camera camera;
        public static State m_state = State.Start;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            this.IsMouseVisible = true;

            menu = new Menu();
            play = new Play();
            //graphics.IsFullScreen = true;
            graphics.PreferredBackBufferWidth = 1920;
            graphics.PreferredBackBufferHeight = 1080;
            graphics.ApplyChanges();
            camera = new Camera(GraphicsDevice.Viewport);
            base.Initialize();
        }


        protected override void LoadContent()
        {

            m_textureLibrary = new TextureLibrary(Content);
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            // TODO: Add your update logic here

            switch(m_state){
                case State.Start:
                    if (Keyboard.GetState().GetPressedKeys().Length > 0)
                        m_state = State.Menu;
                    break;
                case State.Menu:
                    menu.Update(gameTime);
                    break;
                case State.Play:
                    play.Update(gameTime);
                    camera.Update();
                    break;
            }

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {

            switch (m_state)
            {
                case State.Start: 
                    spriteBatch.Begin();
                    spriteBatch.Draw(TextureLibrary.m_texture_startScreen, new Rectangle(0, 0, 1920, 1080), Color.White);
                    spriteBatch.End();
                    break;
                case State.Menu:
                    spriteBatch.Begin();
                    menu.Draw(spriteBatch);
                    spriteBatch.End();
                    break;
                case State.Play:
                    play.Draw(spriteBatch);
                    break;
            }
            base.Draw(gameTime);
        }
    }
}
