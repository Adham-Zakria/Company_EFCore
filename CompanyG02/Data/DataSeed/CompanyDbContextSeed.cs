using CompanyG02.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CompanyG02.Data.DataSeed
{
    internal static class CompanyDbContextSeed
    {
        public static void Seed(CompanyDBContext dbContext)
        {
            if( ! dbContext.Departments.Any())
            {
                var DepartmentsData = File.ReadAllText("D:\\.Net\\Lec 33 Entity Framework\\CompanyG02Solution\\CompanyG02\\Data\\DataSeed\\departments.json");
                var departments = JsonSerializer.Deserialize<List<Department>>(DepartmentsData);

                if (departments?.Count() > 0)
                {
                    foreach (var item in departments)
                    {
                        dbContext.Departments.Add(item);
                    }
                    dbContext.SaveChanges();
                }
            }

            if (!dbContext.Employees.Any())
            {
                var EmployeessData = File.ReadAllText("D:\\.Net\\Lec 33 Entity Framework\\CompanyG02Solution\\CompanyG02\\Data\\DataSeed\\employees.json");
                var employees = JsonSerializer.Deserialize<List<Employee>>(EmployeessData);

                if (employees?.Count() > 0)
                {
                    foreach (var item in employees)
                    {
                        dbContext.Employees.Add(item);
                    }
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
