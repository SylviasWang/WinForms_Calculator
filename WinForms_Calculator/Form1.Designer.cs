namespace WinForms_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			TxtNum1 = new TextBox();
			TxtNum2 = new TextBox();
			CbOperator = new ComboBox();
			BtnCaculate = new Button();
			BtnClear = new Button();
			label1 = new Label();
			label2 = new Label();
			label_Resault = new Label();
			label_ErrorMsg = new Label();
			SuspendLayout();
			// 
			// TxtNum1
			// 
			TxtNum1.BorderStyle = BorderStyle.FixedSingle;
			TxtNum1.Location = new Point(37, 34);
			TxtNum1.Name = "TxtNum1";
			TxtNum1.Size = new Size(125, 27);
			TxtNum1.TabIndex = 0;
			// 
			// TxtNum2
			// 
			TxtNum2.BorderStyle = BorderStyle.FixedSingle;
			TxtNum2.Location = new Point(340, 34);
			TxtNum2.Name = "TxtNum2";
			TxtNum2.Size = new Size(125, 27);
			TxtNum2.TabIndex = 1;
			// 
			// CbOperator
			// 
			CbOperator.BackColor = SystemColors.Window;
			CbOperator.DropDownStyle = ComboBoxStyle.DropDownList;
			CbOperator.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
			CbOperator.FormattingEnabled = true;
			CbOperator.Items.AddRange(new object[] { "+", "-", "*", "/", "^", "%" });
			CbOperator.Location = new Point(230, 32);
			CbOperator.Name = "CbOperator";
			CbOperator.Size = new Size(53, 33);
			CbOperator.TabIndex = 2;
			// 
			// BtnCaculate
			// 
			BtnCaculate.BackColor = Color.MediumPurple;
			BtnCaculate.Font = new Font("微軟正黑體", 20F, FontStyle.Bold);
			BtnCaculate.ForeColor = SystemColors.Control;
			BtnCaculate.Location = new Point(37, 78);
			BtnCaculate.Name = "BtnCaculate";
			BtnCaculate.Size = new Size(246, 55);
			BtnCaculate.TabIndex = 3;
			BtnCaculate.Text = "計算";
			BtnCaculate.UseVisualStyleBackColor = false;
			BtnCaculate.Click += BtnCaculate_Click;
			// 
			// BtnClear
			// 
			BtnClear.BackColor = Color.MediumPurple;
			BtnClear.Font = new Font("微軟正黑體", 15F, FontStyle.Bold);
			BtnClear.ForeColor = SystemColors.Control;
			BtnClear.Location = new Point(340, 78);
			BtnClear.Name = "BtnClear";
			BtnClear.Size = new Size(125, 55);
			BtnClear.TabIndex = 4;
			BtnClear.Text = "清除";
			BtnClear.UseVisualStyleBackColor = false;
			BtnClear.Click += BtnClear_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
			label1.Location = new Point(37, 147);
			label1.Name = "label1";
			label1.Size = new Size(133, 35);
			label1.TabIndex = 5;
			label1.Text = "計算結果:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
			label2.Location = new Point(37, 193);
			label2.Name = "label2";
			label2.Size = new Size(97, 25);
			label2.TabIndex = 6;
			label2.Text = "錯誤訊息:";
			// 
			// label_Resault
			// 
			label_Resault.AutoSize = true;
			label_Resault.Font = new Font("微軟正黑體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
			label_Resault.Location = new Point(191, 147);
			label_Resault.Name = "label_Resault";
			label_Resault.Size = new Size(0, 35);
			label_Resault.TabIndex = 7;
			// 
			// label_ErrorMsg
			// 
			label_ErrorMsg.AutoSize = true;
			label_ErrorMsg.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
			label_ErrorMsg.Location = new Point(153, 190);
			label_ErrorMsg.Name = "label_ErrorMsg";
			label_ErrorMsg.Size = new Size(0, 25);
			label_ErrorMsg.TabIndex = 8;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 192, 255);
			ClientSize = new Size(515, 227);
			Controls.Add(label_ErrorMsg);
			Controls.Add(label_Resault);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(BtnClear);
			Controls.Add(BtnCaculate);
			Controls.Add(CbOperator);
			Controls.Add(TxtNum2);
			Controls.Add(TxtNum1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "Form1";
			Text = "Calculator";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TxtNum1;
		private TextBox TxtNum2;
		private ComboBox CbOperator;
		private Button BtnCaculate;
		private Button BtnClear;
		private Label label1;
		private Label label2;
		private Label label_Resault;
		private Label label_ErrorMsg;
	}
}
