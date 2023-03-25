using System;
using System.Collections.Generic;

namespace Creation_Delegates
{
    class Program
    {
        delegate int StringLength(string s);

        static void Main()
        {
            List<string> words = new List<string> { "Об'єктно", "орiєнтоване", "програмування"};
                        
            StringLength length = s => s.Length;
                        
            foreach (string word in words)
            {
                int len = length(word);
                Console.WriteLine($"Довжина слова \"{word}\": {len} символiв");
            }
            Console.ReadLine();
        }
    }
}
