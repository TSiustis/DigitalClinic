using DigitalClinic.Shared.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DigitalClinic.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ClinicUser>
    {
        public ApplicationDbContext(
           DbContextOptions options,
           IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Clinic> Clinic { get; set; }
        public DbSet<ClinicUser> ClinicUsers { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
    }
}
