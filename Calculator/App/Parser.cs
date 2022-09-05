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
		static Dictionary<string, int> values = new Dictionary<string, int>()
		{
			{ "M", 1000 },
			{ "CM", 900 },
			{ "D", 500 },
			{ "CD", 400 },
			{ "C", 100 },
			{ "XC", 90 },
			{ "L", 50 },
			{ "XL", 40 },
			{ "X" , 10},
			{ "IX", 9 },
			{ "V", 5 },
			{ "IV", 4 },
			{ "I", 1}
		};

		public static int ToArabic(string roman)
		{
			int result = 0;
			for(int i=0;i<roman.Length;)
			{
				char char1 = roman[i];
				char char2 = '-';
				if (i < roman.Length - 1)
				{
					char2 = roman[i + 1];
				}
				string _2chars = char1.ToString() + char2.ToString();
				if(values.ContainsKey(_2chars))
				{
					result += values[_2chars];
					i += 2;
				}
				else
				{
					result += values[char1.ToString()];
					i++;
				}

			}
			return result;
		}
		public static string ToRoman(int arabic)
		{
			return "";
		}
	}
}
