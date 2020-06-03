namespace lab_5
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtbxResult1 = new System.Windows.Forms.TextBox();
			this.btnCalculate1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtbxH = new System.Windows.Forms.TextBox();
			this.txtbxX = new System.Windows.Forms.TextBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.txtbxResult2 = new System.Windows.Forms.TextBox();
			this.btnCalculate2 = new System.Windows.Forms.Button();
			this.lblResult2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtbxDepositAmount = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtbxDepositRate = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtbxDepositTerm = new System.Windows.Forms.TextBox();
			this.btnCalculate3 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(400, 426);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtbxResult1);
			this.tabPage2.Controls.Add(this.btnCalculate1);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.txtbxH);
			this.tabPage2.Controls.Add(this.txtbxX);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(392, 400);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "4. Палка";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtbxResult1
			// 
			this.txtbxResult1.Location = new System.Drawing.Point(10, 170);
			this.txtbxResult1.Multiline = true;
			this.txtbxResult1.Name = "txtbxResult1";
			this.txtbxResult1.Size = new System.Drawing.Size(362, 205);
			this.txtbxResult1.TabIndex = 3;
			// 
			// btnCalculate1
			// 
			this.btnCalculate1.Location = new System.Drawing.Point(10, 104);
			this.btnCalculate1.Name = "btnCalculate1";
			this.btnCalculate1.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate1.TabIndex = 2;
			this.btnCalculate1.Text = "Рассчитать";
			this.btnCalculate1.UseVisualStyleBackColor = true;
			this.btnCalculate1.Click += new System.EventHandler(this.btnCalculate1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(162, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(15, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "м";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(162, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(15, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "м";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "h";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "x";
			// 
			// txtbxH
			// 
			this.txtbxH.Location = new System.Drawing.Point(56, 44);
			this.txtbxH.Name = "txtbxH";
			this.txtbxH.Size = new System.Drawing.Size(100, 20);
			this.txtbxH.TabIndex = 0;
			// 
			// txtbxX
			// 
			this.txtbxX.Location = new System.Drawing.Point(56, 18);
			this.txtbxX.Name = "txtbxX";
			this.txtbxX.Size = new System.Drawing.Size(100, 20);
			this.txtbxX.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.txtbxResult2);
			this.tabPage1.Controls.Add(this.btnCalculate2);
			this.tabPage1.Controls.Add(this.lblResult2);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(392, 400);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "5. Лапы";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// txtbxResult2
			// 
			this.txtbxResult2.Location = new System.Drawing.Point(3, 152);
			this.txtbxResult2.Multiline = true;
			this.txtbxResult2.Name = "txtbxResult2";
			this.txtbxResult2.Size = new System.Drawing.Size(389, 248);
			this.txtbxResult2.TabIndex = 2;
			// 
			// btnCalculate2
			// 
			this.btnCalculate2.Location = new System.Drawing.Point(10, 48);
			this.btnCalculate2.Name = "btnCalculate2";
			this.btnCalculate2.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate2.TabIndex = 1;
			this.btnCalculate2.Text = "Рассчитать";
			this.btnCalculate2.UseVisualStyleBackColor = true;
			this.btnCalculate2.Click += new System.EventHandler(this.btnCalculate2_Click);
			// 
			// lblResult2
			// 
			this.lblResult2.AutoSize = true;
			this.lblResult2.Location = new System.Drawing.Point(7, 90);
			this.lblResult2.Name = "lblResult2";
			this.lblResult2.Size = new System.Drawing.Size(0, 13);
			this.lblResult2.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(193, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = " У гусей и кроликов вместе 64 лапы";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Варианты сочетаний";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnCalculate3);
			this.tabPage3.Controls.Add(this.txtbxDepositTerm);
			this.tabPage3.Controls.Add(this.txtbxDepositRate);
			this.tabPage3.Controls.Add(this.txtbxDepositAmount);
			this.tabPage3.Controls.Add(this.label12);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(392, 400);
			this.tabPage3.TabIndex = 3;
			this.tabPage3.Text = "Вклад";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Сумма";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(183, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(24, 13);
			this.label8.TabIndex = 1;
			this.label8.Text = "руб";
			// 
			// txtbxDepositAmount
			// 
			this.txtbxDepositAmount.Location = new System.Drawing.Point(77, 19);
			this.txtbxDepositAmount.Name = "txtbxDepositAmount";
			this.txtbxDepositAmount.Size = new System.Drawing.Size(100, 20);
			this.txtbxDepositAmount.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(23, 54);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Ставка";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(183, 54);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(15, 13);
			this.label10.TabIndex = 1;
			this.label10.Text = "%";
			// 
			// txtbxDepositRate
			// 
			this.txtbxDepositRate.Location = new System.Drawing.Point(77, 51);
			this.txtbxDepositRate.Name = "txtbxDepositRate";
			this.txtbxDepositRate.Size = new System.Drawing.Size(100, 20);
			this.txtbxDepositRate.TabIndex = 2;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(23, 80);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(32, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Срок";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(183, 80);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(24, 13);
			this.label12.TabIndex = 1;
			this.label12.Text = "год";
			// 
			// txtbxDepositTerm
			// 
			this.txtbxDepositTerm.Location = new System.Drawing.Point(77, 77);
			this.txtbxDepositTerm.Name = "txtbxDepositTerm";
			this.txtbxDepositTerm.Size = new System.Drawing.Size(100, 20);
			this.txtbxDepositTerm.TabIndex = 2;
			// 
			// btnCalculate3
			// 
			this.btnCalculate3.Location = new System.Drawing.Point(26, 123);
			this.btnCalculate3.Name = "btnCalculate3";
			this.btnCalculate3.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate3.TabIndex = 3;
			this.btnCalculate3.Text = "Рассчитать";
			this.btnCalculate3.UseVisualStyleBackColor = true;
			this.btnCalculate3.Click += new System.EventHandler(this.btnCalculate3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Лабораторная работа №5";
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txtbxResult1;
		private System.Windows.Forms.Button btnCalculate1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtbxH;
		private System.Windows.Forms.TextBox txtbxX;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnCalculate2;
		private System.Windows.Forms.Label lblResult2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtbxResult2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button btnCalculate3;
		private System.Windows.Forms.TextBox txtbxDepositTerm;
		private System.Windows.Forms.TextBox txtbxDepositRate;
		private System.Windows.Forms.TextBox txtbxDepositAmount;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}

