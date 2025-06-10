
using SMBigNumbersLab.Models;
using System.Linq;

namespace SMBigNumbersLab2.bl
{
    public class ProgressionG : ProgressionBase
    {
        public ProgressionG(string sFirst, string sCommonDiff, string NumSteps)
            : base(sFirst, sCommonDiff, NumSteps)
        {

        }
        public ProgressionG(Number First, Number CommonDiff, Number NumSteps)
           : base(First, CommonDiff, NumSteps)
        {

        }
        public override void GetProgressionResult()
        {
            _Last = new Number();
            _Last = _First *(_CommonDiff^(_NumSteps - 1));
            Number int1 = new Number("1");
            Number int2 = new Number("2");

            Number n1 = _CommonDiff ^ _NumSteps;
            n1 =  n1- int1;
            _Sum = _First * n1;
            int cdiff = Convert.ToInt32(( _CommonDiff- int1).ToString());
            _Sum = _Sum / cdiff;
            
        }
    }
}
