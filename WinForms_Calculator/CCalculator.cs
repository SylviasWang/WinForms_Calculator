using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Calculator
{
	//Internal 表示此類別只能給自己專案使用，如果要讓其他專案看到，可以在.csproj中新增設定
	//<ItemGroup>
	//	<InternalsVisibleTo Include = "專案名稱" /> 
	//</ItemGroup >
	internal class CCalculator 
	{
		public double Calculate(double dNum1, double dNum2, string strOp)
		{
			double dResult = 0;

			switch (strOp)
			{
				case "+":
					dResult = dNum1 + dNum2;
					break;
				case "-":
					dResult = dNum1 - dNum2;
					break;
				case "*":
					dResult = dNum1 * dNum2;
					break;
				case "/":
					if (dNum2 != 0)
					{
						dResult = (double)(dNum1 / dNum2);
					}
					else
					{
						throw new DivideByZeroException();
					}
					break;
				case "^":
					dResult = Math.Pow(dNum1, dNum2);
					break;
				case "%":
					if (dNum2 != 0)
					{
						dResult = (double)(dNum1 % dNum2);
					}
					else
					{
						throw new DivideByZeroException();
					}
					break;
			}

			return dResult;
		}
	}
}
