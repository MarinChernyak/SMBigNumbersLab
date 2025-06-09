using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SMBigNumbersLab.Models.FriendlyNumbs;
using SMBigNumbersLab.Models;

namespace SMBigNumbersLab.BL
{
    public class FriendlyNumbersSeeker
    {
        protected Number _startNumber;
        protected int FriendsPairsNumber;
        protected FriendlyNumbersCollection _collection;

        public FriendlyNumbersSeeker(Number start, int NumberPairs)
        {
            _startNumber = start;
            FriendsPairsNumber = NumberPairs;
        }
        public void StartSearch()
        {


        }
        protected void GetDeviders(FriendlyNumber number)
        {

        }
    }
}