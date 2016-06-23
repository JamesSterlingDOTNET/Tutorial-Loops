using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            new Loops().TryLooping();

            Console.ReadLine();
        }
    }

    class Loops
    {
        public void TryLooping()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.WriteLine("Iteration X number {0}", x);
                }
                Console.WriteLine("Iteration number: {0}", i);
            }

            int test = 2;

            do
            {
                Console.WriteLine("It's true!");
            }
            while (test == 2);

            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(5);

            List<string> list2 = new List<string>();
            list2.Add("one");
            list2.Add("two");
            list2.Add("three");

            foreach (var number in list)
            {
                Console.WriteLine(number);

                foreach (var something in list2)
                {
                    Console.WriteLine(something);
                }
            }
        }
    }
}
