using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Game
    {
        private PlayField[,] playField;
        private Player player;
        private List<Wall> walls;
        private List<Coin> coins;
        private List<Monster> monsters;
        private List<IMovable> movables;

        public Game(PlayField playField, Player player, List<Wall> walls,
            List<Coin> coins, List<Monster> monsters, int wallsCount)
        {
            this.playField = new PlayField[playField.Width, playField.Height];
            this.player = player;
            this.walls = walls;
            this.coins = coins;
            this.monsters = monsters;
            this.movables.AddRange(monsters);
            this.movables.Add(player);

            for (int i = 0; i < wallsCount; i++)
            {
                //this.walls.Add(new Wall());
            }
        }

        public void Step()
        {
            foreach (var person in movables)
            {
                person.Move();
            }

            switch (playField[player.X, player.Y])
            {
                //todo
                default:
                    break;
            }
        }
    }
}
