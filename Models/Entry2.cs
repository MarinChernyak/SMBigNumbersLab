
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models
{
    public class Entry2 : Entry1
    {

        [Required(ErrorMessage = "Please eneter a number")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "The entry must be numeric")]
        public virtual string Number2 { get; set; }

        public virtual string lblNumber2 { get { return "Number 2: "; } }

    }
}