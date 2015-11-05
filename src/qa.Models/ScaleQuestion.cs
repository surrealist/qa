using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace qa.Models {
  public class ScaleQuestion : Question {

    public int Minimum { get; set; }
    public int Maximum { get; set; }

    public string MinimumText { get; set; }
    public string MaximumText { get; set; }

    public ScaleQuestion() {

      Minimum = 1;
      Maximum = 5;

      MinimumText = MaximumText = string.Empty;
    }
  }
}