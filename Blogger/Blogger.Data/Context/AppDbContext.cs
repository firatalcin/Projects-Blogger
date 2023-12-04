using Blogger.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Blogger.Data.Context
{
	public class AppDbContext : DbContext
	{
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		public DbSet<Article> Articles { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
