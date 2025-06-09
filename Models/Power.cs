
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models
{
    public class Power : Entry2
    {

        public override string lblNumber1 { get { return "Base of power: "; } }
        public override string lblNumber2 { get { return "Exponent: "; } }

        [Required(ErrorMessage = "Base of power required!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Entered must be numeric")]
        public override string Number1 { get; set; }

        [Required(ErrorMessage = "Exponent required!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Entered must be numeric")]
        public override string Number2 { get; set; }

    }
}

