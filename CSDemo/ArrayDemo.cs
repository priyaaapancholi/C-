using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class ArrayDemo
    {
      
        public static void Main()
        {


            //single dimention
            int[] item = new int[5];
            for(int i=1;i<item.Length;i++)
            {
                Console.WriteLine(i);
            }





            //multi dimention 
            int[,] ar = new int[3, 4];
            
            Console.WriteLine(ar[0,0]+" "+ar[0,1]+" "+ar[0,2]+" "+ar[0,3]);
            Console.WriteLine(ar[1, 0] + " " + ar[1, 1] + " " + ar[1, 2] + " " + ar[1, 3]);
            Console.WriteLine(ar[2, 0] + " " + ar[2, 1] + " " + ar[2, 2] + " " + ar[2, 3]);
            





            //multidimention..parameters from console
            string[,] st = new string[2,3];
            Console.WriteLine("enter {0} records", st.Length / 3);
            for(int i=0;i<2;i++)
            {
               for(int j=0;j<3;j++)
               {
                   st[i, j] = Console.ReadLine();
               }
            }


            Console.WriteLine("data as below:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + st[i, j] + " "); 
                }
                Console.WriteLine();
            }



          
         


        }


    }
}
