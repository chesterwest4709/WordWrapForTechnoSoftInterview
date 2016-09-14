using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TechnoSoftCW
{
    public static class WrapString
    {
        public static string WrapToLength(string sTarget, int iMaxSegmentLength,bool bBreakBetweenWordsOk=true)
        {
            //string builder used for minimum time/memory
            StringBuilder oSB = new StringBuilder();
            if (bBreakBetweenWordsOk)
            {
                //we can break with a linefeed/carriage return between words
                if ((sTarget.Length < iMaxSegmentLength) || (iMaxSegmentLength <= 0))
                {
                    //if we have nothing to process return the whole line
                     oSB = new StringBuilder(sTarget);
                }
                else
                {
                    //loop through the string moving the index creating strings only
                    //when absolutely needed via substring
                    int iIndex = 0;
                    while (iIndex < sTarget.Length)
                    {
                        while (sTarget.Substring(iIndex, 1) == " ")
                        {
                            iIndex++;
                            if (iIndex==sTarget.Length)
                            {
                                iIndex++;
                                break;
                            }
                        }
                        if (iIndex > sTarget.Length)
                        {
                            //all strings case
                            if (oSB.Length == 0) oSB.Append(sTarget);
                            break;
                        }

                        if (iIndex + iMaxSegmentLength >= sTarget.Length)
                        {
                            oSB.Append(sTarget.Substring(iIndex));
                            break;
                        }
                        else
                        {
                            oSB.Append(sTarget.Substring(iIndex, iMaxSegmentLength) + Environment.NewLine);
                            iIndex += iMaxSegmentLength;
                        }
                    }
                }
            }
            else
            {
                //words cannot be broken up
                if (iMaxSegmentLength > 0)
                {
                    string[] aWords = sTarget.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (aWords.Length > 0)
                    {
                        StringBuilder oSBtemp = new StringBuilder();

                        for (int I = 0; I < aWords.Length; I++)
                        {
                            if (oSBtemp.Length + aWords[I].Length > iMaxSegmentLength)
                            {
                                oSB.Append(oSBtemp.ToString());
                                oSB.Append(System.Environment.NewLine);
                                oSBtemp = new StringBuilder();
                            }
                            oSBtemp.Append(aWords[I]);
                            oSBtemp.Append(' ');
                        }
                        if (oSBtemp.Length > 0)
                            oSB.Append(oSBtemp.ToString());
                        oSB = new StringBuilder(oSB.ToString().TrimEnd().Replace(@" "+Environment.NewLine,Environment.NewLine));
                    }
                    else
                        oSB = new StringBuilder(sTarget); //all blanks case
                }
                else
                    oSB = new StringBuilder(sTarget);
            }
                    
            return oSB.ToString();

        }
    }
}
