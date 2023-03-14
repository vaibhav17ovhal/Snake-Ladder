using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    public class Play
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        //UC1
        int playerposition = 0 , count = 0;

        //UC2
        Random random = new Random();
        public int DieRoll()
        {
            int num = random.Next(1, 7);
            Console.WriteLine("Die Value ----->    " + num);
            count++;
            return num;
        }
        public void Game()
        {
            while (this.playerposition < WINNING_POSITION)
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
                        int dieRoll = DieRoll();
                        if (this.playerposition - dieRoll > 0)
                            this.playerposition -= DieRoll();
                        else
                            this.playerposition = 0;
                        break;
                }
                Console.WriteLine("Player position ----->   " + playerposition);
            }
            if (this.playerposition == WINNING_POSITION)
            {
                Console.WriteLine("Player position ----->   " + playerposition);
                Console.WriteLine("Die Count ---->     " + count);
            }
        } 
    }
}
