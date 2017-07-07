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
        

        public Dictionary()
        {
            Dictionary<string, int> Collection = new Dictionary<string, int>();
            TextReader textReader = new StreamReader(path);
            textReader.ReadToEnd().Split(',', '.', ';', ':').ToString().ToLower();
        }

        public void Fill()
        {
            
        }






    }
}
