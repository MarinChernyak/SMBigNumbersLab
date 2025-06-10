using SMBigNumbersLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab2.bl
{
    public class ProgressionA : ProgressionBase
    {
         public ProgressionA(string sFirst, string sCommonDiff, string NumSteps)
            :base(sFirst,sCommonDiff,NumSteps)
        {

        }
         public ProgressionA(Number First, Number CommonDiff, Number NumSteps)
            : base(First, CommonDiff, NumSteps)
        {

        }
        public override void GetProgressionResult()
        {
            _Last = new Number();
            _Last = _First + (_NumSteps - 1) * _CommonDiff;

            Number fl = new Number(_First + _Last);
            Number ns = _NumSteps * fl;

            _Sum = (_NumSteps * (_First + _Last)) / 2;
        }
    }
}