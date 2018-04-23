using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenge
{
    public static class StringExtension
    {
        public static bool CheckPapalindrome(this String str)
        {
            bool result = true;

            for (int i = 0, j = str.Length - 1; i < j; i++,j-- )
            {
                while((str[i] == ' ' )|| (str[i] == ',')) i++;
                while((str[j] == ' ') || (str[j] == ',')) j--;
                
                if (str.ToUpper()[i] != str.ToUpper()[j])
                {
                    result = false;
        
                }
            }

            return result;

        }
    }
}
