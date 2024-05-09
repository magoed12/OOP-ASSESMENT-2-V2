using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSESMENT_2
{
    abstract internal class GameClass// instantiates all die for the games
    {
        public Die die1 = new Die();
        public Die die2 = new Die();
        public Die die3 = new Die();
        public Die die4 = new Die();
        public Die die5 = new Die();
    }
}
