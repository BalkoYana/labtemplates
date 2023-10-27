using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mkrt
{
    public class Deck
    {
        private static Deck _instance=null;
        private List<Card> cards;
        public Deck()
        {
            cards = new List<Card>();
            string[] suits = { "♠ Піка", "♦ Бубна", "♣ Трефа", "♥ Чирва" };
            string[] values= { "Туз", "Король", "Дама", "Валет" };
            foreach (string s in suits)
            {
                foreach(string v in values)
                {
                    cards.Add(new Card(s, v));
                }
            }
        }
        public static Deck DeckGetInstance()
        {
            if(_instance==null)
            {
                _instance = new Deck();
            }
            return _instance;
        }
        public List<Card> GetCards(int number) {
        List<Card> card = new List<Card>();
        List<Card> copyOfCards = new List<Card>(cards);
            Random random= new Random();
            if (number > cards.Count)
            {
                throw new Exception("Кількість карт менша,напишіть інше число");
            }
            for (int i = 0; i < number; i++)
            {
                if (cards.Count > 0)
                {
                    int a = random.Next(1,number);
                    card.Add(copyOfCards[a]);
                    copyOfCards.RemoveAt(a);

                }


             
            }
            return card;
        }
        public void Print()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
