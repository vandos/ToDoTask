using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoTask.Entities
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}