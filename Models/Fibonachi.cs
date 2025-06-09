
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models
{
    public class Fibonacci : Entry1
    {

        [Required(ErrorMessage = "Index number required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "The entry must be numeric")]
        public override string Number1 { get; set; }
        public override string lblNumber1 { get { return "Enter a serial number of the series"; } }
        
        public void GetResult()
        {
            Number numPrev = new Number("1");
            Number numNext = new Number("1");
            Number Member = new Number("1");
            Number Index = new Number("2");
            Number MemberNumber = new Number(Number1);
            int ind = 1;
            while (Index < MemberNumber)
            {
                ind++;
                Member = numNext + numPrev;
                Index++;
  
                numPrev = numNext;
                numNext = Member;
                
            }
            Result = Member.ToStringFormated();
        }
    }
}