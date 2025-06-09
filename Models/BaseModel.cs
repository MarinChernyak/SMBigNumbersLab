using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models
{
    public class BaseModel
    {
        public string? Result { get; set; }
        public virtual string lblResult { get { return "Result"; } }

    }
}