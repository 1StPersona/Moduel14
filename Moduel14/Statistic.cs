using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduel14
{
    public  class Statistic {
        // Функция для подсчета частоты встречаемости слов в тексте
        public static Dictionary<string, int> CountWordFrequency(string text)
        {
            // Разделение текста на слова
            string[] words = text.Split(new char[] { ' ', ',', '.', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Инициализация словаря для хранения частоты встречаемости слов
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            // Подсчет частоты встречаемости каждого слова
            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }

            return wordFrequency;
        }

        // Функция для вывода статистики по словам в виде таблицы
        public static void DisplayWordFrequency(Dictionary<string, int> wordFrequency)
        {
            // Заголовок таблицы
            Console.WriteLine("Слово\t\tКоличество");
            Console.WriteLine("------------------------");

            // Вывод данных о частоте встречаемости слов
            foreach (var pair in wordFrequency.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
            }
        }
    }
}


