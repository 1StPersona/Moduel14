using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduel14
{
    class Program
    {
        static void Main()
        {
            Game game = new Game(2);
            while (game.playersTurn())
            {

            }


            // Исходный текст
            string text = "Вот дом, Который построил Джек. А это пшеница, " +
                          "Которая в темном чулане хранится В доме, Который " +
                          "построил Джек. А это веселая птица-синица, Которая " +
                          "часто ворует пшеницу, Которая в темном чулане хранится " +
                          "В доме, Который построил Джек.";

            // Получение частоты встречаемости слов
            Dictionary<string, int> wordFrequency = Statistic.CountWordFrequency(text);

            // Вывод статистики по словам
            Statistic.DisplayWordFrequency(wordFrequency);
        }
    }

   

   

   
   
}

