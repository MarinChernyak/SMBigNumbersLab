using SMBigNumbersLab.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMBigNumbersLab.Models
{
    public class Number : List<int>
    {
        public int IsPositive { get; set; }
        public bool IsValid { get; set; }
        public Number(String sNum = "")
        {
            IsPositive = 1;
            if (ValidateEntry(sNum))
            {

                for (int i = 0; i < sNum.Length; ++i)
                {
                    Int32 iVal = 0;
                    String sVal = sNum[i].ToString();
                    bool bRez = Int32.TryParse(sVal, out iVal);
                    if (Int32.TryParse(sVal, out iVal))
                    {
                        Add(iVal);
                    }
                    else
                    {
                        throw new ParsingException();
                    }
                }
            }
        }
        public Number(Number num2)
        {
            IsPositive = num2.IsPositive;
            if (num2 != null)
            {
                for (int i = 0; i < num2.Count; ++i)
                {
                    Add(num2[i]);
                }
            }
        }
        public bool ValidateEntry(String sNum)
        {
            IsValid = true;
            if (!String.IsNullOrEmpty(sNum))
            {
                sNum = sNum.Trim();
                for (int i = 0; i < sNum.Length; ++i)
                {
                    String s = sNum[i].ToString();
                    int inum=0;
                    IsValid = int.TryParse(s, out inum);
                    if (!IsValid)
                        break;
                }
            }
            return IsValid;
        }
        // Numbers must be so that it can be devided even. Otherwise
        // the function returns 0
        public static Number operator /(Number Number1, int Number2)
        {
            Number Rez = new Number();
            int d = 0;
            int index=0;
            int iStepNum = 0;
            int iNext = 0;
            if (Number1.Count > 1 || Number1.Count == 1 && Number1[0] >= Number2)
            {
                while (index < Number1.Count)
                {
                    
                    if (int.TryParse(Number1[index].ToString(), out iStepNum))
                    {
                        iNext = d * 10 + iStepNum;
                        if (iNext >= Number2)
                        {
                            d = iNext % Number2;
                            Rez.Add((iNext - d) / Number2);
                        }
                        else
                        {
                            d = iNext;
                            Rez.Add(0);
                        }
                    }


                    index++;
                }
            }
            if (Rez.Count > 0)
            {
                while (Rez[0] == 0)
                {
                    Rez.Remove(0);
                }
            }
            return Rez;
        }
        //For mow I assume that Number2 has 1 digit.
        public static Number operator -(Number Number1, int Number2)
        {
            Number numRez = new Number(Number1);
            DecreaseIndex(numRez, numRez.Count - 1, Number2);
            if (numRez.Count > 0)
            {
                while (numRez[0] == 0)
                {
                    numRez.Remove(0);
                }
            }
            return numRez;
        }
        public static Number operator -(Number Number1, Number Number2)
        {
            Number numRez = null;
            if (Number2 != null && Number1 != null)
            {
                Number num = Number1;
                if (Number2.Count > Number1.Count)
                {
                    Number1 = Number2;
                    Number1.IsPositive = -1;
                    Number2 = num;
                }
                numRez = new Number(Number1);
                int j = Number2.Count - 1;
                for (int i = numRez.Count - 1; i >= 0; i--)
                {
                    if (j < 0)
                        break;

                    DecreaseIndex(numRez, i, Number2[j--]);


                }
                while (numRez[0] == 0)
                {
                    numRez.Remove(0);
                }
            }
            return numRez;
        }
        public static bool operator <(Number Number1, Number Number2)
        {
            bool bRez = false;
            if (Number1.Count < Number2.Count)
                bRez = true;
            else if (Number1.Count == Number2.Count)
            {
                for (int i = 0; i < Number1.Count ; i++)
                {
                    if (Number1[i] < Number2[i])
                    {
                        bRez = true;
                        break;
                    }
                }
            }

            return bRez;
        }
        public static bool operator >(Number Number1, Number Number2)
        {
            bool bRez = false;
            if (Number1.Count > Number2.Count)
                bRez = true;
            else if (Number1.Count == Number2.Count)
            {
                for (int i = 0; i < Number1.Count ; i++)
                {
                    if (Number1[i] > Number2[i])
                    {
                        bRez = true;
                        break;
                    }
                }
            }

            return bRez;
        }
        public static Number operator +(Number Number1, Number Number2)
        {
            Number numRez = null;
            if (Number2 != null && Number1 != null)
            {
                Number num = Number1;
                if (Number2.Count > Number1.Count)
                {
                    Number1 = Number2;
                    Number2 = num;
                }
                int iNum2 = Number2.Count - 1;
                numRez = new Number(Number1);
                int iShift = 0;
                for (int iS1 = numRez.Count - 1; iS1 >= 0; iS1 = iS1 - 1)
                {

                    if (iNum2 >= 0)
                    {
                        iShift = UpdateIndex(numRez, iS1 + iShift, Number2[iNum2]);
                      
                    }
                    iNum2--;
                }

            }
            return numRez;
        }
        public static Number operator *(Number Number1, Number Number2)
        {
            Number numRez = null;
            if (Number2 != null && Number1 != null)
            {
                numRez = new Number("");
                int ShiftRez = 0;

                for (int iS1 = Number1.Count - 1; iS1 >= 0; iS1--)
                {

                    int j = 0;
                    int iNum1 = Number1[iS1];
                    for (int iS2 = Number2.Count - 1; iS2 >= 0; iS2--, j++)
                    {
                        int iRezIndex = numRez.Count - 1 - ShiftRez;
                        int iNum2 = Number2[iS2];
                        int iRez = iNum1 * iNum2;
                        int icurIndex = iRezIndex - j;


                        UpdateIndex(numRez, icurIndex, iRez);



                    }
                    ShiftRez++;
                }

            }
            return numRez;
        }
        //Power
        public static Number operator ^(Number Base, Number Power)
        {
            Number numRez = null;

            if (Base != null && Power != null)
            {
                numRez = new Number("1");
                Number copyPower = new Number(Power);

                while (!copyPower.IsZero())
                {
                    copyPower--;
                    numRez = numRez * Base;
                }


            }
            return numRez;
        }
        public bool IsZero()
        {
            bool bIsZero = true;
            for (int i = 0; i < Count; ++i)
            {
                if (this[i] > 0)
                {
                    bIsZero = false;
                    break;
                }

            }
            return bIsZero;
        }

        public static Number operator --(Number number)
        {
            DecreaseIndex(number, number.Count - 1);

            return number;
        }
        public static Number operator ++(Number number)
        {
            UpdateIndex(number, number.Count - 1,1);

            return number;
        }
        protected static void DecreaseIndex(Number number, int index)
        {
            if (number != null)
            {
                if (index < number.Count && index >= 0 && number[index] > 0)
                {
                    number[index]--;
                }
                else if (index < number.Count && index >= 0 && number[index] == 0)
                {
                    number[index] = 9;
                    DecreaseIndex(number, index - 1);
                }
            }
        }
        protected static void DecreaseIndex(Number number, int index, int Value = 1)
        {
            if (number != null && index >= 0)
            {

                number[index] -= Value;
                if (number[index] < 0)
                {
                    number[index] += 10;
                    DecreaseIndex(number, index - 1);
                }

            }
        }
        protected static int UpdateIndex(Number number, int index, int Value)
        {
            int iShift = 0;
            int iAddNum = 0;
            if (index >= 0 && index < number.Count)
            {
                number[index] += Value;
                if (number[index] >= 10)//&& index == 0)
                {

                    iAddNum = (int)number[index] / 10;
                    number[index] = number[index] - 10 * iAddNum;
                    if (iAddNum > 0)
                    {
                        iShift=UpdateIndex(number, index - 1, iAddNum);
                    }
                }

            }
            else if (index < 0)
            {
                int icount = 0;
                for (; index < 0; ++index)
                {
                    number.Insert(0, 0);
                    icount++;
                }
                UpdateIndex(number, 0, Value);
                iShift = icount;
            }
            else if (index >= number.Count)
            {
                for (; index >= number.Count; index--)
                {
                    number.Add(0);
                }
                UpdateIndex(number, number.Count - 1, Value);
            }
            return iShift;
        }
        public override String ToString()
        {
            String sOut = String.Empty;
            if (IsPositive < 0)
                sOut = "-";
            for (int i = 0; i < Count; ++i)
            {
                sOut += this[i].ToString();
            }

            return sOut;
        }
        public virtual String ToStringFormated()
        {
            int iNumGroupsInLine = 0;
            int NUM_GROUP_LINE = 15;
            int iShift1 = Count % 3;
            String sOut = String.Empty;
            int iGroupCount = 0;
            if (IsPositive < 0)
                sOut = "-";
            for (int i = 0; i < Count; ++i)
            {
                if (((i == iShift1 && iShift1>0) || iGroupCount==3)&&i!=Count-1)
                {
                    sOut += ",";
                    iGroupCount = 0;
                    iNumGroupsInLine++;
                }
                if (iNumGroupsInLine == NUM_GROUP_LINE)
                {
                    sOut += "\n";
                    iNumGroupsInLine = 0;
                }
   
                sOut += this[i].ToString();
                iGroupCount++;
            }

            return sOut;
        }


    }
}