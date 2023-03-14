using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    public class Play
    {
        const int NO_PLAY = 0 , LADDER = 1 , SNAKE = 2;
        //UC1
        int playerposition = 0;

        //UC2
        Random random = new Random();
        public int DieRoll()
        {
            int num = random.Next(1, 7);
            return num;
        }
        public void Game()
        {
            int option = random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    break; 
                case LADDER:
                    this.playerposition += DieRoll();
                    break;
                case SNAKE:
                    this.playerposition -= DieRoll();
                    break; 
            }
        }
    }
}
