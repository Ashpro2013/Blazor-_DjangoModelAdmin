using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DjangoModelAdmin.Model;

namespace DjangoModelAdmin.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<DjangoModelAdmin.Model.Departments> Departments { get; set; } = default!;
        public DbSet<DjangoModelAdmin.Model.Doctors> Doctors { get; set; } = default!;
        public DbSet<DjangoModelAdmin.Model.Bookings> Bookings { get; set; } = default!;
    }
}
