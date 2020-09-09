using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps_Question
{
  
    class Program
    {
        public double sum(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        public double product(double c, double d)
        {
            double product = c * d;
            return product;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Enter the two numbers");

            double a1=0, b1=0;
            double s1=0, p1=0;

            try
            {
                while (a1 == 0)
                {
                    a1 = Convert.ToDouble(Console.ReadLine());
                }

                while (b1 == 0)
                {
                    b1 = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            s1 = p.sum(a1, b1);
            p1 = p.product(a1, b1);

            Console.WriteLine("Sum - {0}    Product - {1}",s1,p1);
            Console.ReadKey();
        }
    }
}
