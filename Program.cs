using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

/*namespace LINQAggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());
            Console.WriteLine(nums.Average());

            string[] countries = { "India", "UK", "US" };
            string res = countries.Aggregate((a,b) => a +","+ b);

            int res1 = nums.Aggregate((a, b) => a * b);
            Console.WriteLine(res1);

            int res2 = nums.Aggregate(10, (a, b) => a * b);
            Console.WriteLine(res2);
        }
    }
}*/
/*namespace LINQRestriction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            //IEnumerable<int> res = list.Where(x=>x%2 == 0);
            //IEnumerable<int> res = from num in list where num % 2 == 0 select num;
            IEnumerable<int> res = list.Select((num, index) => new { Number = num, Index = index })
                .Where(x => x.Number % 2 == 0).Select(x => x.Index);

            foreach(int x in res)
            {
                Console.WriteLine(x);
            }
        }
    }
}*/
/*namespace LINQProjection
{
    public class Student
    {
       public string Name { get; set; }
       public string Gender { get; set; }
        public List<string> Subjects { get;  set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Name="AAA", Gender="F", Subjects=new List<string> {"c#",".NetCore"}},
                new Student{Name="BBB", Gender="M", Subjects=new List<string> {"Web api","LINQ"}},
                new Student{Name="CCC", Gender="F", Subjects=new List<string> {"Core","API"}},
                new Student{Name="DDD", Gender="M", Subjects=new List<string> {"JAVA","Paython"}},
                new Student{Name="EEE", Gender="F", Subjects=new List<string> {"c#",".NetCore"}}
            };
            return students;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var result = Student.GetAllStudents().Select(std => new { std.Name, std.Gender });
            var result = Student.GetAllStudents().SelectMany(std => std.Subjects).Distinct();
            foreach(var student in result)
            {
                //Console.WriteLine(student.Name+"\t"+student.Gender+"\t");
                Console.WriteLine(student);
            }
        }
    }
}*/
/*namespace LINQOrderby
{
    public class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int ID { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Name="AAA", Gender="F", ID =1},
                new Student{Name="FFF", Gender="M", ID =2},
                new Student{Name="AAA ", Gender="F", ID =3},
                new Student{Name="DDD", Gender="M", ID =4},
                new Student{Name="EEE", Gender="F", ID =5}
            };
            return students;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var res = Student.GetAllStudents().OrderBy(s=>s.Name).ThenBy(s=>s.Gender);
            //var res = Student.GetAllStudents().OrderByDescending(x => x.Name);
            var res = Student.GetAllStudents();

            foreach (var student in res)
            {
                Console.WriteLine(student.Name + "\t" + student.Gender);
            }

            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            lst.Reverse();
            foreach(var student in lst)
            {
                Console.WriteLine(student);
            }
                
        }
    }
}*/
/*namespace LINQPartitioning
{
    class Program
    {
        static void Main (string[] args)
        {
            List<string> list = new List<string>() { "one", "two", "three", "four", "five", "six" };
            *//*var result = list.Take(3);*//*
            //var result = list.Skip(3);
            //var result = list.TakeWhile (s => s.Length >3);
            var result = list.SkipWhile(s=>s.Length <4);
            foreach ( var item in result )
            {
                Console.WriteLine(item);
            }
        }
    }
}*/
/*namespace LINQQueryExecution
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student{Id = 1, Name="RRR", TotalMarks=500},
                new Student{Id = 2, Name="SSS", TotalMarks=700},
                new Student{Id = 3, Name="TTT", TotalMarks=400},
            };
            //var result = (from stud in list where stud.TotalMarks >= 500 select stud).ToList();
            var result = from stud in list where stud.TotalMarks >= 500 select stud;
            list.Add(new Student { Id = 4, Name = "UUU", TotalMarks = 900 }); //lazy loading.(Differed Execution)
            foreach(var stud in result)
            {
                Console.WriteLine(stud.Name+"\t"+stud.TotalMarks);
            }
        }
    }
}*/
/*namespace LINQConversionOperator1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            *//*int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8};
            var result = nums.ToList();*/
/*List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
var res = list.ToArray();*//*
List<Student> list = new List<Student>();
list.Add(new Student { Id = 1, Name = "AAA", TotalMarks = 500 });
list.Add(new Student { Id = 2, Name = "BBB", TotalMarks = 400 });
list.Add(new Student { Id = 3, Name = "CCC", TotalMarks = 900 });
list.Add(new Student { Id = 4, Name = "DDD", TotalMarks = 300 });
list.Add(new Student { Id = 5, Name = "EEE", TotalMarks = 200 });

var result = list.ToDictionary(x=>x.Id,x=>x.Name);

foreach (KeyValuePair<int,string> obj in result)
{
    Console.WriteLine(obj.Key+"\t"+obj.Value);
}
}
}
}*/
/*namespace LINQConversionOperator2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            *//*int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8};
            var result = nums.ToList();*/
/*List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
var res = list.ToArray();*/
/*            List<Student> list = new List<Student>();
            list.Add(new Student { Id = 1, Name = "AAA", Job = "SSE" });
            list.Add(new Student { Id = 2, Name = "BBB", Job = "SE" });
            list.Add(new Student { Id = 3, Name = "CCC", Job = "SSE" });
            list.Add(new Student { Id = 4, Name = "DDD", Job = "SE" });
            list.Add(new Student { Id = 5, Name = "EEE", Job = "SSE" });

            var result = list.ToLookup(x => x.Job);

            foreach (var res in result)
            {
                Console.WriteLine(res.Key);
                foreach (var item in result[res.Key])
                {
                    Console.WriteLine(item.Id + "\t" + item.Name);
                }
            }*//*
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add("ABCD");
            var result = list.OfType<int>();
            //var result = list.Cast<int>();
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}*/
/*namespace groupingOperatorPart1
{
    public class Student
    {
        public int id;
        public string name;
        public int standard;
        public int age;

        public static List<Student> getStudents()
        {
            List<Student> list = new List<Student>()
            {
                new Student() { id = 1, name="ram", age=20, standard=12},
                new Student() { id = 2, name="ram", age=18, standard=10},
                new Student() { id = 3, name="ram", age=19, standard=10},
                new Student() { id = 4, name="ram", age=20, standard=12},
                new Student() { id = 5, name="ram", age=20, standard=10},
                new Student() { id = 6, name="ram", age=23, standard=12},
                new Student() { id = 7, name="ram", age=20, standard=12},
                new Student() { id = 8, name="ram", age=19, standard=10},
                new Student() { id = 9, name="ram", age=17, standard=10},
                new Student() { id = 10, name="ram", age=16, standard=12},
            };
            return list;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            *//*var result = from stud in Student.getStudents()
                         group stud by stud.standard into eGroup
                         orderby eGroup.Key
                         select eGroup;*//*
            //var result = Student.getStudents().GroupBy(x=>x.standard).OrderBy(s => s.Key);
            *//* foreach (var group in result)
             {
                 Console.WriteLine("Standard:{0}", group.Key);
                 foreach (var student in group)
                 {
                     Console.WriteLine(student.id + "\t" + student.name + "\t" + student.age);
                 }
             }*/
/* var result = from stud in Student.getStudents()
              group stud by stud.standard into eGroup
              orderby eGroup.Key
              select new { StandardKey = eGroup.Key, StudentObj = eGroup.OrderBy(x=>x.name) };
 foreach (var group in result)
 {
     Console.WriteLine("Standard:{0}", group.StandardKey);
     foreach (var student in group.StudentObj)
     {
         Console.WriteLine(student.id + "\t" + student.name + "\t" + student.age);
     }
 }*//*
var result = Student.getStudents().GroupBy(X => X.standard).OrderBy(s => s.Key).Select(x => new { StandardKey = x.Key, StudentObj = x.OrderBy(y => y.name) });
foreach (var group in result)
{
    Console.WriteLine("Standard:{0}", group.StandardKey);
    foreach (var student in group.StudentObj)
    {
        Console.WriteLine(student.id + "\t" + student.name + "\t" + student.age);
    }
}

}
}
}*/
/*namespace groupingOperatorPart2
{
    public class Student
    {
        public int id;
        public string name;
        public int standard;
        public int age;

        public static List<Student> getStudents()
        {
            List<Student> list = new List<Student>()
            {
                new Student() { id = 1, name="ram", age=20, standard=12},
                new Student() { id = 2, name="ram", age=18, standard=10},
                new Student() { id = 3, name="ram", age=19, standard=10},
                new Student() { id = 4, name="ram", age=20, standard=12},
                new Student() { id = 5, name="ram", age=20, standard=10},
                new Student() { id = 6, name="ram", age=23, standard=12},
                new Student() { id = 7, name="ram", age=20, standard=12},
                new Student() { id = 8, name="ram", age=19, standard=10},
                new Student() { id = 9, name="ram", age=17, standard=10},
                new Student() { id = 10, name="ram", age=16, standard=12},
            };
            return list;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            *//*var result = from std in Student.getStudents()
                         group std by new { std.standard, std.age } into eGroup
                         orderby eGroup.Key.standard, eGroup.Key.age
                         select eGroup;*/
/*var result = Student.getStudents().GroupBy(stud=> new {stud.standard,stud.age})
                                 .OrderBy(x => x.Key.standard).ThenBy(y => y.Key.age);
foreach (var group in result)
{
    Console.WriteLine("Standard {0}     age {1}",group.Key.standard,group.Key.age);
    foreach(var student in group)
    {
        Console.WriteLine("{0}         {1}", student.id, student.name);
    }
}*/
/*var result = from std in Student.getStudents()
             group std by new { std.standard, std.age } into eGroup
             orderby eGroup.Key.standard, eGroup.Key.age
             select new {StandardKey=eGroup.Key.standard,
                          AgeKey=eGroup.Key.age,
                          StudentObj=eGroup.OrderBy(x=>x.name)};*//*
var result = Student.getStudents().GroupBy(stud => new { stud.standard, stud.age })
                                 .OrderBy(x => x.Key.standard).ThenBy(y => y.Key.age)
                                 .Select(s => new
                                 {
                                     StandardKey = s.Key.standard,
                                     AgeKey = s.Key.age,
                                     StudentObj = s.OrderBy(t => t.name)
                                 });
foreach (var group in result)
{
    Console.WriteLine("Standard {0}     age {1}", group.StandardKey, group.AgeKey);
    foreach (var student in group.StudentObj)
    {
        Console.WriteLine("{0}         {1}", student.id, student.name);
    }
}
}
}
}*/
/*namespace elementaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            //var res = nums.First();
            int[] nums = { };
           // var res = nums.LastOrDefault();
           //var res = nums.ElementAt(3);
           var res=nums.ElementAtOrDefault(6);
            //var res = nums.FirstOrDefault();//output:0
            Console.WriteLine(res);
        }
    }
}*/
/*namespace setOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            *//*string[] names = { "INDIA", "USA", "usa", "USA", "india", "UK", "Canada", "Italy" };

            var res = names.Distinct(StringComparer.OrdinalIgnoreCase);
            foreach (string name in res)
            {
                Console.WriteLine(name);
            }*//*
            int[] num1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] num2 = { 4, 5, 6, 7 ,9};

            //var res = num1.Union(num2);
            //var res = num1.Select(x => x).Union(num2.Select(x => x));
            //var res = num1.Intersect(num2);
            var res= num2.Except(num1);
            foreach ( int i in res )
            {
                Console.WriteLine(i);
            }
        }
    }
}*/
/*namespace concatAndSequentialEqualOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            *//*int[] num1 = { 1, 2, 3, 4, 5 };
            int[] num2 = { 11, 12, 13, 14 };
            var res = num1.Concat(num2);
            foreach (int num3 in res) 
            {
                Console.WriteLine(num3);
            }*//*
            string[] s1 = { "INDIA", "USA", "UK" };
            string[] s2 = { "UK", "INDIA", "USA" };

            //var res = s1.SequenceEqual(s2,StringComparer.OrdinalIgnoreCase);
            //var res=s1.OrderBy(x => x).SequenceEqual(s2.OrderBy(x => x));
            var res = s1.SequenceEqual(s2);
            Console.WriteLine(res);
        }
    }
}*/
/*namespace quantifiersOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var res=nums.All(x => x <10);
            //var res=nums.Any();
            var res = nums.Contains(8);
            Console.WriteLine(res);
        }
    }
}*/
namespace joinsinLINQ
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department { ID = 1, Name="IT"},
                new Department { ID = 2, Name="HR"},
                new Department { ID = 3, Name="Payroll"}
            };
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee{ID=1, Name="RAM",DepartmentID=1},
                new Employee{ID=2, Name="RAM",DepartmentID=2},
                new Employee{ID=3, Name="RAM",DepartmentID=2},
                new Employee{ID=4, Name="RAM",DepartmentID=1},
                new Employee{ID=5, Name="RAM",DepartmentID=1},
                new Employee{ID=6, Name="RAM",DepartmentID=2},
                new Employee{ID=7, Name="RAM",DepartmentID=1},
                new Employee{ID=8, Name="RAM",DepartmentID=3},
                new Employee{ID=9, Name="RAM",DepartmentID=1},
                new Employee{ID=10, Name="RAM",DepartmentID=1},
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Groupjoin
            //var result = Department.GetAllDepartments()
            //            .GroupJoin(Employee.GetAllEmployees(), d => d.ID, e => e.DepartmentID, (Dept, Emp) => new { Department = Dept, employee = Emp });
            /*var result = from d in Department.GetAllDepartments()
                         join e in Employee.GetAllEmployees()
                         on d.ID equals e.DepartmentID into eGroup
                         select new { Department = d, employee = eGroup };
            foreach(var dept in result)
            {
                Console.WriteLine(dept.Department.Name);
                foreach(var emp in dept.employee)
                {
                    Console.WriteLine("\t" + emp.Name);
                }
                Console.WriteLine();
            }*/
            //Innerjoin
            /* var result = Employee.GetAllEmployees().Join(Department.GetAllDepartments(), e => e.DepartmentID, d => d.ID, (employee, department) => new
             { EmpName = employee.Name, DeptName = department.Name });*/

            /*var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID
                         select new { EmpName = e.Name, DeptName = d.Name };
            
            foreach(var employee in result)
            {
                Console.WriteLine(employee.EmpName+"\t"+employee.DeptName);
            }*/
            //LeftOuterJoin
            /*var result = Employee.GetAllEmployees().GroupJoin(Department.GetAllDepartments(), e => e.DepartmentID, d => d.ID, (emp, dept) => new
            { emp, dept }).SelectMany(z => z.dept.DefaultIfEmpty(), (a, b) => new { EmpName = a.emp.Name, DeptName = b == null ? "No Dept" : b.Name });
            foreach(var emp in result)
            {
                Console.WriteLine(emp.EmpName+"\t"+emp.DeptName);
            }
*/
            //crossjoin
            /*var result = Employee.GetAllEmployees()
                .SelectMany(Department.GetAllDepartments(), (e, d) => new { e, d });*/
            var result = from d in Department.GetAllDepartments()
                         from e in Employee.GetAllEmployees()
                         select new { e, d };
            foreach(var emp in result)
            {
                Console.WriteLine(emp.e.Name + "\t" + emp.d.Name);
            }
        }
    }
}