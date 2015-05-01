using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bucket = new string[5];

            for(int i = 0; i <bucket.Length; i++)
            {
                bucket[i] = Console.ReadLine();
            }
            Console.WriteLine("=========");

            foreach (string item in bucket)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
