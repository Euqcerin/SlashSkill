using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            Random rand = new Random();
            Tile currTile;
            switch (m_mapSize) { 
                case MapSize.Small:
                    m_mapTiles = 40;
                    break;
                case MapSize.Medium:
                    m_mapTiles = 80;

                    break;
                case MapSize.Large:
                    m_mapTiles = 160;

                    break;
                case MapSize.Huge:
                    m_mapTiles = 320;

                    break;
            }
        }

    }
}
