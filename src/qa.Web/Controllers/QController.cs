using qa.Web.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace qa.Web.Controllers {
  public class QController : Controller {

    private QuestionaireDb db = new QuestionaireDb();
    protected override void Dispose(bool disposing) {
      if (disposing) { db.Dispose(); }
      base.Dispose(disposing);
    }

    /// <summary>
    /// List all questionaires 
    /// 
    /// </summary>
    /// <returns></returns>
    public ActionResult Index(bool? activeOnly) {
      bool isActiveOnly = activeOnly ?? false;

      var query = from q in db.Questionaires
                  select q;

      if (isActiveOnly) {
        var today = DateTime.Today;
        query = query.Where(x => x.DateStart <= today && today <= x.DateEnd);
      }

      return View(query.ToList());
    }
  }
}