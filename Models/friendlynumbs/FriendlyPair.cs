using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models.FriendlyNumbs
{
    public class FriendlyPair
    {
        public FriendlyNumber Friend1
        {
            get;
            set;
        }

        public FriendlyNumber Friend2
        {
            get;
            set;
        }
        public FriendlyPair(FriendlyNumber num1, FriendlyNumber num2)
        {
            Friend1 = num1;
            Friend2 = num2;
        }
    }
}