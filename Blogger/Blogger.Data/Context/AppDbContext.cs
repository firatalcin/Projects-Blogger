﻿using Blogger.Entity.Entities;
using Microsoft.EntityFrameworkCore;

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

        public DbSet<Article> Articles { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
