using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExam
{
    public class SuperDictionary<TKey, TValue> : IEnumerable
    {
        DateTime currentTime = DateTime.Now;
        Dictionary<TKey, TValue> superDictionary = new Dictionary<TKey, TValue>();

        public void AddToDictionary(TKey key, TValue value)
        {
            superDictionary.Add(key, value);
        }

        public void UpdateValue(TKey key, TValue valueToUpdate)
        {
            try
            {
                if (superDictionary.ContainsKey(key))
                {
                    superDictionary[key] = valueToUpdate;
                    OutputToFile("../../dictionary.txt");   
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Entry does not exist!");
            }
            
        }

        public IEnumerator GetEnumerator()
        {
            foreach (KeyValuePair<TKey, TValue> item in superDictionary)
            {
                yield return item;
            }
        }

        public void SortByKey()
        {
            foreach (KeyValuePair<TKey, TValue> entry in superDictionary.OrderBy(i => i.Key))
            {
                Console.WriteLine(entry);
            }
        }

        public void SortByKeyReverse()
        {
            foreach (KeyValuePair<TKey, TValue> entry in superDictionary.OrderByDescending(i => i.Key))
            {
                Console.WriteLine(entry);
            }
        }

        public void SortByValue()
        {
            foreach (KeyValuePair<TKey, TValue> entry in superDictionary.OrderBy(i => i.Value))
            {
                Console.WriteLine(entry);
            }
        }
        public void SortByValueReverse()
        {
            foreach (KeyValuePair<TKey, TValue> entry in superDictionary.OrderByDescending(i => i.Value))
            {
                Console.WriteLine(entry);
            }
        }
        public void OutputToFile(string path)
        {
            using (StreamWriter writer = File.AppendText(path))
            {
                foreach (KeyValuePair<TKey, TValue> entry in superDictionary)
                {
                    writer.WriteLine($"{currentTime}\r\n{entry.Key}: {entry.Value}");
                }
                Console.WriteLine(Environment.NewLine);
            }
        }
        public void ReadFile(string path)
        {
            string line;
            int counter = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }
            }           
        }

    }
}
