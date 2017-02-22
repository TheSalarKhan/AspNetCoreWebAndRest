using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Application.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
    	public virtual DbSet<Users> User { get; set; }   
    	
    	// This constructor is used by EntityFramework for code first migrations.
    	public ApplicationDbContext() : base(
            new DbContextOptionsBuilder<DbContext>()
            .UseSqlServer("Server=localhost;Database=your_db;User=your_user;Password=your_password;").Options) {


        }
        
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
