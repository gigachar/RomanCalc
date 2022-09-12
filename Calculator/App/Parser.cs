using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.App
{
	// public class Parser
	// {
	// 	static Dictionary<string, int> values = new Dictionary<string, int>()
	// 	{
	// 		{ "M", 1000 },
	// 		{ "CM", 900 },
	// 		{ "D", 500 },
	// 		{ "CD", 400 },
	// 		{ "C", 100 },
	// 		{ "XC", 90 },
	// 		{ "L", 50 },
	// 		{ "XL", 40 },
	// 		{ "X" , 10},
	// 		{ "IX", 9 },
	// 		{ "V", 5 },
	// 		{ "IV", 4 },
	// 		{ "I", 1}
	// 	};
	//
	// 	public static int ToArabic(string roman)
	// 	{
	// 		int result = 0;
	// 		for(int i=0;i<roman.Length;)
	// 		{
	// 			char char1 = roman[i];
	// 			char char2 = '-';
	// 			if (i < roman.Length - 1)
	// 			{
	// 				char2 = roman[i + 1];
	// 			}
	// 			string _2chars = char1.ToString() + char2.ToString();
	// 			if(values.ContainsKey(_2chars))
	// 			{
	// 				result += values[_2chars];
	// 				i += 2;
	// 			}
	// 			else
	// 			{
	// 				result += values[char1.ToString()];
	// 				i++;
	// 			}
	//
	// 		}
	// 		return result;
	// 	}
	// 	public static string ToRoman(int arabic)
	// 	{
	// 		return "";
	// 	}
	// }
	
	
	public class RomanNumber
    {
        // public static Int32 Parse(String number)
        // {
        //     /* int result = 0;
        //     for (int i = 0; i < number.Length; i++)
        //     {
        //         char c = number[i];
        //         char next;
        //         if (i < number.Length - 1)
        //         {
        //             next = number[i + 1];
        //         }
        //         else
        //         {
        //             next = ' ';
        //         }
        //         switch (c)
        //         {
        //             case 'M':
        //                 result += 1000;
        //                 break;
        //             case 'D':
        //                 result += 500;
        //                 break;
        //             case 'C':
        //                 if (next == 'M')
        //                 {
        //                     result += 900;
        //                     i++;
        //                 }
        //                 else if (next == 'D')
        //                 {
        //                     result += 400;
        //                     i++;
        //                 }
        //                 else result += 100;
        //                 break;
        //             case 'L':
        //                 result += 50;
        //                 break;
        //             case 'X':
        //                 if (next == 'L')
        //                 {
        //                     result += 40;
        //                     i++;
        //                 }
        //                 else if (next == 'C')
        //                 {
        //                     result += 90;
        //                     i++;
        //                 }
        //                 else result += 10;
        //                 break;
        //             case 'V':
        //                 result += 5;
        //                 break;
        //             case 'I':
        //                 if (next == 'V')
        //                 {
        //                     result += 4;
        //                     i++;
        //                 }
        //                 else if (next == 'X')
        //                 {
        //                     result += 9;
        //                     i++;
        //                 }
        //                 else result += 1;
        //                 break;
        //         }
        //     }
        //     return result;
        //     */
        //
        //     char[] digits = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        //     int[] digitValues = { 1, 5, 10, 50, 100, 500, 1000 };
        //
        //     int pos = 1;
        //     int ind = Array.IndexOf(digits, number[pos]);
        //     if (ind == -1) throw new ArgumentException($"Invalid digit '{number[pos - 1]}'");
        //         int res = digitValues[ind];
        //     ind = Array.IndexOf(digits, number[pos - 1]);
        //     if (ind == -1) throw new ArgumentException($"Invalid digit '{number[pos - 1]}'");
        //     if (digitValues[ind] < res) res -= digitValues[ind];
        //         res += digitValues[ind];
        //     return res;
        //
        // }
        public static Int32 Parse(String str)
        {
            if (str == String.Empty || str==null) {throw new ArgumentException("Invalid format");}
            if (str.Any(Char.IsWhiteSpace)) {throw new ArgumentException(nameof(str));}
                char[] digits = { 'N', 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
                int[] digitValues = { 0, 1, 5, 10, 50, 100, 500, 1000 };
                

                if(str.Contains('N') && str.Length>1)
			    {
				    throw new ArgumentException($"Invalid format");
			    }

                int pos = str.Length - 1;  // позиція останньої цифри у str
                int ind = Array.IndexOf(digits, str[pos]);  // індекс цифри у масиві
                if(ind == -1)  // цифри немає у масиві
                {
                    throw new ArgumentException($"Invalid digit '{str[pos]}'");
                }
                int nextDigitValue = digitValues[ind];
                int res = nextDigitValue;  // остання цифра завжди з +

                while (pos > 0)
                {
                    pos -= 1;
                    ind = Array.IndexOf(digits, str[pos]);  // передостання цифра
                    if (ind == -1)  // цифри немає у масиві
                    {
                        throw new ArgumentException($"Invalid digit '{str[pos]}'");
                    }
                    if (digitValues[ind] < nextDigitValue) res -= digitValues[ind];
                    else res += digitValues[ind];
                    nextDigitValue = digitValues[ind];
                }
                return res;
            
          
        }
           
    }
}
