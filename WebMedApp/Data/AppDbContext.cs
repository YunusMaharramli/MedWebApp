using Microsoft.EntityFrameworkCore;
using WebMedApp.Entities;

namespace WebMedApp.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Student> Students => Set<Student>();
}
