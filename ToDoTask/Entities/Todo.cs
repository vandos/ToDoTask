using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ToDoTask.Entities
{
    public class Todo : Entity
    {
        public String Task { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Day { get; set; }

        public String Description { get; set; }

        public ImportantCheck Important { get; set; }

        public bool Done { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }

    public enum ImportantCheck
    {
        Важное,
        Второстепенное,
        Бессмысленное
    }
}