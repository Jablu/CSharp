using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Lets split the thing into thing parts";
            char[] ch = new char[] { ' ' };
            string[] words = str.Split(ch);
            string[] repeated = new string[words.Length];
            int[] rep = new int[words.Length];

            Dictionary<string, int> wordCount = new Dictionary<string,int>;

            foreach(var word in words)
            {
                if(!wordCount.ContainsKey(word))
                {
                    wordCount.Add(word,1);
                }
                else
                {
                    int counter = wordCount[word];
                    counter++;
                    wordCount[word] = counter;
                }
            
            }
            foreach(var k in wordCount.Keys)
            {
                   Console.WriteLine(words+""+wordCount.Keys+" ");
            }


                }
            }

    }
}
