using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Info
{
    internal class MyDesignTimeDbContext : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MyContext> builder = new();
            string connStr = "data source=localhost;" +
                "Integrated Security=SSPI;" +
                "Initial Catalog=MyDatabaseName;" +
                "Trust Server Certificate=true;";
            builder.UseSqlServer(connStr);
            return new MyContext(builder.Options);
        }
    }
}
