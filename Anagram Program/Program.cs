using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_Program
{
    class Program
    {
       
        static void Main(string[] args)
        {
       
            
            string str = "sagiv";

            Console.WriteLine("The anagram, tell me about it (type as one word)");

            str = Console.ReadLine();
            char[] arr = str.ToCharArray();

           Permutations.GetPer(arr);

          

            Console.ReadKey();
        }
    }
}
