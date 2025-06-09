using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models.FriendlyNumbs
{
    public class FriendlyNumbersCollection:List<FriendlyPair>
    {
        public void AddPair(FriendlyNumber num1, FriendlyNumber num2)
        {
            Add(new FriendlyPair(num1, num2));
        }
    }
}