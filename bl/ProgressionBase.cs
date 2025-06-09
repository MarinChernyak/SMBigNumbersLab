using SMBigNumbersLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.BL
{
    public abstract class ProgressionBase
    {
        protected Number _First ;
        protected Number _CommonDiff ;
        protected Number _NumSteps ;

        protected Number _Last ;
        protected Number _Sum ;

        public String Last { get { return _Last.ToStringFormated(); } }
        public String Sum { get { return _Sum.ToStringFormated(); } }

        public ProgressionBase(String sFirst, String sCommonDiff, String NumSteps)
        {
            _First = new Number(sFirst);
            _CommonDiff = new Number(sCommonDiff);
            _NumSteps = new Number(NumSteps);

            GetProgressionResult();
        }
        public ProgressionBase(Number sFirst, Number sCommonDiff, Number NumSteps)
        {
            _First = new Number(sFirst);
            _CommonDiff = new Number(sCommonDiff);
            _NumSteps = new Number(NumSteps);

            GetProgressionResult();
        }
        public abstract void GetProgressionResult();
    }
}