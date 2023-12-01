using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduel14
{
     public enum CardValue//создаем перечисления велечины карты
    {
        SIX , SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
    }

    public enum CardSuit//создаем перечесление Масти карты 
    {
        HEARTS , DIAMONDS, CLUBS, SPADES
    }
    public class Card
    {

        public  CardValue value;
        public  CardSuit suit;

        public Card(CardValue value, CardSuit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"{value} {suit}";
        }
    }
}
