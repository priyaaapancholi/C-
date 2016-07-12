using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    class TryCatch
    {

        static void Main()
        {
            int n1,n2,n3;
            try

            {
                Console.WriteLine("enter n1 and n2");
                n1 = Convert.ToInt16(Console.ReadLine());
                n2 = Convert.ToInt16(Console.ReadLine());
                if (n2>0)
                {
                    n3 = n1 / n2;
                    Console.WriteLine("your ans is:"+ n3);

                }
                else
                {
                    throw (new DivideByZeroException());
                }
            }


            catch (DivideByZeroException d)
            {
                Console.WriteLine("divide by zero exception");

               

            }

            finally
            {
                Console.WriteLine("this is finally block");
            }
        }
    }



    public class DivideByZeroException : Exception

    {

        public DivideByZeroException()

        { 

        }
    }
  }