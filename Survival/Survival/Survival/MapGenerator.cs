using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Survival
{
    class MapGenerator
    {

        public enum MapSize { 
            Small,
            Medium,
            Large,
            Huge
        }

        MapSize m_mapSize = MapSize.Small;

        public static List<Tile> tileList = new List<Tile>();
        int m_mapTiles;

        public MapGenerator() {
            Init();
        }

        private void Init() {
            GenerateMap();
        }

        private void GenerateMap() {
            Texture2D text = TextureLibrary.m_texture_startScreen;
            Random rand = new Random();
            Tile currTile;
            int temp;

            switch (m_mapSize) { 
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

            for (int i = 0; i < m_mapTiles; i++) {
                for (int j = 0; j < m_mapTiles; j++) {

                    currTile = new Tile();
                    temp = rand.Next(0, 100);

                    if (temp < 60)
                    {
                        currTile.m_tileType = Tile.TileType.Grass;
                        currTile.m_texture = TextureLibrary.m_texture_hp;
                    }
                    else if (temp >= 60 && temp < 85)
                    {
                        currTile.m_tileType = Tile.TileType.Water;
                        currTile.m_texture = TextureLibrary.m_texture_mp;
                    }
                    else if (temp >= 85)
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
