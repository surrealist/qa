namespace qa.Web.Migrations {
  using qa.Models;
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

  internal sealed class Configuration : DbMigrationsConfiguration<qa.Web.DataAccess.QuestionaireDb> {
    public Configuration() {
      AutomaticMigrationsEnabled = true;
    }

    protected override void Seed(qa.Web.DataAccess.QuestionaireDb context) {
      context.Questionaires.AddOrUpdate(
        q => q.Title,
        new Questionaire {
          Title = "Demo I",
          DateStart = new DateTime(2015, 11, 1),
          DateEnd = new DateTime(2015, 11, 30),
          DateCreated = DateTime.Today,
          Creator = "demo"
        }, new Questionaire {
          Title = "Demo II",
          DateStart = new DateTime(2015, 11, 10),
          DateEnd = new DateTime(2015, 12, 10),
          DateCreated = DateTime.Today,
          Creator = "demo"
        }, new Questionaire {
          Title = "Demo III",
          DateStart = new DateTime(2015, 10, 1),
          DateEnd = new DateTime(2015, 12, 31),
          DateCreated = DateTime.Today,
          Creator = "demo"
        });

      //  This method will be called after migrating to the latest version.

      //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
      //  to avoid creating duplicate seed data. E.g.
      //
      //    context.People.AddOrUpdate(
      //      p => p.FullName,
      //      new Person { FullName = "Andrew Peters" },
      //      new Person { FullName = "Brice Lambson" },
      //      new Person { FullName = "Rowan Miller" }
      //    );
      //
    }
  }
}
