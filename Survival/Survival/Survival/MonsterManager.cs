using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Survival
{
    class MonsterManager
    {
        List<Entity> m_monster_list = new List<Entity>();

        public MonsterManager() {
            Init();
        }

        private void Init() {
            
            Random rand = new Random();
            int size, hp, posX, posY, nr;

            nr = rand.Next(20, 60);
            for (int i = 0; i < nr; i++)
            {
                size = rand.Next(32, 128);
                posX = rand.Next(-2000, 2000);
                posY = rand.Next(-1000, 1000);

                m_monster_list.Add(new Monster(new Vector2(posX, posY), size, size));

            }

        }

        public void Draw(SpriteBatch sb) {
            foreach (Entity e in m_monster_list) {
                e.Draw(sb);
            }
        }

        public void Update(GameTime gt) {
            foreach (Entity e in m_monster_list) {
                e.Update(gt);
            }
        }
    }
}
