using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Employee!");

            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);


            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);

            Console.WriteLine("Net salary "+ o1.GetNetSalary());
        }

    }

    public class Employee
    {
        private string name;
        private  int empNo;
        private decimal basic;
        private short deptNo;
        private static int autogen=1;

        public Employee( string name = "", decimal basic = 0, short deptNo = 0)
        {
            EmpNo = autogen;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
            autogen ++;

        }
        public string Name
        {
            set
            {
                if (value != null || value != " ")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name should not be blank");
                }
            }
            get { return name; }
        }

        public int EmpNo { get;private set;}

        public decimal Basic
        {
            set
            {
                if (value > 30000 && value < 300000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Basic salary in not valid");
                }
            }
            get { return basic; }
        }

        public short DeptNO
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Department number should be greater thaan zero");
                }
            }
            get { return deptNo; }
        }

        public decimal GetNetSalary()
        {
            return Basic * 2.2M;
        }
    }
}
