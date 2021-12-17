using Expense_Tracker.Models.DbModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Expense_Tracker.Models.Context
{
    public class ExpenseDbContext:DbContext
    {
        public ExpenseDbContext() : base("ExpenseTrackerDbContext") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}