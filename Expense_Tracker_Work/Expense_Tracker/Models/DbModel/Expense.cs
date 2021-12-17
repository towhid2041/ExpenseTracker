using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Expense_Tracker.Models.DbModel
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [Required, Display(Name = "Expense Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExpanseDate { get; set; }
        [Required, Column(TypeName = "decimal")]
        public decimal Amount { get; set; }
        [Display(Name = "Expense")]
        [Range(1, int.MaxValue, ErrorMessage = "You must choose a category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}