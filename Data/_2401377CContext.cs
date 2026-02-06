using _2401377C.Configurations.Entities;
using _2401377C.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _2401377C.Data
{
    public class _2401377CContext(DbContextOptions<_2401377CContext> options) : IdentityDbContext<_2401377CUser>(options)
    {
        public DbSet<_2401377C.Domain.MyTask> MyTask { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new MyTaskSeed());

            builder.ApplyConfiguration(new RoleSeed());

            builder.ApplyConfiguration(new UserSeed());

            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}
