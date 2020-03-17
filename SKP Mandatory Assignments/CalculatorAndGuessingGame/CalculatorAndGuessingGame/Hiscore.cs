using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAndGuessingGame
{
    public class Hiscore
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Hiscore(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }

    
}
