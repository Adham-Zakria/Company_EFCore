using CompanyG02.Data;
using CompanyG02.Data.DataSeed;
using CompanyG02.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyG02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (CompanyDBContext companyDBContext = new CompanyDBContext())
            {

                #region Add
                //Employee emp01 = new Employee() { Name = "Nada", Age = 26, Salary = 9_000, Email = "Nada@gmail.com" };
                //Employee emp02 = new Employee() {Id=1,  Name = "Rana", Age = 26, Salary = 8_000, Email = "Rana@gmail.com" };

                //Console.WriteLine(companyDBContext.Entry(emp01).State);//Detached
                //Console.WriteLine(companyDBContext.Entry(emp02).State);//Detached

                //companyDBContext.ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.TrackAll;//Default Behaviour

                //Employee emp04 = new Employee() { Id = 3, Name = "Omar", Age = 26, Salary = 8_000, Email = "Rana@gmail.com" };

                //companyDBContext.Set<Employee>().Add(emp04); // .toTable instead of dbSet
                // companyDBContext.Employees.Add(emp01); //as Local Sequence 
                // companyDBContext.Add(emp02);
                //companyDBContext.Entry(emp01).State=EntityState.Added;

                #endregion
                #region Get And Update
                //var emp = (from e in companyDBContext.Employees
                //           where e.Id == 3
                //           select e).FirstOrDefault();


                //if(emp is not null)
                //{
                //    Console.WriteLine(companyDBContext.Entry(emp).State);
                //    Console.WriteLine(emp.Name);
                //    Console.WriteLine(emp.Email);
                //    emp.Salary = 10_000;
                //    Console.WriteLine(companyDBContext.Entry(emp).State);

                //}
                #endregion

                #region Get And Remove

                //var emp = (from e in companyDBContext.Employees
                //           where e.Id == 3
                //           select e).FirstOrDefault();


                //if (emp is not null)
                //{
                //    Console.WriteLine(companyDBContext.Entry(emp).State);
                //    Console.WriteLine(emp.Name);

                //    //companyDBContext.Set<Employee>().Remove(emp); // .toTable instead of dbSet
                //    /*companyDBContext.Employees.Remove(emp); *///as Local Sequence 
                //    companyDBContext.Remove(emp);
                //    //companyDBContext.Entry(emp).State = EntityState.Deleted;
                //    //
                //    Console.WriteLine(companyDBContext.Entry(emp).State);

                //}
                #endregion

                #region Data Seed

                //CompanyDbContextSeed.Seed(companyDBContext);

                #endregion

                #region EX 01 (Nav Prop) Data Loading
                //var emp = (from e in companyDBContext.Employees
                //           where e.Id == 3
                //           select e).FirstOrDefault();


                //if (emp is not null)
                //{
                //    Console.WriteLine($" Employee : {emp.Name} , Department : {emp.Department?.Name ?? "No Department"}");

                //}
                #endregion

                #region  EX 02 (Nav Prop) Data Loading

                //var dept = (from d in companyDBContext.Departments
                //            where d.DepartmentId == 1
                //            select d).FirstOrDefault();

                //if (dept != null)
                //{
                //    Console.WriteLine($" DepartmentId : {dept.DepartmentId} , DepartmentName : {dept.Name}");

                //    foreach (var emp in dept.Employees)
                //    {
                //        Console.WriteLine($"Employees : {emp.Name}");
                //    }
                //}
                #endregion

                #region Explicit Loading

                #region EX 01 (Nav Prop) Data Loading
                //var emp = (from e in companyDBContext.Employees
                //           where e.Id == 3
                //           select e).FirstOrDefault();

                //companyDBContext.Entry(emp).Reference(nameof(Employee.Department)).Load();

                //if (emp is not null)
                //{
                //    Console.WriteLine($" Employee : {emp.Name} , Department : {emp.Department?.Name ?? "No Department"}");

                //}
                #endregion

                #region  EX 02 (Nav Prop) Data Loading

                //var dept = (from d in companyDBContext.Departments
                //            where d.DepartmentId == 1
                //            select d).FirstOrDefault();

                //companyDBContext.Entry(dept).Collection(nameof(Department.Employees)).Load();

                //if (dept != null)
                //{
                //    Console.WriteLine($" DepartmentId : {dept.DepartmentId} , DepartmentName : {dept.Name}");

                //    foreach (var employee in dept.Employees)
                //    {
                //        Console.WriteLine($"Employees : {employee.Name}");
                //    }
                //}
                #endregion

                #endregion



                #region Eager Loading

                #region EX 01 (Nav Prop) Data Loading
                //var emp = (from e in companyDBContext.Employees.Include(e => e.Department)  // or .Include(nameof(Employee.Department))
                //           where e.Id == 3
                //           select e).FirstOrDefault();


                //if (emp is not null)
                //{
                //    Console.WriteLine($" Employee : {emp.Name} , Department : {emp.Department?.Name ?? "No Department"}");

                //}
                #endregion

                #region  EX 02 (Nav Prop) Data Loading

                //var dept = (from d in companyDBContext.Departments.Include(d=>d.Employees)
                //            where d.DepartmentId == 1
                //            select d).FirstOrDefault();


                //if (dept != null)
                //{
                //    Console.WriteLine($" DepartmentId : {dept.DepartmentId} , DepartmentName : {dept.Name}");

                //    foreach (var employee in dept.Employees)
                //    {
                //        Console.WriteLine($"Employees : {employee.Name}");
                //    }
                //}
                #endregion

                #endregion


                #region Lazy Loading

                #region EX 01 (Nav Prop) Data Loading
                //var emp = (from e in companyDBContext.Employees
                //           where e.Id == 3
                //           select e).FirstOrDefault();


                //if (emp is not null)
                //{
                //    Console.WriteLine($" Employee : {emp.Name} , Department : {emp.Department?.Name ?? "No Department"}");

                //}
                #endregion

                #region  EX 02 (Nav Prop) Data Loading

                //var dept = (from d in companyDBContext.Departments
                //            where d.DepartmentId == 1
                //            select d).FirstOrDefault();


                //if (dept != null)
                //{
                //    Console.WriteLine($" DepartmentId : {dept.DepartmentId} , DepartmentName : {dept.Name}");

                //    foreach (var employee in dept.Employees)
                //    {
                //        Console.WriteLine($"Employees : {employee.Name}");
                //    }
                //}
                #endregion

                #endregion


                #region Join - Join() , GroupJoin()

                //var res = from d in companyDBContext.Departments
                //          join e in companyDBContext.Employees
                //          on d.DepartmentId equals e.DepartmentId
                //          select( new
                //          {
                //              EmployeeId=e.Id,
                //              EmployeeName=e.Name,
                //              DepartmentId=d.DepartmentId,
                //              DepartmentName=d.Name
                //          });    

                //res=companyDBContext.Departments.Join(companyDBContext.Employees , d=>d.DepartmentId , e=>e.DepartmentId ,
                //    (d,e)=>new {
                //        EmployeeId = e.Id,
                //        EmployeeName = e.Name,
                //        DepartmentId = d.DepartmentId,
                //        DepartmentName = d.Name
                //    });

                //foreach (var item in res)
                //{
                //    Console.WriteLine(item);
                //}

                //var GroupJoinRes= companyDBContext.Departments.GroupJoin(companyDBContext.Employees, d => d.DepartmentId, e => e.DepartmentId,
                //    (department, emps) => new {
                //        department,
                //        emps
                //    });

                //GroupJoinRes = from d in companyDBContext.Departments
                //               join e in companyDBContext.Employees
                //               on d.DepartmentId equals e.DepartmentId into employees
                //               select new
                //               {
                //                   department = d,
                //                   emps = employees
                //               };

                //foreach (var item in GroupJoinRes)
                //{
                //    Console.WriteLine($"Department : {item.department.DepartmentId} , {item.department.Name}");
                //    foreach (var emp in item.emps)
                //    {
                //        Console.WriteLine($"Employee : {emp.Id} , {emp.Name}");
                //    }
                //}
                
             

                #endregion





                companyDBContext.SaveChanges();
            }
        }
    }
}
