using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Stephen_Livingston
{   
    class Card
    {
       public string Number { get; } // public string property with getter called Number
     
       public string Suit { get; } // public string property with getter called Suit

        public Card(string numParam, string suitParam) // Constructor that assigns Number and Suit to their respective parameters.
        {
            Number = numParam;
            Suit = suitParam;
        }
    }
    
}
