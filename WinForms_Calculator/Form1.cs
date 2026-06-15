namespace WinForms_Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CbOperator.SelectedIndex = 0;
		}

		// 安全數字解析
		private bool TryReadNumber(string input, out double number)
		{
			// 允許前後空白；TryParse 能避免格式例外
			return double.TryParse(input?.Trim(), out number);
		}

		private void BtnCaculate_Click(object sender, EventArgs e)
		{
			// 驗證並取得數值
			if (!TryReadNumber(TxtNum1.Text, out double dNum1))
			{
				label_Resault.Text = string.Empty;
				label_ErrorMsg.Text = "輸入錯誤：請在左側輸入有效數字。";
				TxtNum1.Focus();
				TxtNum1.SelectAll();
				return;
			}

			// 驗證並取得數值
			if (!TryReadNumber(TxtNum2.Text, out double dNum2))
			{
				label_Resault.Text = string.Empty;
				label_ErrorMsg.Text = "輸入錯誤：請在右側輸入有效數字。";
				TxtNum2.Focus();
				TxtNum2.SelectAll();
				return;
			}

			string strOp = CbOperator.SelectedItem?.ToString() ?? "+";

			try
			{
				CCalculator calculator = new CCalculator();
				double result = calculator.Calculate(dNum1, dNum2, strOp);
				label_Resault.Text = $"{dNum1} {strOp} {dNum2} = {result}";
				label_ErrorMsg.Text = string.Empty;
			}
			catch (DivideByZeroException)
			{
				label_Resault.Text = string.Empty;
				label_ErrorMsg.Text = "錯誤：除數不能為 0。";
			}
			catch (Exception ex)
			{
				label_Resault.Text = string.Empty;
				label_ErrorMsg.Text = $"未預期錯誤：{ex.Message}";
			}
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			CbOperator.SelectedIndex = 0;
			TxtNum1.Text = string.Empty;
			TxtNum2.Text = string.Empty;
			label_Resault.Text = string.Empty;
			label_ErrorMsg.Text = string.Empty;
		}
	}
}
