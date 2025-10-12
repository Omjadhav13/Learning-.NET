using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display();
            int i = 100;
            Action a= delegate()
            {
                i++;
                Console.WriteLine(i);
            };
            a();
            Func<int,int> f = delegate (int an)
            {
                return 100+an;
            };
            Console.WriteLine(f(11));


        }
      
            //public static void Display()
            //{
            //    int i = 100;
            //    Some();
            //    void Some()
            //    {
            //        i++;


            //    }
            //    Console.WriteLine(i);
            //}
        
    }
}
