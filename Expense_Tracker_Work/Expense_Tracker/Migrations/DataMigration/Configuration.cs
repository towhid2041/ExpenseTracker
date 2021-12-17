namespace Expense_Tracker.Migrations.DataMigration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Expense_Tracker.Models.Context.ExpenseDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\DataMigration";
        }

        protected override void Seed(Expense_Tracker.Models.Context.ExpenseDbContext context)
        {

        }
    }
}
