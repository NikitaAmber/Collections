using System;
using System.Collections.Generic;
namespace ClassLibrary
{

    public class WordsInText
    {
        /// <summary>
        /// Метод делит строку на слова, заносит их в словарь и считает частоту встречаемости в тексте.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public Dictionary<string,int> GetWordsDictionary(string text)
        {
            var wordsDictionary = new Dictionary<string,int>();
            var wordsArray = text.Split(' ', '.');
            foreach (var s in wordsArray)
            {
                if (!wordsDictionary.ContainsKey(s))
                {
                    wordsDictionary.Add(s, 1);
                }
                else
                {
                    wordsDictionary[s]++;
                }
            }
            return wordsDictionary;
        }
    }
}
