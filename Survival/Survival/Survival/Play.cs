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

        public enum MapSize
        {
            Small,
            Medium,
            Large,
            Huge
        }

        MapSize m_mapSize = MapSize.Small;

        public List<Tile> tileList = new List<Tile>();
        int m_mapTiles;


        Player m_player;
        MonsterManager m_monsterManager;
        MapGenerator m_mapGenerator;

        public Play() {
            Init();
        }

        public void Init() {
            m_player = new Player();
            m_monsterManager = new MonsterManager();
            GenerateMap();
            
            //m_mapGenerator = new MapGenerator();
        }

        public void Update(GameTime gt) {
            m_player.Update(gt);
            m_monsterManager.Update(gt);
        }

        public void Draw(SpriteBatch sb) {
            sb.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, Camera.transform);
            Texture2D text = TextureLibrary.m_texture_grassTexture;
            Texture2D text1 = TextureLibrary.m_texture_waterTexture;
            Texture2D text2 = TextureLibrary.m_texture_stoneTexture;
            for (int i = 0; i < tileList.Count; i++)
            {
                if(tileList[i].m_tileType == Tile.TileType.Grass)
                    tileList[i].Draw(sb, text);
                if(tileList[i].m_tileType == Tile.TileType.Water)
                    tileList[i].Draw(sb, text1);
                if(tileList[i].m_tileType == Tile.TileType.Stone)
                    tileList[i].Draw(sb, text2);
            }
            m_monsterManager.Draw(sb);
            sb.End();
            m_player.Draw(sb);
        }

        private void GenerateMap()
        {
            Random rand = new Random();
            Tile currTile;
            int temp;

            switch (m_mapSize)
            {
                case MapSize.Small:
                    m_mapTiles = 64;
                    break;
                case MapSize.Medium:
                    m_mapTiles = 128;
                    break;
                case MapSize.Large:
                    m_mapTiles = 256;
                    break;
                case MapSize.Huge:
                    m_mapTiles = 512;
                    break;
            }

            for (int i = 0; i < m_mapTiles; i++)
            {
                for (int j = 0; j < m_mapTiles; j++)
                {

                    currTile = new Tile();
                    temp = rand.Next(0, 100);

                    if (temp < 90)
                    {
                        currTile.m_tileType = Tile.TileType.Grass;
                        currTile.m_texture = TextureLibrary.m_texture_hp;
                    }
                    else if (temp >= 90 && temp < 95)
                    {
                        currTile.m_tileType = Tile.TileType.Water;
                        currTile.m_texture = TextureLibrary.m_texture_mp;
                    }
                    else if (temp >= 95)
                    {
                        currTile.m_tileType = Tile.TileType.Stone;
                        currTile.m_texture = TextureLibrary.m_texture_startScreen;
                    }

                    currTile.tile_position = new Vector2(i * 64, j * 64);

                    tileList.Add(currTile);

                }
            }
        }
    }
}
