using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace qa.Models {
  public abstract class Question {

    public int Id { get; set; }

    public int Ordinal { get; set; } // = 100;

    [Required]
    public string Title { get; set; }

    public Question() {
      Ordinal = 100;
    }
  }
}