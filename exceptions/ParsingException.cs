using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Exceptions
{
    public class ParsingException : Exception
    {
        public override string Message
        {
            get
            {
                return "Error parsing of a provided number! There must be found non numeric symbols.";
            }
        }
        public override string? HelpLink
        {
            get => base.HelpLink;
            set
            {
                base.HelpLink = value;
            }
        }
    }
}