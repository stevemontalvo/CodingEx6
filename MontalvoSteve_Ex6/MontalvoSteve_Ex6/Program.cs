using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            deck1.Shuffle();
            for (int i=0; i < 52; i++)
            {
                deck1.DealCard();

            }
        }
    }
}
