using System;
using System.Collections.Generic;
using System.IO;

namespace Data_Filtering
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            string path = @"D:\students.txt";
            string[] lines = File.ReadAllLines(path);

            List<Student> students = new List<Student>();
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                string name = data[0];
                int score = int.Parse(data[1]);
                students.Add(new Student(name, score));
            }

            List<Student> excellent = students.FindAll(s => s.Score >= 90 && s.Score <= 100);
            List<Student> veryGood = students.FindAll(s => s.Score >= 82 && s.Score <= 89);
            List<Student> good = students.FindAll(s => s.Score >= 75 && s.Score <= 81);
            List<Student> satisfactory = students.FindAll(s => s.Score >= 69 && s.Score <= 74);
            List<Student> pass = students.FindAll(s => s.Score >= 60 && s.Score <= 68);
            List<Student> fail = students.FindAll(s => s.Score < 60);

            if (excellent.Count > 0)
            {
                Console.WriteLine("Студенти з оцiнкою \"вiдмiнно\" (A):");
                foreach (Student s in excellent)
                {
                    Console.WriteLine($"    {s.Name}");

                }
            }
            if (veryGood.Count > 0)
            {
                Console.WriteLine("Студенти з оцiнкою \"дуже добре\" (B):");
                foreach (Student s in veryGood)
                {
                    Console.WriteLine($"    {s.Name}");
                }
            }
            if (good.Count > 0)
            {
                Console.WriteLine("Студенти з оцiнкою \"добре\" (C):");
                foreach (Student s in good)
                {
                    Console.WriteLine($"    {s.Name}");
                }
            }
            if (satisfactory.Count > 0)
            {
                Console.WriteLine("Студенти з оцiнкою \"задовiльно\" (D):");
                foreach (Student s in satisfactory)
                {
                    Console.WriteLine($"    {s.Name}");
                }
            }
            if (pass.Count > 0)
            {
                Console.WriteLine("Студенти з оцiнкою \"достатньо\" (E):");
                foreach (Student s in pass)
                {
                    Console.WriteLine($"    {s.Name}");
                }
            }
            if (fail.Count > 0)
            {
                Console.WriteLine("Студенти з оцiнкою \"незадовiльно\" (F):");
                foreach (Student s in fail)
                {
                    Console.WriteLine($"    {s.Name}");
                }
            }
            
            Console.ReadLine();
        }
    }    
}

