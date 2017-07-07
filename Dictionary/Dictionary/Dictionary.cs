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
            string textA = text.Replace(@".", @" ");
            string textB = textA.Replace(",", " ");
            string textC = textB.Replace(";", " ");
            string finalText = textC.Replace(":", " ");
            return finalText.Trim();
        }

        public void PrintDictionary()
        {

            foreach (var pair in Collection)
            {
                if (pair.Value == 1)
                {
                    Console.WriteLine($"Word \t[{pair.Key, 20}]\t\t was used\t [{pair.Value}]\t time.");
                }
                else Console.WriteLine($"Word \t[{pair.Key, 20}]\t\t was used\t [{pair.Value}]\t times.");
            }
        }

        public void SortCollection()
        {
            
        }






    }
}
