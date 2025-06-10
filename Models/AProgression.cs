using SMBigNumbersLab.BL;
using SMBigNumbersLab2.bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models
{
    public class AProgression :Progression
    {
        public override string ProgrKind { get { return "Ariphmetic Progression"; } }
        public override void GetResult()
        {
            ProgressionA bl = new ProgressionA(First,CommonDiff,NumSteps);
            bl.GetProgressionResult();
            Last = bl.Last;
            Sum = bl.Sum;
        }
    }
}