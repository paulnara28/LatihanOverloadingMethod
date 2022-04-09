using System;

namespace LatihanOverloadingMethod
{
	public class Numbers
	{
		public int FindMinimum(int number1, int number2)
		{
			return  number2;
		}
		public int FindMinimum(int number1, int number2, float number3)
		{
			return number2;
		}
		public int FindMaximum(int number1, int number2)
		{
			return number1;
		}
		public int FindMaximum(int number1, int number2, int number3)
		{
			return number3;
		}
	}
}
