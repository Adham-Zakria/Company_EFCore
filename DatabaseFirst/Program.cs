using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                #region Sql Query

                int count = 3;

                //Select
                var res = context.Categories.FromSqlRaw("select top({0}) * from Categories", count);

                var categories = context.Categories.FromSqlInterpolated($"select top({count}) * from Categories");

                //Execute
                context.Database.ExecuteSqlInterpolated($"update Categories set CategoryName='Test' where CategoryID=1");

                #endregion



                #region Procedure Calling

                NorthwindContextProcedures contextProcedures = new NorthwindContextProcedures(context);
                var result = contextProcedures.SalesByCategoryAsync("Beverages","2018").Result;

                foreach (var item in result)
                    Console.WriteLine(item.ProductName);

                #endregion            

            }
        }   
    }
}
