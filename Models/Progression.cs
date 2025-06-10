using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models
{
    public abstract class Progression 
    {
        public virtual string ProgrKind { get { return ""; } }


        public string? Last { get; set; }
        public virtual string lblLast { get { return "Last member:"; } }

        public string? Sum { get; set; }
        public virtual string lblSum { get { return "Sum of progression:"; } }

        public string lblComDiff { get { return "Common Difference: "; } }
        public string lblFirst { get { return "First memeber: "; } }
        public string lblNumSteps { get { return "Number of steps: "; } }

        [Required(ErrorMessage = "First member required!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "A value must be numeric")]
        public string First { get; set; } 

        [Required(ErrorMessage = "Common difference required!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "A value must be numeric")]
        public string CommonDiff { get; set; }        

        [Required(ErrorMessage = "Number steps is required!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "A value must be numeric")]
        public string NumSteps { get; set; }

        public abstract void GetResult();
    }
}