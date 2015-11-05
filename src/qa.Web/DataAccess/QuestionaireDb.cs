using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using qa.Models;

namespace qa.Web.DataAccess {
  public class QuestionaireDb : DbContext {

    public DbSet<Questionaire> Questionaires { get; set; }

  }
}