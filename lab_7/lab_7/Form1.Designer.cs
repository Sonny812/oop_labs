namespace lab_7
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
			this.txtbxResult = new System.Windows.Forms.TextBox();
			this.panelMain = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnRemoveLast = new System.Windows.Forms.Button();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.buttonNegate = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtbxResult
			// 
			this.txtbxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtbxResult.Location = new System.Drawing.Point(12, 12);
			this.txtbxResult.Name = "txtbxResult";
			this.txtbxResult.ReadOnly = true;
			this.txtbxResult.Size = new System.Drawing.Size(278, 44);
			this.txtbxResult.TabIndex = 0;
			this.txtbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.button8);
			this.panelMain.Controls.Add(this.button6);
			this.panelMain.Controls.Add(this.btnClear);
			this.panelMain.Controls.Add(this.btnRemoveLast);
			this.panelMain.Controls.Add(this.btnCalculate);
			this.panelMain.Controls.Add(this.button16);
			this.panelMain.Controls.Add(this.button15);
			this.panelMain.Controls.Add(this.button14);
			this.panelMain.Controls.Add(this.button13);
			this.panelMain.Controls.Add(this.button12);
			this.panelMain.Controls.Add(this.buttonNegate);
			this.panelMain.Controls.Add(this.button7);
			this.panelMain.Controls.Add(this.button10);
			this.panelMain.Controls.Add(this.button9);
			this.panelMain.Controls.Add(this.button5);
			this.panelMain.Controls.Add(this.button4);
			this.panelMain.Controls.Add(this.button3);
			this.panelMain.Controls.Add(this.button2);
			this.panelMain.Controls.Add(this.button1);
			this.panelMain.Location = new System.Drawing.Point(13, 63);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(277, 375);
			this.panelMain.TabIndex = 1;
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(139, 220);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(62, 59);
			this.button8.TabIndex = 0;
			this.button8.Tag = "inputButton";
			this.button8.Text = "3";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(139, 155);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(62, 59);
			this.button6.TabIndex = 0;
			this.button6.Tag = "inputButton";
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(71, 25);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(62, 59);
			this.btnClear.TabIndex = 0;
			this.btnClear.Tag = "";
			this.btnClear.Text = "С";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnRemoveLast
			// 
			this.btnRemoveLast.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoveLast.Location = new System.Drawing.Point(139, 25);
			this.btnRemoveLast.Name = "btnRemoveLast";
			this.btnRemoveLast.Size = new System.Drawing.Size(62, 59);
			this.btnRemoveLast.TabIndex = 0;
			this.btnRemoveLast.Tag = "";
			this.btnRemoveLast.Text = "⌫";
			this.btnRemoveLast.UseVisualStyleBackColor = true;
			this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalculate.Location = new System.Drawing.Point(207, 285);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(62, 59);
			this.btnCalculate.TabIndex = 0;
			this.btnCalculate.Tag = "";
			this.btnCalculate.Text = "=";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// button16
			// 
			this.button16.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button16.Location = new System.Drawing.Point(207, 220);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(62, 59);
			this.button16.TabIndex = 0;
			this.button16.Tag = "operationButton";
			this.button16.Text = "+";
			this.button16.UseVisualStyleBackColor = true;
			// 
			// button15
			// 
			this.button15.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button15.Location = new System.Drawing.Point(207, 155);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(62, 59);
			this.button15.TabIndex = 0;
			this.button15.Tag = "operationButton";
			this.button15.Text = "-";
			this.button15.UseVisualStyleBackColor = true;
			// 
			// button14
			// 
			this.button14.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button14.Location = new System.Drawing.Point(207, 90);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(62, 59);
			this.button14.TabIndex = 0;
			this.button14.Tag = "operationButton";
			this.button14.Text = "*";
			this.button14.UseVisualStyleBackColor = true;
			// 
			// button13
			// 
			this.button13.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button13.Location = new System.Drawing.Point(207, 25);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(62, 59);
			this.button13.TabIndex = 0;
			this.button13.Tag = "operationButton";
			this.button13.Text = "/";
			this.button13.UseVisualStyleBackColor = true;
			// 
			// button12
			// 
			this.button12.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button12.Location = new System.Drawing.Point(139, 285);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(62, 59);
			this.button12.TabIndex = 0;
			this.button12.Tag = "inputButton";
			this.button12.Text = ",";
			this.button12.UseVisualStyleBackColor = true;
			// 
			// buttonNegate
			// 
			this.buttonNegate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNegate.Location = new System.Drawing.Point(3, 285);
			this.buttonNegate.Name = "buttonNegate";
			this.buttonNegate.Size = new System.Drawing.Size(62, 59);
			this.buttonNegate.TabIndex = 0;
			this.buttonNegate.Tag = "";
			this.buttonNegate.Text = "+/-";
			this.buttonNegate.UseVisualStyleBackColor = true;
			this.buttonNegate.Click += new System.EventHandler(this.buttonNegate_Click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(3, 220);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(62, 59);
			this.button7.TabIndex = 0;
			this.button7.Tag = "inputButton";
			this.button7.Text = "1";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(71, 285);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(62, 59);
			this.button10.TabIndex = 0;
			this.button10.Tag = "inputButton";
			this.button10.Text = "0";
			this.button10.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(71, 220);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(62, 59);
			this.button9.TabIndex = 0;
			this.button9.Tag = "inputButton";
			this.button9.Text = "2";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(71, 155);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(62, 59);
			this.button5.TabIndex = 0;
			this.button5.Tag = "inputButton";
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(3, 155);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(62, 59);
			this.button4.TabIndex = 0;
			this.button4.Tag = "inputButton";
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(139, 90);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(62, 59);
			this.button3.TabIndex = 0;
			this.button3.Tag = "inputButton";
			this.button3.Text = "9";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(71, 90);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(62, 59);
			this.button2.TabIndex = 0;
			this.button2.Tag = "inputButton";
			this.button2.Text = "8";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(3, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(62, 59);
			this.button1.TabIndex = 0;
			this.button1.Tag = "inputButton";
			this.button1.Text = "7";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 450);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.txtbxResult);
			this.Name = "Form1";
			this.Text = "Лабораторная работа №7";
			this.panelMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtbxResult;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnRemoveLast;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button buttonNegate;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}

