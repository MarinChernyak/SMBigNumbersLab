using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models
{
    public class BNAction
    {
        public BNAction(String name, String controller)
        {
            Name = name;
            Controller = controller;
        }
        public String Name { get; set; }
        public String Controller { get; set; }
    }
    public class BNActions : List<BNAction>
    {
        public BNActions()
        {
            Add(new BNAction("Summation", "Summation"));
            Add(new BNAction("Addition", "Addition"));
            Add(new BNAction("Substruction", "Substruction"));
            Add(new BNAction("Multiplication", "Multiplication"));
            Add(new BNAction("Power", "Power"));
            Add(new BNAction("Fibonacci", "Fibonacci"));
            Add(new BNAction("Arithmetic Progression", "AProgression"));

        }
    }
}