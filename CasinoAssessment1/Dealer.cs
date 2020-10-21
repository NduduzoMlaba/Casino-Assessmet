using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoAssessment1
{
    class Dealer : Player
    {
        public override void Stand()
        {
            CheckIfBust();
            if (Bust)
            {
                Console.WriteLine("The Dealer's hand was {0} so it went bust", total);
                total = 0;
            }
            else
            {
                Console.WriteLine("The Dealer stands at {0}", total);
            }
        }
    }
}
