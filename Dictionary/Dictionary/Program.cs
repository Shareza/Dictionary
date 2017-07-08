using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary myDic = new Dictionary();
            myDic.ReplaceMarks();
            myDic.SeparateWords(myDic.ReplaceMarks());
            myDic.PrintSeparatedWords();
            myDic.PrintDictionary();
            myDic.SortCollection();

            Console.ReadKey();
        }
    }
}
