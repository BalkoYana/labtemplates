using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkrt
{
    public class Card
    {
        public string Value { get; set; }
        public string Suit { get; set; }
        public Card(string value, string suit) {
        Value= value;
        Suit= suit;
        }
        public override string ToString()
        {
            return $"{ Value} - {Suit}";
        }
    }
}
