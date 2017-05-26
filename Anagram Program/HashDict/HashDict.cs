using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Resources;

namespace Anagram_Program.HashDict
{

    public class HashDict
    {
        public Hashtable dictionary = new Hashtable(); 
        char[] delimiter = new char[] { '\n'};
       
        public HashDict()
        {
            ResourceManager rm = Properties.Resources.ResourceManager;
            

           string dict = Properties.Resources.dictionary;


            string[] lines = dict.Split(delimiter);


            foreach (var i in lines)
            {
                
                 this.dictionary.Add(i, i);
               
            }


        }


        public Hashtable getDict()
        {

            if (dictionary != null)
                return dictionary;

            else
            {
                Console.WriteLine("no dictionary");
                
                return null;

            }
        }



    }
}
