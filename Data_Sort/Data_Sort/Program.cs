using System;
using System.Collections.Generic;
using System.IO;

namespace Data_Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"D:\students.txt";
            string line;

            using (StreamReader stream = new StreamReader(path, true))
            {
                Dictionary<string, int> students = new Dictionary<string, int>();

                while ((line = stream.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string name = parts[0];
                    int grade = int.Parse(parts[1]);
                    students[name] = grade;
                }

                List<KeyValuePair<string, int>> sorted = new List<KeyValuePair<string, int>>(students);
                sorted.Sort((x, y) => y.Value.CompareTo(x.Value));

                Console.WriteLine("Список студентiв вiдсортованих за оцiнками в порядку спадання: ");
                foreach (KeyValuePair<string, int> pair in sorted)
                {
                    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                }
            }
            Console.ReadLine();
        }
    }
}
