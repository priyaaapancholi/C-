using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//arguments:A B C D
namespace CSDemo
{
    class Program
    {
        static void Main(String[] st)
        {
            Console.WriteLine("hello all....!");
            Console.WriteLine("you have entered following {0} arguments",st.Length);
            for (int i = 0; i < st.Length; i++)
            {
                Console.WriteLine("INDEX:{0}----ITEM:{1}",i,st[i]);
            }

        }
    }
}
