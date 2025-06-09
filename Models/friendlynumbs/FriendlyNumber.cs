using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models.FriendlyNumbs
{
    public class FriendlyNumber :Number
    {
        private List<Number> _lstDeviders;
        private Number _sumDeviders;

        protected List<Number> Deviders
        {
            get
            {
                if (_lstDeviders == null)
                {
                    _lstDeviders = new List<Number>();
                }
                return _lstDeviders;
            }
        }
        protected void GetDeviders()
        {
            Number index = new Number("2");
            Number Limit = this / 2;

            while(index <Limit)
            {


            }
        }
        protected void AddDevider(Number devider)
        {
            _lstDeviders.Add(devider);
            _sumDeviders = _sumDeviders + devider;
        }
        public override String ToStringFormated()
        {
            String sOut = base.ToStringFormated();

            //Show deviders and summ

            return sOut;
        }
    }
}