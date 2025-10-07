

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manager m = new Manager("CEO", "om", 112, 12000);
            Manager m = new Manager("CEO" );
            Console.WriteLine($"Desgination : {m.Desgination}, Name : {m.Name} , DeptNo: {m.DeptNO} , Basic : {m.Basic} , Net Salary : {m.GetNetSalary()}");
            
            m.Insert();

            GeneralManager GM = new GeneralManager("Leaves", "General manager", "om", 112, 12000);
            Console.WriteLine($"Desgination : {GM.Desgination}, Name : {GM.Name} , DeptNo: {GM.DeptNO} , Basic : {GM.Basic} , Net Salary : {GM.GetNetSalary()}");

            //CEO c = new CEO( "Sumiot", 162, 31200);
            //Console.WriteLine($"Name : {c.Name} , DeptNo: {c.DeptNO} , Basic : {c.Basic} , Net Salary : {c.GetNetSalary()}");



        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();  
    }
    public abstract class Employee : IDbFunctions
    {
        private string name;
        private int empNo;
        public abstract decimal Basic { get; set; }
        private short deptNo;
        private static int autogen = 1;
        public void Insert()
        {
            Console.WriteLine("Employee Insert");
        }
        public void Update()
        {
            Console.WriteLine("Employee updated");
        }
        public void Delete()
        {
            Console.WriteLine("Employee delete");
        }
        public Employee(string name, short deptNo, decimal Basic)
        {
            EmpNo = autogen;
            this.name = name;
            this.deptNo = deptNo;
            this.Basic = Basic;
            autogen++;
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
        public int EmpNo { get; private set; }
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
        public abstract decimal GetNetSalary();
    }
    public class Manager : Employee, IDbFunctions
    {
        public string? Desgination;
        public decimal basic;
        public Manager(string Designation = "default", string name = "deafault", short DeptNo = 1, decimal Basic = 1) : base(name, DeptNo, Basic)
        {
            this.desgination = Designation;
        }
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value > 0)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Value should be greater than 0");
                }
            }
        }
        public string desgination
        {
            set
            {
                if (value != "" || value != null)
                {
                    Desgination = value;
                }
                else
                {
                    Console.WriteLine("Desgination should not be blank");

                }
            }
            get { return Desgination; }
        }
        public override decimal GetNetSalary()
        {
            return Basic * 0.2M;
        }
        public new void Insert()
        {
            Console.WriteLine("MANAGER Insert");
        }
        public new void Update()
        {
            Console.WriteLine("MANAGER updated");
        }
        public new void Delete()
        {
            Console.WriteLine("MANAGER delete");
        }
    }
    
    public class GeneralManager :Manager, IDbFunctions
    {
        public new decimal basic;
        public string Perks;
        public GeneralManager(string Perks,string Designation, string name, short DeptNo, decimal Basic) : base(Designation, name, DeptNo, Basic)
        {
            this.Perks = Perks;
        }
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value <300000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Value should be Less than 300000");
                }
            }
        }
        public override decimal GetNetSalary()
        {
            return Basic * 2;
        }
        public new void Insert()
        {
            Console.WriteLine("GM Insert");
        }
        public new void Update()
        {
            Console.WriteLine("GM updated");
        }
        public new void Delete()
        {
            Console.WriteLine("GM delete");
        }
    }

    public class CEO : Employee, IDbFunctions
    {
        public decimal basic;

        public CEO( string name, short DeptNo, decimal Basic) : base(name, DeptNo, Basic)
        {

        }
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value > 0 && value <300000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Value should be greater than 0");
                }
            }
        }

        public new void Insert()
        {
            Console.WriteLine("CEO Insert");
        }
        public new void Update()
        {
            Console.WriteLine("CEO updated");
        }
        public  new void Delete()
        {
            Console.WriteLine("CEO delete");
        }

        public override sealed decimal GetNetSalary()
        {
            return Basic * 5;
        }


    }
}
