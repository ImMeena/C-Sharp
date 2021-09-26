using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputDesign my = new OutputDesign();
            GameLogic game = new GameLogic();
            game.Play();
            Console.ReadKey();
        }
    }
}
