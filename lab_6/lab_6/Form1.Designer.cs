namespace lab_6
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
			this.clbMenu = new System.Windows.Forms.CheckedListBox();
			this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtbxResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// clbMenu
			// 
			this.clbMenu.FormattingEnabled = true;
			this.clbMenu.Location = new System.Drawing.Point(12, 12);
			this.clbMenu.Name = "clbMenu";
			this.clbMenu.Size = new System.Drawing.Size(301, 169);
			this.clbMenu.TabIndex = 0;
			this.clbMenu.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbMenu_ItemCheck);
			// 
			// flpMenu
			// 
			this.flpMenu.AutoScroll = true;
			this.flpMenu.Location = new System.Drawing.Point(362, 22);
			this.flpMenu.Name = "flpMenu";
			this.flpMenu.Size = new System.Drawing.Size(399, 159);
			this.flpMenu.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 233);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Счет";
			// 
			// txtbxResult
			// 
			this.txtbxResult.Location = new System.Drawing.Point(12, 249);
			this.txtbxResult.Multiline = true;
			this.txtbxResult.Name = "txtbxResult";
			this.txtbxResult.Size = new System.Drawing.Size(749, 179);
			this.txtbxResult.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtbxResult);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.flpMenu);
			this.Controls.Add(this.clbMenu);
			this.Name = "Form1";
			this.Text = "Лабораторная работа №6";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox clbMenu;
		private System.Windows.Forms.FlowLayoutPanel flpMenu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtbxResult;
	}
}

