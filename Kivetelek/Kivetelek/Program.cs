using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                try
                {
                    int c = a / b;
                    Console.WriteLine(c);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Nullával való osztás");                    
                }

                Console.WriteLine("A program folytatódik");

                throw new ArgumentException();

            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Ez bizony null!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                
            }
            finally
            {
                Console.WriteLine("Ami itt van mindig lefut");
            }

            Console.ReadKey();
        }
    }
}
