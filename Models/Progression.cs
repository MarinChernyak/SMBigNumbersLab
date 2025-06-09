using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models
{
    public abstract class Progression 
    {
        public virtual String ProgrKind { get { return ""; } }


        public String Last { get; set; }
        public virtual String lblLast { get { return "Last member:"; } }

        public String Sum { get; set; }
        public virtual String lblSum { get { return "Sum of progression:"; } }

        public String lblComDiff { get { return "Common Difference: "; } }
        public String lblFirst { get { return "First memeber: "; } }
        public String lblNumSteps { get { return "Number of steps: "; } }

        [Required(ErrorMessage = "First member required!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "A value must be numeric")]
        public String First { get; set; } 

        [Required(ErrorMessage = "Common difference required!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "A value must be numeric")]
        public String CommonDiff { get; set; }        

        [Required(ErrorMessage = "Number steps is required!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "A value must be numeric")]
        public String NumSteps { get; set; }

        public abstract void GetResult();
    }
}