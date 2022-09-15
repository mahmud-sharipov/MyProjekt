using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Diagnostics;

namespace MyProjekt.Data;

//public class DerivedDbContextDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
//{
//    public ApplicationDbContext CreateDbContext(string[] args)
//    {
//        //Debugger.Launch();
//        var configurationBuilder = new ConfigurationBuilder();
//        var configuration = configurationBuilder
//            .SetBasePath(Directory.GetCurrentDirectory())
//            .AddJsonFile("appsettings.json")
//            .AddUserSecrets<Program>()
//            .AddEnvironmentVariables()
//            .Build();

//        var connectionString = configuration.GetConnectionString("DefaultConnection");

//        var dbContextOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
//            .UseSqlServer(connectionString);

//        return new ApplicationDbContext(dbContextOptionsBuilder.Options);
//    }
//}
