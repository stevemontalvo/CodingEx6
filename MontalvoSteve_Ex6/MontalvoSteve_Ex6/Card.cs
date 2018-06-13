using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Ex6
{
    class Card
    {
        string face;
        string suit;

        public Card(string CardFace, string CardSuit)
        {
            face = CardFace;
            suit = CardSuit;
        }
        
        public override string ToString()
        {
            return face +"of"+ suit;
        }
    }
}
