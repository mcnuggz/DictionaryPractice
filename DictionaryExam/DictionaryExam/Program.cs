using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExam
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperDictionary<int, string> superDictionary = new SuperDictionary<int, string>();
            superDictionary.AddToDictionary(1, "Hello World");
            superDictionary.AddToDictionary(5, "Foo");
            superDictionary.AddToDictionary(2, "Bar");
            superDictionary.AddToDictionary(3, "Dave is cool");

            superDictionary.OutputToFile("../../dictionary.txt");
            //superDictionary.SortByKey();
            //superDictionary.SortByKeyReverse();
            //superDictionary.SortByValue();
            superDictionary.SortByValueReverse();
            //superDictionary.ReadFile("../../dictionary.txt");
            Console.ReadLine();
        }
    }
}
