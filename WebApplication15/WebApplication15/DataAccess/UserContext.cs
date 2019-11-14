using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication15.Models;

namespace WebApplication15.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options):base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Login = "admin",
                    Password = "12345"
                },
                new User 
                {
                    Login = "user1",
                    Password = "45678"
                });
        }
    }
}
