using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_Program
{
    public class Permutations

    {

       




        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPer(char[] list)
        {
            
            HashDict.HashDict dictionaryHash = new HashDict.HashDict();
            Hashtable openWith = new Hashtable();
            openWith = dictionaryHash.dictionary;
            char[] templist;
            int x = list.Length - 1;

            GetPer(list, 0, x, ref openWith);
             
            
            
        }

        public static void GetPer(char[] list, int k, int m, ref Hashtable openWith)
        {

            if (k == m)
            {

                string s = new string(list);

                if (openWith.Contains(s))
                {
                    Console.WriteLine(s);

                }
              
               
                
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m, ref openWith);
                    Swap(ref list[k], ref list[i]);
                }
        }


    }
}
