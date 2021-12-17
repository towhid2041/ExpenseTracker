using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Expense_Tracker.Models.DbModel
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(40), MinLength(2, ErrorMessage = "Minimum length is 2"), Display(Name = "Expense Name")]
        public string CategoryName { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}