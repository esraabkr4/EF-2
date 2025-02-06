using EF_Demo.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Ass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterpriseDBContext dbContext = new EnterpriseDBContext();
            //dbContext.Database.EnsureCreated();
            dbContext.Database.Migrate();
            //PM> Add-Migration "First Migration"
            //PM> Update-database
            //to return to old migration
            //PM> Update-database -Migration "First Migration"
            //PM> Remove-Migration
            //PM> Update-database
            //to remove all Migrations
            //PM> Update-database 0
        }
    }
}
