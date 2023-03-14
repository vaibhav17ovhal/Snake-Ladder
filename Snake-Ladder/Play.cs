using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    public class Play
    {
        //UC1
        int playerposition = 0;

        //UC2
        Random random = new Random();
        public void DieRoll()
        {
            int num = random.Next(1, 7);
            Console.WriteLine(num);
        }
    }
}
