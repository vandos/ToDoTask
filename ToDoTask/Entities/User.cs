using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoTask.Entities
{
    public class User : Entity
    {
        public String Username { get; set; }

        public virtual ICollection<Todo> Todos { get; set; }
    }
}