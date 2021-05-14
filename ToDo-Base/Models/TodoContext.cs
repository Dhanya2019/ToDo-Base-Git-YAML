using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem
                {
                    Id = 1,
                    Name = "Pay Property Tax1",
                    IsComplete = true
                }, new TodoItem
                {
                    Id = 2,
                    Name = "Pay Property Tax2",
                    IsComplete = true
                },
                 new TodoItem
                 {
                     Id = 3,
                     Name = "Pay Property Tax3",
                     IsComplete = false
                 },
                  new TodoItem
                  {
                      Id = 4,
                      Name = "Pay Property Tax4",
                      IsComplete = false
                  }
                );
        }
    }
}
