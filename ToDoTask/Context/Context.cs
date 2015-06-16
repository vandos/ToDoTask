using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoTask.Entities;

namespace ToDoTask.Context
{
    public class Context : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }

        public static Context Create()
        {
            return new Context();
        }

        public Context() : base("ToDoTask.Context.Context") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SetupTodo(modelBuilder);
            SetupUser(modelBuilder);
            SetupUserTodoRelation(modelBuilder);
        }

        private void SetupTodo(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .HasKey(x => x.Id)
                .ToTable("Todos");

            modelBuilder.Entity<Todo>()
                .Property(x => x.Task)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Todo>()
                .Property(x => x.Important)
                .IsRequired();

            modelBuilder.Entity<Todo>()
                .Property(x => x.Day)
                .IsRequired();
        }

        private void SetupUser(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(x => x.Id)
                .ToTable("Users");
        }

        private void SetupUserTodoRelation(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .HasRequired<User>(x => x.User)
                .WithMany(x => x.Todos)
                .HasForeignKey(x => x.UserId);
        }
    }
}