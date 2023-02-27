using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Comparsion
{
    class Test
    {
        private static string[] Text1(string path)
        {
            string textFromFile = File.ReadAllText(path);
            return textFromFile.Split(new char[] {' ', '\r', '\n'}, StringSplitOptions.None);
        }
        
        public static void ComparsionRun(string path)
        {   
            Console.WriteLine("=========================");

            LinkedListTest(path);

            Console.WriteLine("=========================");

            ListTest(path);

            Console.WriteLine("=========================");
        }

        private static void LinkedListTest(string path1)
        {
            var watchOne = Stopwatch.StartNew();

            LinkedList<string> linkedListForTest = new LinkedList<string>(Text1(path1));

            Console.WriteLine("LinkedList 'Add' operation: {0} мс", watchOne.Elapsed.TotalMicroseconds);

            watchOne = Stopwatch.StartNew();

            var part = linkedListForTest.Find("Часть");

            linkedListForTest.AddAfter(part, "Test");

            Console.WriteLine("LinkedList 'Inset' operation: {0} мс", watchOne.Elapsed.TotalMicroseconds);
        }

        private static void ListTest(string path1)
        {
            var watchTwo = Stopwatch.StartNew();

            List<string> listForTest = new List<string>(Text1(path1));

            Console.WriteLine("List 'Add' operation: {0} мс", watchTwo.Elapsed.TotalMicroseconds);

            watchTwo = Stopwatch.StartNew();

            listForTest.Insert(listForTest.IndexOf("Часть"), "Test");
            
            Console.WriteLine("List 'Insert' operation: {0} мс", watchTwo.Elapsed.TotalMicroseconds);
        }
    }
}