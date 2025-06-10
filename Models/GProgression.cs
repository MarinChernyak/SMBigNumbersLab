using SMBigNumbersLab.BL;
using SMBigNumbersLab.Models;
using SMBigNumbersLab2.bl;

namespace SMBigNumbersLab2.Models
{
    public class GProgression : Progression
    {
        public override string ProgrKind { get { return "Geometric progression Progression"; } }
        public override void GetResult()
        {
            ProgressionG bl = new ProgressionG(First, CommonDiff, NumSteps);
            bl.GetProgressionResult();
            Last = bl.Last;
            Sum = bl.Sum;
        }
    }
}
