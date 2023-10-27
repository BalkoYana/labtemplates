using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkrt
{
    //    Об’єкт Гральна карта містить Масть(♠ Піка, ♦ Бубна, ♣ Трефа,· ♥ Чирва) та
    //значення(Туз, Король, Дама, Валет). Забезпечити генерування списку із
    //вказаної кількості випадкових карт, але щоб карти не повторювались
    //(наприклад, щоб у списку не було 2 Пікових Дам).
    //Вказати шаблон, який доцільно використати для розв'язування задачі.

    // тут я використовую Singleton,так як за умовою нам потрібний лише один екземпляр колоди


    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = Deck.DeckGetInstance();
            deck.Print();
           
            List<Card> cards = deck.GetCards(7);
            Console.WriteLine(cards);
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
           
        }
    }
}
