using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace qa.Models {

  public class Section {

    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string Description { get; set; }

    public int Ordinal { get; set; }

    public virtual ICollection<Question> Questions { get; set; }

    public Section() {
      Questions = new HashSet<Question>();
      Ordinal = 0;
    }
  }

}