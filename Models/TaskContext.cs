using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoListWeb.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}