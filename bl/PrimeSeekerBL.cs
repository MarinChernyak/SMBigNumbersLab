using SMBigNumbersLab.Models;
using System.Security.Cryptography.X509Certificates;

namespace SMBigNumbersLab2.bl
{
    public class PrimeSeekerBL
    {
        public Number? Result { get;set; }
        protected Number N1 { get; set; }
        protected Number N2 { get; set; }
        protected const ulong LIMIT_RANGE = 18446744073709551615;
        Number LimitRange;
        public PrimeSeekerBL(string num1, string num2)
        {
            N1 = new Number(num1);
            N2 = new Number(num2);
            LimitRange = new Number(LIMIT_RANGE.ToString());
        }
        public string GetResult()
        {
            Result = new Number();
            if(N2<N1)
            {
                Result = N1;
                N1 = N2;
                N2 = Result;
                Result = new Number();
            }
            
            Number halfInt = N2 / 2;
            if(halfInt.IsZero())
            {
                halfInt = (N2 -1) / 2;
            }
            
            if (halfInt < LimitRange)
            {
                int devider = 2;
                int intHalfRange = Convert.ToInt32(halfInt);
                while (devider < intHalfRange)
                {
                    Result = N1 / devider;
                    if (Result.IsZero())
                    {
                        devider++;
                    }
                    else
                    { }
                }

                return Result.ToString();
            }
            else
            {
                return "The range is PathTooLongException big! iterator may cause unperictable time to search.";
            }                
        }
    }
}
