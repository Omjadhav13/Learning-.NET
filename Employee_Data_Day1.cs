using System.ComponentModel;
using System.Net.Http.Headers;

namespace ProjectDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();

            Console.WriteLine("Enter Employee Name: " );
            obj.name= Console.ReadLine();

            Console.WriteLine("Enter Employee Number: ");
            obj.empNO = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Basic salary: ");
            obj.basic = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Department Number: ");
            obj.deptNo = short.Parse(Console.ReadLine());

            Console.WriteLine("Employee Name: " + obj.name);
            Console.WriteLine("Employee Number: " + obj.empNO);
            Console.WriteLine("Employee Basic salary" + obj.basic);
            Console.WriteLine("Employee Depart number: "+obj.deptNo);

            obj.GetNetSalary();
        }
    }
    public class Employee
    {
        private string Name;
        private int EmpNO;
        private decimal Basic;
        private short DeptNo;
        public string name
        {
            set
            {
                if(value !=" ")
                {
                    Name = value;
                }
                else
                {
                    Console.WriteLine("Name should not be blank");
                }
            }
            get
            {
                return Name;
            }
        }
        public int empNO
        {
            set
            {
                if(value > 0)
                {
                    EmpNO = value;
                }
                else
                {
                    Console.WriteLine("EmpNo should not be zero");
                }
            }
            get
            {
                return EmpNO;
            }
        }
        public decimal basic
        {
            set
            {
                if(value >0 && value < 100000)
                {
                    Basic = value;
                }
                else
                {
                    Console.WriteLine("Basic salary should have to be from 0 to 1,00,000");
                }
            }
            get
            {
                return Basic;
            }
        }
        public short deptNo
        {
            set
            {
                if(value > 0)
                {
                    DeptNo=value;
                }
                else
                {
                    Console.WriteLine("DepNo should not be zero");
                }
            }
            get
            {
                return DeptNo;
            }
        }

        public void  GetNetSalary()
        {
            decimal netSal = Basic + (Basic * 0.02m) -(Basic * 0.10m);
            Console.WriteLine("Net Salary : Basic + Allowance - Deductions ");
            Console.WriteLine("Net Salary : "+ netSal);
            
        }
    }
}
