using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class FormatChecker
    {
        public bool IsValid(string mobileNumber)
        {
            if (mobileNumber.Length == 11 && mobileNumber[0]=='0' && mobileNumber[1]=='1')
            {
                for (int i = 0; i < mobileNumber.Length; i++)
                {
                    if(!char.IsDigit(mobileNumber[i]) || char.IsWhiteSpace(mobileNumber[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
            
        }
    }
}
