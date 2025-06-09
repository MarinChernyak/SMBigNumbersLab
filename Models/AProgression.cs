using SMBigNumbersLab.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models
{
    public class AProgression :Progression
    {
        public override String ProgrKind { get { return "Ariphmetic Progression"; } }
        public override void GetResult()
        {
            ProgressionA bl = new ProgressionA(First,CommonDiff,NumSteps);
            bl.GetProgressionResult();
            Last = bl.Last;
            Sum = bl.Sum;
        }
    }
}