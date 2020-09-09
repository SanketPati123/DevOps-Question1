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
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the 2nd numbeer");
                b = Convert.ToInt32(Console.ReadLine());
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

        static void Main(string[] args)
        {
            Program p = new Program();
            p.getnumbers();
            if(p.a==0)
            {
                Console.WriteLine("zero cannot be entered");
               p. a = Convert.ToInt32(Console.ReadLine());
            }
            if (p.b == 0)
            {
                Console.WriteLine("zero cannot be entered");
                p.b = Convert.ToInt32(Console.ReadLine());
            }
            p.Sum();
            p.product();
            Console.ReadKey();


        }
    }
}
