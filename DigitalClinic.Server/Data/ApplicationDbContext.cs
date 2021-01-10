using DigitalClinic.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace DigitalClinic.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<ClinicUser> ClinicUsers { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
    }
}
