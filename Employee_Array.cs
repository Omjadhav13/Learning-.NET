using System.Reflection.Metadata.Ecma335;

namespace ArrayT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the Number of employees");
            int size=int.Parse(Console.ReadLine()!);
            Employee[] arr = new Employee[size];
            for (int i=0; i < arr.Length; i++){
                arr[i] =new Employee();
            }
            foreach(Employee emp in arr)
            {
                Console.WriteLine("Enter Emp No");
                emp.EmpNo =int.Parse( Console.ReadLine()!);

                Console.WriteLine("Enter Emp name");
                emp.Name = Console.ReadLine()!;

                Console.WriteLine("Enter Emp Dept No");
                emp.DeptNo=short.Parse( Console.ReadLine()! );

                Console.WriteLine("Enter Emp Salary");
                emp.Salary = decimal.Parse(Console.ReadLine()!);

            }
            decimal max = 0;
            foreach (Employee emp in arr)
            {
                
                if (emp.Salary > max)
                {
                    max = emp.Salary;
                }
            }
            Console.WriteLine($"Highest Salary is : {max}");


           /* Console.WriteLine("Enter the Employee Number");
            int x = int.Parse(Console.ReadLine()!);
            int index = arr.BinarySearch(arr, x);
            foreach (Employee emp in arr)
            {

                if (index == emp.DeptNo)
                {
                    Console.WriteLine($"Name: {emp.Name} , Employee Number : {emp.EmpNo} , Emplyee Dept : {emp.DeptNo} , employee salary : {emp.Salary}");
                }
            }*/

            /**//*Console.WriteLine(arr.Binary)*/
        }

    }
    public class Employee
    {
        private string? name;
        private int empNo;
        private decimal salary;
        private short deptNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != null || value != "") {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid name");
                }
            }
        }
        public int EmpNo
        {
            get { return empNo; }
            set
            {
                if (value != 0)
                {
                    empNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid EmpNo");
                }
            }
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if(value > 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Invalid salary");
                }
            }
        }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value != 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Invliad DepNo");
                }
            }
        }
    }
}
