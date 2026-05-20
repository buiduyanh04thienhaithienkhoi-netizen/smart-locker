using Microsoft.EntityFrameworkCore;
using SmartLocker.API.Models;
using System.Data;

namespace SmartLocker.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options
        ) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<AccessLog> AccessLogs { get; set; }

        public DbSet<FaceTemplate> FaceTemplates { get; set; }
    }
}