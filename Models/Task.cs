using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListWeb.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Author { get; set; }
        //public bool status { get; set; }
        //public DateTime Date { get; set; }
    }
}