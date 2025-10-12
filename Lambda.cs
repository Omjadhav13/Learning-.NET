using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int i = 100;
            Action a =  ()=>
            {
                i++;   
            };
            a();
            Func<int, int> f =  (int an)=>  100 + an;
            
            Console.WriteLine(f(11));
        }
    }
}
