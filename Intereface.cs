namespace Day3Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //access all the methods 
            Class1 obj=new Class1();
            obj.Display();
            obj.Function1();
            obj.Function2();
            obj.Function3();
            Console.WriteLine("");
            //access on interface methods
            Ione Iobj;
            Iobj = obj;
            Iobj.Function1();//methods 1 
            //method 2 
            ((Ione)obj).Function2();//-> accessiong by implicit reference
            //method 3
            (obj as Ione).Function3();//-> accessing by implicit reference

            // we cannot access directly Display() of class1
            //I obj.Display();
        }
    }
    public interface Ione
    {
        void Function1();
        void Function2();
        void Function3();
    }

    public class Class1 : Ione
    {
        public void Function1()
        {
            Console.WriteLine("Its Ione Function1");
        }
        public void Function2()
        {
            Console.WriteLine("Its Ione Function2");
        }
        public void Function3()
        {
            Console.WriteLine("Its Ione Function3");
        }
        public void Display()
        {
            Console.WriteLine("Its a Class1 -> Display() ");
        }
    }
}
