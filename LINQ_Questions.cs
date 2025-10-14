using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
namespace LinqAssignment
{
    public class Program
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public int Marks { get; set; }
            public string City { get; set; }
        }
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student{ Id=1, Name="Amit", Age=20, Gender="Male", Marks=85, City="Mumbai"},
                new Student{ Id=2, Name="Priya", Age=22, Gender="Female", Marks=92, City="Pune"},
                new Student{ Id=3, Name="Rohan", Age=19, Gender="Male", Marks=76, City="Delhi"},
                new Student{ Id=4, Name="Sneha", Age=21, Gender="Female", Marks=81, City="Mumbai " },
                new Student{ Id=5, Name="Vikram", Age=23, Gender="Male", Marks=89, City="Chennai " },
                new Student{ Id=6, Name="Neha", Age=20, Gender="Female", Marks=95, City="Pune"},
                new Student{ Id=7, Name="Karan", Age=22, Gender="Male", Marks=72, City="Kolkata" } ,
                new Student{ Id=8, Name="Divya", Age=19, Gender="Female", Marks=68, City="Delhi" },
                new Student{ Id=9, Name="Rahul", Age=24, Gender="Male", Marks=90, City="Bangalor" },
                new Student{ Id=10, Name="Pooja", Age=21, Gender="Female", Marks=88, City="Mumbai" }
            };
            // Write your LINQ queries here
            Console.WriteLine(". Display all student names");
            var s = from st in students select st.Name;
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(". Display all students from Mumbai.");
            var sn = from st in students where st.City == "Mumbai" select st;
            foreach (var item in sn)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
            Console.WriteLine(".. Display names and marks of students who scored more than 80.");
            var sm = students.Where(st => st.Marks > 80).Select(st => new { st.Name, st.Marks });
            foreach (var item in sm)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(". Find all female students.");
            var sf = students.Where(st => st.Gender == "Female").Select(st => st.Name);
            foreach (var item in sf)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();
            Console.WriteLine(" Find all male students with marks above 85.");
            var sts = students.Where(st => st.Gender == "Male" && st.Marks > 85).Select(st => st.Name);
            foreach (var item in sts)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();
            Console.WriteLine(" Find the student with Id = 5.");
            var ss = students.Where(st => st.Id == 5).Select(st => st.Name);
            foreach (var item in ss)
            {
                Console.WriteLine($"{item}");
            }


            Console.WriteLine();
            Console.WriteLine("7. Display students sorted by name.");
            var sort = students.Select(st => st.Name).OrderByDescending(name => name);
            foreach (var item in sort)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();
            Console.WriteLine("8. Display students sorted by marks descending");
            //var sortm = students.Select(st => st).OrderByDescending(marks => marks);
            var sortm = from st in students orderby st.Marks descending select st;
            foreach (var item in sortm)
            {
                Console.WriteLine($"{item.Name} {item.Marks}");
            }

            Console.WriteLine();
            Console.WriteLine("9. Display names of students between age 20 and 22");
            var nage = students.Where(st => st.Age == 20 || st.Age == 22).Select(st => new { st.Name, st.Age });
            foreach (var item in nage)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();
            Console.WriteLine("10. Display distinct city names");
            var city = students.Select(st => st.City).Distinct();
            foreach (var item in city)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();
            Console.WriteLine("11. Count total number of students.");
            var total = students.Count();
            Console.WriteLine($"{total}");

            Console.WriteLine();
            Console.WriteLine("12. Count number of male students");
            var male = students.Where(s => s.Gender == "Male").Count();
            Console.WriteLine($"{male}");

            Console.WriteLine();
            Console.WriteLine("13. Find the average marks of all students");
            var avgs = students.Select(s => s.Marks).Average();
            Console.WriteLine($"{avgs}");

            Console.WriteLine();
            Console.WriteLine("14. Find maximum marks scored.");
            var maxx = students.Max(s => s.Marks);
            Console.WriteLine($"{maxx}");

            Console.WriteLine();
            Console.WriteLine("15. Find minimum marks scored");
            var mixx = students.Min(s => s.Marks);
            Console.WriteLine($"{mixx}");

            Console.WriteLine();
            Console.WriteLine("16. Find the top 3 students by marks");
            var top = students.OrderByDescending(s => s.Marks).Take(3);
            foreach (var item in top)
            {
                Console.WriteLine($"{item.Name} {item.Marks} ");
            }

            Console.WriteLine();
            Console.WriteLine("17. Find all students whose name starts with “P”.");
            var p = students.Where(s => s.Name.StartsWith("P"));
            foreach (var item in p)
            {
                Console.WriteLine($"{item.Name} ");
            }

            Console.WriteLine();
            Console.WriteLine("18. Find all students from Pune or Mumbai.");
            var PM = students.Where(s => s.City == "Mumbai" || s.City == "Pune").Select(s => new { s.Name, s.City });
            foreach (var item in PM)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine("19. Display names in uppercase.");
            var nm = students.Select(s => s.Name.ToUpper());
            foreach (var item in nm)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();
            Console.WriteLine("20. Check if any student scored 100.");
            var sc = students.Select(s => s.Marks == 100);
            foreach (var item in sc)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();
            Console.WriteLine("21. Group students by city.");
            var g = from ci in students group ci by ci.City into cityGroup select cityGroup;
            foreach (var group in g)
            {
                Console.Write($"{group.Key}");
                foreach (var ci in group)
                {
                    Console.Write($" {ci.Name}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("22. Count how many students are there in each city");

            var c = from ci in students
                    group ci by ci.City into cityGroup
                    select new { City = cityGroup.Key, Count = cityGroup.Count() };

            foreach (var ci in c)
            {
                Console.WriteLine($"{ci.City} {ci.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("23. Find average marks per city");

            var pc = from ci in students
                    group ci by ci.City into cityGroup
                    select new { cityGroup,avg= cityGroup.Average(c=>c.Marks)};
                   

            foreach (var ci in pc)
            {   
                Console.WriteLine($"{ci.cityGroup.Key} {ci.avg}");
            }

            Console.WriteLine();
            Console.WriteLine("24.Find highest marks per city");
            var maxMark = from si in students
                          group si by si.City into cityGroup
                          select new
                          {
                              city = cityGroup,
                              max = cityGroup.Max(si => si.Marks),

                          };
            foreach (var item in maxMark)
            {
                Console.WriteLine($"{item.city.Key} : {item.max}");
            }
            
            Console.WriteLine();
            Console.WriteLine("25. Find the city with the most students");
            var ms = (from sis in students
                                group sis by sis.City into cityGroup
                                select new
                                {
                                    City = cityGroup.Key,
                                    Count = cityGroup.Count()
                                })
                                .OrderByDescending(x => x.Count)
                                .FirstOrDefault();

            Console.WriteLine($"{ms.City} {ms.Count} ");


            Console.WriteLine();
            Console.WriteLine("26. Display cities having at least 2 students.");
            var atleast = (from s2s in students
                           group s2s by s2s.City into cityGroup
                           where cityGroup.Count() >= 2

                           select new
                           {
                               City = cityGroup.Key,
                               Count = cityGroup.Count()
                           });


            foreach (var item in atleast)
            {
                Console.WriteLine($"{item.City} : {item.Count}");
            }

            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("27. Group students by gender and find average marks for each.");
            var genderlist = (from sis in students
                              group sis by sis.Gender into genderGroup

                              select new
                              {
                                  Gender = genderGroup.Key,
                                  Count = genderGroup.Average(s => s.Marks),
                              });


            foreach (var item in genderlist)
            {
                Console.WriteLine($"{item.Gender} : {item.Count}");
            }
            

            Console.WriteLine();
            Console.WriteLine("28. Group students by age and list names under each age");
            var groupedStudentsAge = from sos in students
                                     group sos by sos.Age into ageGroup
                                     select ageGroup;


            foreach (var item in groupedStudentsAge)
            {
                Console.WriteLine($"Age: {item.Key}");
                foreach (var sss in item)
                {
                    Console.WriteLine($"  {sss.Name}");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("29. Find all students living in cities that start with ‘D’.");
            var D = students.Where(s => s.Name.StartsWith("D"));
            foreach (var item in D)
            {
                Console.WriteLine($"{item.Name} ");
            }



            Console.WriteLine();
            Console.WriteLine("30. Find total marks of all students combined.");
            var stss =  students.Sum(s=>s.Marks);
                       

            Console.WriteLine($"{stss} ");
        }

    }


}
