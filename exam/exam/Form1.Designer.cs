namespace exam
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtbxWidth = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtbxHeight = new System.Windows.Forms.TextBox();
			this.cmbbxWidth = new System.Windows.Forms.ComboBox();
			this.cmbbxHeight = new System.Windows.Forms.ComboBox();
			this.txtbxLog = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDisplayArea = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ширина";
			// 
			// txtbxWidth
			// 
			this.txtbxWidth.Location = new System.Drawing.Point(75, 29);
			this.txtbxWidth.Name = "txtbxWidth";
			this.txtbxWidth.Size = new System.Drawing.Size(137, 20);
			this.txtbxWidth.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Высота";
			// 
			// txtbxHeight
			// 
			this.txtbxHeight.Location = new System.Drawing.Point(75, 64);
			this.txtbxHeight.Name = "txtbxHeight";
			this.txtbxHeight.Size = new System.Drawing.Size(137, 20);
			this.txtbxHeight.TabIndex = 1;
			// 
			// cmbbxWidth
			// 
			this.cmbbxWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbbxWidth.FormattingEnabled = true;
			this.cmbbxWidth.Location = new System.Drawing.Point(234, 29);
			this.cmbbxWidth.Name = "cmbbxWidth";
			this.cmbbxWidth.Size = new System.Drawing.Size(121, 21);
			this.cmbbxWidth.TabIndex = 2;
			// 
			// cmbbxHeight
			// 
			this.cmbbxHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbbxHeight.FormattingEnabled = true;
			this.cmbbxHeight.Location = new System.Drawing.Point(234, 63);
			this.cmbbxHeight.Name = "cmbbxHeight";
			this.cmbbxHeight.Size = new System.Drawing.Size(121, 21);
			this.cmbbxHeight.TabIndex = 2;
			// 
			// txtbxLog
			// 
			this.txtbxLog.Location = new System.Drawing.Point(396, 17);
			this.txtbxLog.Multiline = true;
			this.txtbxLog.Name = "txtbxLog";
			this.txtbxLog.ReadOnly = true;
			this.txtbxLog.Size = new System.Drawing.Size(561, 140);
			this.txtbxLog.TabIndex = 3;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(26, 134);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDisplayArea
			// 
			this.btnDisplayArea.Location = new System.Drawing.Point(118, 134);
			this.btnDisplayArea.Name = "btnDisplayArea";
			this.btnDisplayArea.Size = new System.Drawing.Size(75, 23);
			this.btnDisplayArea.TabIndex = 4;
			this.btnDisplayArea.Text = "Площадь";
			this.btnDisplayArea.UseVisualStyleBackColor = true;
			this.btnDisplayArea.Visible = false;
			this.btnDisplayArea.Click += new System.EventHandler(this.btnDisplayArea_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(981, 207);
			this.Controls.Add(this.btnDisplayArea);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtbxLog);
			this.Controls.Add(this.cmbbxHeight);
			this.Controls.Add(this.cmbbxWidth);
			this.Controls.Add(this.txtbxHeight);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtbxWidth);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Зачет";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtbxWidth;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtbxHeight;
		private System.Windows.Forms.ComboBox cmbbxWidth;
		private System.Windows.Forms.ComboBox cmbbxHeight;
		private System.Windows.Forms.TextBox txtbxLog;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDisplayArea;
	}
}

