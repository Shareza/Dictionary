using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dictionary
{
    class Dictionary
    {
        static string path = @"../../MyDictionary.txt";
        private string text = string.Empty;
        Dictionary<string, int> Collection = new Dictionary<string, int>();


        public Dictionary()
        {
            
            StreamReader textReader = new StreamReader(path);
            this.text = textReader.ReadToEnd();

            
            textReader.Close();
        }

        public void Print()
        {
            foreach (var word in text )
            {
               Console.Write(word);
            }
        }

        public string[] SeparateWords(string text)
        {

            string[] words = text.Split(' ');
            return words;
        }

        public void PrintSeparatedWords()
        {
            foreach (var word in SeparateWords(ReplaceMarks()))
            {
                Console.WriteLine(word);

                if (Collection.ContainsKey(word))
                {
                    Collection[word]++;
                }
                else
                {
                    Collection.Add(word,1);
                }
            }
        }

        public string ReplaceMarks()
        {
            string textA = text.Replace(".", " ");
            string textB = textA.Replace(",", " ");
            string textC = textB.Replace(";", " ");
            string textD = textC.Replace("”", " ");
            string finalText = textD.Replace(":", " ");
            return finalText.Trim();
        }

        public void PrintDictionary()
        {

            foreach (var pair in Collection)
            {
                if (pair.Value == 1)

                {
                    Console.WriteLine($"[{pair.Key, 20}]\t [{pair.Value}] time.");
                }
                else Console.WriteLine($"[{pair.Key, 20}]\t [{pair.Value}] times.");
            }
        }

        public void SortCollection()
        {
            
            foreach (KeyValuePair<string, int> pair  in Collection.OrderByDescending(key => key.Value))
            {
                Console.WriteLine($"{pair.Key}, {pair.Value}");
            }

        }






    }
}
