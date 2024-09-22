﻿using Microsoft.EntityFrameworkCore;
using Bulky.Models;



namespace Bulky.DataAccess.Data
{
    public class ApplicationDBContext:DbContext
	{
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
		public DbSet<Category> Categories { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData
				(
				new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
				new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
				new Category { Id = 3, Name = "History", DisplayOrder = 3 }
				);
			base.OnModelCreating(modelBuilder);
		}
	}
}