using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class Status
    {
        public string StatusId { get; set; }
        public string StatusName { get; set; }
    }
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a sprint number")]
        public string SprintNumber { get; set; }

        [Required(ErrorMessage = "Please enter a point value")]
        [Range(1,5)]
        public string PointValue { get; set; }

        [Required(ErrorMessage = "Please enter a status")]
        public string StatusId { get; set; }
        public string StatusName { get; set; }
    }

    public class ToDoContext : DbContext
    {
        //Constructor injection
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options){ }

        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "toDo", StatusName = "To Do"},
                new Status { StatusId = "inProgress", StatusName="In Progress"},
                new Status { StatusId = "qa", StatusName = "Quality Assurance" },
                new Status { StatusId = "done", StatusName = "Done" }
                );
        }
    }
}
