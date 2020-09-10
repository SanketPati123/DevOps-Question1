using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        public int a;
        public int b;
        public void getnumbers()
        {
            try
            {
                Console.WriteLine("enter 1st number");             
                while (!Int32.TryParse(Console.ReadLine(), out a) || (a == 0))
                {
                    Console.WriteLine(" enter an integer");
                }
                Console.WriteLine("enter the 2nd numbeer");
                while (!Int32.TryParse(Console.ReadLine(), out b) || (b == 0))
                {
                    Console.WriteLine("enter an integer");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
        public void Sum()
        {
            Console.WriteLine("Sum= {0}", (a + b));

        }
        public void product()
        {
            Console.WriteLine("Product={0}", (a * b));
        }
        public void division()
        {
            try
            { 
                double d = a / b;
                Console.WriteLine("division={0}",d);
            }
            catch(DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }

            
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.getnumbers();
           
            p.Sum();
            p.product();
            p.division();
            Console.ReadKey();


        }
    }
}
