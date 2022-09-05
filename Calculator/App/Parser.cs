using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.App
{
	public class Parser
	{
		public static int ToArabic(string roman)
		{

			char[] digits = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
			int[] values = { 1, 5, 10, 50, 100, 500, 1000 };

			int pos = 1;
			int ind = Array.IndexOf(digits, roman[pos]);
			if(ind == -1)
			{
				throw new ArgumentException($"Invalid digit: {roman[pos]}");
			}
			int res = values[ind];

			ind = Array.IndexOf(digits, roman[pos-1]);
			if(ind==-1)	
			{
				throw new ArgumentException($"Invalid digit: {roman[pos]}");
			}
			
			if (values[ind] < res) res -= values[ind];
			else res += values[ind];
			return res;
		}
		public static string ToRoman(int arabic)
		{
			return "";
		}
	}
}
