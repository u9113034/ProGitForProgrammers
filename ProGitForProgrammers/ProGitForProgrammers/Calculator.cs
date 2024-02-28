using System;
using System.Reflection.Metadata.Ecma335;

namespace ProGitForProgrammers
{
	public class Class1
	{
		class Calculator
		{
			public int Add(int left, int right)
			{
				return left + right;
			}

			public int Subtract(int left, int right)
			{
				return left - right;
			}

			public int Multiply(int left, int right)
			{
				return left * right;
			}

			public int Divide(int left, int right)
			{
				return left / right;
			}
		}
	}
}