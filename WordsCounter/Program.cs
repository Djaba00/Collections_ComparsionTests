using System;

namespace WordsCounter
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"/Users/frankcowperwood/Development/FinalTasksSF/HW_Module13/Texts/Text1.txt";
            
            Counter.ShowTopWords(path);
        }
    }
}