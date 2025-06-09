using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models.FriendlyNumbs
{
    public class DevideCriterionResponse
    {
        public bool IsDevider { get; set; }
        public String Msg { get; set; }
    }
    public abstract class DevideCriterionBase
    {
        public DevideCriterionResponse response;
        protected Number TestNumber;
        public DevideCriterionBase(Number testNumber)
        {
            TestNumber = testNumber;
            response = new DevideCriterionResponse();
            response.IsDevider = false;
            response.Msg = "It is not a devider";
            CheckNumber();
            
        }
        protected abstract void CheckNumber();
    }

    public class DevideCriterion2 : DevideCriterionBase
    {
        public DevideCriterion2(Number testNumber)
            :base(testNumber)
        {
            
        }
        protected override void CheckNumber()
        {
            int iLast = TestNumber[TestNumber.Count - 1];
            if (iLast % 2 == 0)
            {
                response.IsDevider = true;
                response.Msg = "This number can be devided for 2";
            }
        }
    }
    public class DevideCriterion3 : DevideCriterionBase
    {
        public DevideCriterion3(Number testNumber)
            : base(testNumber)
        {

        }
        protected override void CheckNumber()
        {
            int iSum = 0;
            foreach (int index in TestNumber)
            {
                iSum += index;
            }
            if (iSum % 3 == 0)
            {
                response.IsDevider = true;
                response.Msg = "This number can be devided for 3";
            }
        }
    }
    public class DeviderWorker
    {
    }
}