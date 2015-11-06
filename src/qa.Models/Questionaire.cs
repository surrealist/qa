using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace qa.Models {

  public class Questionaire {

    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string Creator { get; set; }

    [Column(TypeName = "datetime2")]
    public DateTime DateCreated { get; set; }

    [Column(TypeName = "datetime2")]
    public DateTime DateStart { get; set; }

    [Column(TypeName = "datetime2")]
    public DateTime DateEnd { get; set; }

    public virtual ICollection<Section> Sections { get; set; }

    public Questionaire() {
      Sections = new HashSet<Section>();

      Creator = Environment.UserName;
      DateCreated = DateStart = DateTime.Today;
      DateEnd = DateTime.Today.AddDays(3);
    }

    public bool IsActiveToday {
      get {
        var d = DateTime.Today;
        return DateStart <= d && d <= DateEnd;
      }
    }
  }

}