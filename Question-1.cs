using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Question
    {
        public int sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int product(int c, int d)
        {
            int product = c * d;
            return product;
        }
        public int diff(int c, int d)
        {
            int diff = c - d;
            return diff;
        }
        static void Main(string[] args)
        {
            Question p = new Question();

            Console.WriteLine("Enter the two numbers");

            int a1 = 0, b1 = 0;
            int s1 = 0, p1 = 0, d1 = 0;

            try
            {
                while (!Int32.TryParse(Console.ReadLine(),out a1)||(a1==0))
                {
                    Console.WriteLine("please enter valid number");
                }

                while (!Int32.TryParse(Console.ReadLine(), out b1) || (b1 == 0))
                {
                    Console.WriteLine("please enter valid number");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            s1 = p.sum(a1, b1);
            p1 = p.product(a1, b1);
            d1 = p.diff(a1, b1);

            Console.WriteLine("Sum - {0} Difference - {1}   Product - {2}", s1,d1,p1);
            Console.ReadKey();
        }
    }
}
