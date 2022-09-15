using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using MyProjekt.Models;

namespace MyProjekt.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Categoriy> Categoriys { get; set; }
}
