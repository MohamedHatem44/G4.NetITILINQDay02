using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace G4.NetITILINQDay02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Named Obj
            //Student std1 = new Student() { Id = 1, Name = "Mohamed" };
            //// Named Obj => Object has ref Name
            //Console.WriteLine(std1); // namespace.classname
            //std1.Name = "ahmed";

            //var arr = new int[] { 1, 2, 3 };
            #endregion

            #region Collections
            ///Base for all collections
            ///1- IEnumerable
            ///2- ICollection
            //List<int> list = new List<int>();

            //IEnumerable<int> nums = new List<int>();
            //Dictionary<int,string> dic = new Dictionary<int,string>();
            //IEnumerable<KeyValuePair<int,string>> nums3 = new Dictionary<int,string>();
            ////IEnumerable<int> nums2 = new IEnumerable<int>(); XXXXXX Interface
            #endregion

            #region Anonymous Obj
            //// obj without name
            //List<Student> students = new List<Student>()
            //{ 
            //    new Student{Id=1, Name="ay hage"} 
            //};
            #endregion

            #region Anonymous Function
            //(int x, int y) => { return x + y; };

            // Delegate
            // 3 

            // 1-Predcite => Return bool and take 1 input param
            //Predicate<Student> prd1 = std => std != null;

            //// 2- Action => take from 0 to 16 Inputs param and return void
            //Action action = () =>
            //{
            //    int y = 5;
            //    Console.WriteLine("Hello Action");
            //};

            //// 3- Func => Take from 0 to 16 and return Genaric
            //Func<int> func1 = () => { return 5; };
            //Func<int, int,bool> func2 = (c,y) => { return true; };
            #endregion

            #region Anonymous Type
            //var s1 = new { Id = 1, Name = "Ali", Age = 25 };
            //Console.WriteLine(s1.GetType());
            //// obj on the fly 

            //var s2 = new { Id = 1, Name = "Ali", Age = 25 };
            //// Read Only
            ////s2.Name = "Mohamed";
            #endregion

            #region Before LINQ
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> ints2 = new List<int>();
            #endregion

            #region LINQ
            // Features Added on Collections
            // 40 Additional Methods (Extention Methods)
            // "LINQ stands for Language Integrated Query, a Microsoft .NET Framework
            //that provides a standardized way to query data from various data sources using
            //a common syntax within programming languages like C#"	
            //
            //Extention Method	
            #endregion

            #region Extention Method
            //string str = "Hello World From Ismailia";
            //int count = Helper.GetWordsCount(str);
            //Console.WriteLine(count);

            //int count2 = str.GetWordsCountEx();
            //int count3 = ExtentionMethod.GetWordsCountEx(str);
            //Console.WriteLine(count2);
            #endregion

            #region LINQ
            //// 1- Query Syntax
            //// 2- Method Syntax [Fluent Syntax]
            //// 

            //// 1- Query Syntax
            //// Step 1 Data Source
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //// Step 2 Query
            //// Data Source
            //// Condition
            //// Select
            //// from where select
            //var QuerySyntax = from item in ints // Data Source
            //                  where item > 5
            //                  select item;

            //foreach (var item in QuerySyntax)
            //{
            //    Console.WriteLine(item);
            //}

            //// 2- Method Syntax [Fluent Syntax]

            //var MethodSyntax = ints.Where(i => i > 5);
            #endregion

            #region Repository
            var Employees = Repository.GetEmployees();
            var Departments = Repository.GetDepartments();
            //foreach (var item in Employees)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Try => Enumerable => Class that has linq Methods
            //var emp1 = Employees.Min(emp => emp.Id);
            //var emp2 = Enumerable.Min(Employees,emp=>emp.Id); 
            //Console.WriteLine(emp1);
            //Console.WriteLine(emp2);
            #endregion

            #region LINQ Query Expression
            //// Select all Employees 
            //// select * from employees => SQL
            //var q1 = from item in Employees
            //         select item;

            //var q2 = from item in Employees
            //         where item.DeptId == 1
            //         select item;

            //// from select where
            //var q3 = from item in Employees
            //         where item.Age > 35
            //         select item;

            //var q4 = from item in Employees
            //         where item.Age > 35 && item.DeptId == 1
            //         select item;

            //var q5 = from item in Employees
            //         where item.Salary == Employees.Max(w => w.Salary)
            //         select item;

            ////Console.WriteLine(q5); XXXXXXXXXX where always return list 
            //foreach (var item in q5)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Method Syntax [fluent syntax] Linq , Lambda Exp => function chaining
            //// Select all empoyees
            //var q6 = Employees.ToList();

            //var q7 = Employees.Where(emp => emp.DeptId == 1);

            //var q8 = Employees.Where(emp => emp.Age > 40);

            ////var q4 = from item in Employees
            ////         where item.Age > 35 && item.DeptId == 1
            ////         select item;

            //var q9 = Employees.Where(emp => emp.Age > 35 && emp.DeptId == 1);
            //var q9_2 = Employees.Where(emp => emp.Age > 35).Where(emp => emp.DeptId == 1);

            //var q10 = Employees //10
            //    .Where(emp => emp.Age > 35) // => 6
            //    .Where(emp => emp.DeptId == 1) // =>4 
            //    .OrderByDescending(emp => emp.Age); //=>4
            //// function chaining


            //var q11 = Employees
            //    .Where(emp => emp.Age > 35)
            //    .OrderBy(emp => emp.DeptId);


            //var q11_1 = Employees
            //    .Where(emp => emp.Age > 35)
            //    .OrderBy(emp => emp.DeptId)
            //    .ThenBy(emp=>emp.Name);


            //foreach (var item in q11)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------------------------");
            //foreach (var item in q11_1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Single Obj => These operators return a single element from a sequence. Examples First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault, and ElementAt.
            // First
            // FirstOrDefault
            // Last
            // LastOrDefault
            // Single
            // SingleOrDefault
            // ElementAt

            //var q12 = Employees.First(emp => emp.Id == 1);
            //var q13 = Employees.FirstOrDefault(emp => emp.Id == 1);

            //var q14 = Employees.First();

            ////Unhandled exception. System.InvalidOperationException: Sequence contains no matching element
            ////var q15 = Employees.First(e => e.DeptId == 99);

            ////null empty
            //var q16 = Employees.FirstOrDefault(e => e.DeptId == 99);
            ////if (q16 != null)
            ////{
            ////    Console.WriteLine(q16);
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Not Found");
            ////}

            //var q17 = Employees.Last();
            ////var q18 = Employees.Last(e => e.Id == 50);
            //var q19 = Employees.LastOrDefault(e => e.Id == 50);


            //if list contain more than one element => Unhandled exception. System.InvalidOperationException: Sequence contains more than one element
            //var q20 = Employees.Single();

            // if list does not contain elements => Unhandled exception. System.InvalidOperationException: Sequence contains no matching element
            //var q21 = Employees.Single(e=>e.DeptId==99);

            //if list contain more than one element => Unhandled exception. System.InvalidOperationException: Sequence contains more than one element
            //var q22 = Employees.SingleOrDefault();


            // if list does not contain return null
            //var q23 = Employees.SingleOrDefault(e=>e.DeptId==99);

            // if found element no error else Unhandled exception. System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative
            // and less than the size of the collection. (Parameter 'index')
            //var q24 = Employees.ElementAt(3);
            //var q25 = Employees.ElementAt(20);

            // if found element no error else return dedault
            //var q26 = Employees.ElementAtOrDefault(3);
            //var q27 = Employees.ElementAtOrDefault(20);
            //Console.WriteLine(q27);
            #endregion

            #region Deffered Execution vs Immediete Execution
            //// All Linq Query are Deffered Execution Except Single Obj => First, Last, Single
            ////var q28 = Employees.Where(e => e.DeptId == 1);

            ////Employees.Add(new Employee { Id = 11, Name = "New Name", Age = 36, Salary = 5566, DeptId = 1 });

            ////foreach (var item in q28)
            ////{
            ////    Console.WriteLine(item); // Execution Happen here
            ////}

            //var q29 = Employees.Where(e => e.DeptId == 1).ToList(); // Execution Happen here

            //Employees.Add(new Employee { Id = 11, Name = "New Name", Age = 36, Salary = 5566, DeptId = 1 });

            //foreach (var item in q29)
            //{
            //    Console.WriteLine(item); 
            //}
            #endregion

            #region Select Top 3 , Select Top 3 by Salary
            //var q30 = Employees.Take(3);
            //var q30_1 = Employees.Take(35);
            //foreach (var item in q30_1)
            //{
            //    Console.WriteLine(item);
            //}
            //var q31 = Employees.TakeLast(3);

            //var q32 = Employees.Skip(3).Take(3);

            //var q33 = Employees.TakeWhile(emp => emp.Name.Length < 5);
            //var q34 = Employees.TakeWhile(emp => emp.DeptId == 2);
            //var q35 = Employees.SkipWhile(emp => emp.Name.Length < 5);

            //foreach (var item in q34)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region All, Any
            //List<int> nums = new List<int>() { 1, 1, 2, 3, 5, 4, 7, 5, 8, 5, 7, 5, 8, 7 };

            //var res1 = nums.Any(list => list %2 == 0);
            //var res2 = nums.All(list => list %2 == 0);
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            #endregion

            #region Distinct
            //List<int> nums = new List<int>() { 1, 1, 2, 3, 5, 4, 7, 5, 8, 5, 7, 5, 8, 7, 6, 10, 12 };
            //var q = nums.Distinct();

            //foreach (var item in q)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Distinct Emp
            //List<Employee> EmployeesList = new List<Employee>()
            //{
            //    new Employee{Id = 1, Name = "Ramy", Age = 22, Salary = 1234, DeptId = 1 },
            //    new Employee{Id = 1, Name = "Ramy", Age = 22, Salary = 1234, DeptId = 1 },
            //    new Employee{Id = 2, Name = "Mai", Age = 32, Salary = 2234, DeptId = 2 },
            //    new Employee{Id = 3, Name = "Ali", Age = 42, Salary = 3234, DeptId = 3 },
            //    new Employee{Id = 4, Name = "Omar", Age = 52, Salary = 4234, DeptId = 1 },
            //    new Employee{Id = 5, Name = "Mostafa", Age = 28, Salary = 5234, DeptId = 2 },
            //    new Employee{Id = 6, Name = "Ahmed", Age = 38, Salary = 6234, DeptId = 3 },
            //    new Employee{Id = 7, Name = "Sara", Age = 48, Salary = 7234, DeptId = 1 },
            //    new Employee{Id = 8, Name = "Osama", Age = 26, Salary = 8234, DeptId = 2 },
            //    new Employee{Id = 9, Name = "Mohamed", Age = 36, Salary = 9234, DeptId = 3 },
            //    new Employee{Id = 10, Name = "Nour", Age = 46, Salary = 10234, DeptId = 1 },
            //    new Employee{Id = 11, Name = "Nour", Age = 46, Salary = 10234, DeptId = 1 },
            //    new Employee{Id = 11, Name = "Nour", Age = 46, Salary = 10234, DeptId = 1 }
            //};

            //var q1 = EmployeesList.Distinct(new EmpComp());
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Projection => Select
            //// select names only for Emp in Dept 2
            //var q35 = Employees.Where(e => e.DeptId == 2).Select(e => e.Name);
            //var q35_1 = from emp in Employees
            //            where emp.DeptId == 2
            //            select emp.Name;

            //var q36 = Employees
            //    .Where(e => e.DeptId == 2)
            //    .Select(e => new Employee { Id = e.Id, Name = e.Name });

            //var q37 = Employees
            //    .Where(e => e.DeptId == 2)
            //    .Select(e => new { Id = e.Id, Name = e.Name });

            //var q38 = Employees
            //    .Where(e => e.DeptId == 2)
            //    .Select(e => new { SN = e.Id, FullName = e.Name });


            // XXXXXXXXXXXXXXXXXXX
            //var q39 = Employees
            //    .Select(e => new { Id = e.Id, FullName = e.Name })
            //    .Where(e => e.DeptId == 2)
            //    .OrderBy(e => e.Name);

            //foreach (var item in q38)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Join Query Syntax
            //// Query Syntax
            //var q40 = from emp in Employees
            //          join dept in Departments
            //          on emp.DeptId equals dept.DeptId
            //          select new { emp.Id, emp.Name, dept.DeptName };

            //foreach (var item in q40)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Join Fluent Syntax
            //var q41 = Employees.Join(Departments, emp => emp.DeptId, dept => dept.DeptId, (e, d) => new {e.Id, e.Name, d.DeptName });
            //foreach (var item in q41)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region GroupBy
            //var q42 = from emp in Employees
            //          group emp by emp.DeptId;

            //var q43 = from emp in Employees
            //          join dept in Departments
            //          on emp.DeptId equals dept.DeptId
            //          group emp by dept.DeptName;

            //foreach (var emp in q43)
            //{
            //    Console.WriteLine(emp.Key);
            //    foreach (var item in emp)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region min. max, Avg, Count, LongCount
            //var q44 = Employees.Min(emp=>emp.Salary);
            //var q45 = Employees.Max(emp=>emp.Salary);
            //var q46 = Employees.Average(emp=>emp.Salary);
            //var q46 = Employees.Count();
            //Console.WriteLine(q46);

            //var q47 = Employees.Where(e=>e.Salary < (Employees.Average(emp=>emp.Salary)));
            //var q48 = Employees.Where(e => e.Salary < q46);
            //Console.WriteLine(q47);
            #endregion

            #region Oftype
            //List<User> Users = new List<User>()
            //{
            //    new Male{Id=1, Name="Ali"},
            //    new Male{Id=2, Name="Ahmed"},
            //    new Female{Id=3, Name="Sara"},
            //    new Female{Id=4, Name="Hala"},
            //};

            //var q50 = Users.OfType<Male>();
            //foreach (var item in q50)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Insert, Update, Delete
            //// Insert
            //Employees.Add(new Employee { Id = 12, Name = "ali", Age = 25, Salary = 25, DeptId = 1 });
            //// Update
            //var updateEmp = Employees.SingleOrDefault(e => e.Id == 12);
            //if (updateEmp != null)
            //{
            //    updateEmp.Name = "New Name";
            //}


            //// Delete
            //var deletedEmp = Employees.SingleOrDefault(e => e.Id == 12);
            //if (deletedEmp != null)
            //{
            //    Employees.Remove(deletedEmp);
            //}


            //// LINQ To Obj
            //Employees.RemoveAll(e => e.DeptId == 1);
            //foreach (var item in Employees)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Set Operators Expect, Concat, Union, Intersect
            //List<int> nums1 = new List<int> { 1, 2, 3, 4, 5, 6,7 };
            //List<int> nums2 = new List<int> { 7, 8, 9, 10, 11, 12 };

            //var q51 = nums1.Concat(nums2).ToList();

            //var q52 = nums1.Union(nums2).ToList();

            //var q53 = nums1.Except(nums2).ToList();

            //var q54 = nums1.Intersect(nums2).ToList();

            ////foreach (var item in q54)
            ////{
            ////    Console.WriteLine(item);
            ////}
            #endregion

            #region Zip Operator
            //List<int> nums = new List<int>() { 1, 2, 3 };
            //List<string> names = new List<string>() { "Ali", "Mohamed", "Mai" };

            //var list = nums.Zip(names, (i, n) => new { Number = i, Names = n });

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region indexed where, indexed select
            //var indexSelect = Employees.Select((emp, index) => new { index, emp.Name });
            //foreach (var item in indexSelect)
            //{
            //    Console.WriteLine(item);
            //}

            //var indexWhere = Employees.Where((emp, index) => emp.DeptId == 1 && index < 5);
            //foreach (var item in indexWhere)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
