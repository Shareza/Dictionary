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
        

        public Dictionary()
        {
            Dictionary<string, int> Collection = new Dictionary<string, int>();
            StreamReader textReader = new StreamReader(path);
            this.text = textReader.ReadToEnd();

            
            textReader.Close();
        }

        public void Fill()
        {
            
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






    }
}
