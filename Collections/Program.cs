using System;
using System.Text.RegularExpressions;
using System.Collections;
using ClassLibrary;

namespace Collections
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите текст для подсчета частоты слов.");
                var functions = new ClassLibrary.WordsInText();
                var dictionary = functions.GetWordsDictionary(IsEnglish(Console.ReadLine()));
                Console.WriteLine("Слова встречаются в тексте следующее количество раз:");
                foreach (var record in dictionary)
                {
                    if (record.Value > 1 && !string.IsNullOrEmpty(record.Key))
                    {
                        Console.WriteLine(record.Key + " - " + record.Value);
                    }
                }
                Console.WriteLine("Остальные слова встречаются в тексте 1 раз.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Метод проверяет ввод латинских символов.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string IsEnglish(string text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    if (!(text.ToLower()[i] >= 'a' && text.ToLower()[i] <= 'z'))
                    {
                        throw new Exception("Текст должен содержать только латинские символы.");
                    }
                }
            }
            return text;
        }
    }
}
