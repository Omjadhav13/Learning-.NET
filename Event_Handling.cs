using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handling
{
    public class exc
    {
        public delegate void Delegates(string msg);
        public event Delegates myevent;
        public void display()
        {
            Console.WriteLine("Triggered");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            exc e=new exc();
            e.myevent += new exc.Delegates(msg);
            e.display();
        }
        static void msg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
