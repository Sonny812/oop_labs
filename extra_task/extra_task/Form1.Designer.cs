namespace extra_task
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
			this.txtbxRadius = new System.Windows.Forms.TextBox();
			this.cmbbxRadius = new System.Windows.Forms.ComboBox();
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
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Радиус";
			// 
			// txtbxRadius
			// 
			this.txtbxRadius.Location = new System.Drawing.Point(75, 29);
			this.txtbxRadius.Name = "txtbxRadius";
			this.txtbxRadius.Size = new System.Drawing.Size(137, 20);
			this.txtbxRadius.TabIndex = 1;
			// 
			// cmbbxRadius
			// 
			this.cmbbxRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbbxRadius.FormattingEnabled = true;
			this.cmbbxRadius.Location = new System.Drawing.Point(228, 28);
			this.cmbbxRadius.Name = "cmbbxRadius";
			this.cmbbxRadius.Size = new System.Drawing.Size(121, 21);
			this.cmbbxRadius.TabIndex = 2;
			// 
			// txtbxLog
			// 
			this.txtbxLog.Location = new System.Drawing.Point(396, 17);
			this.txtbxLog.Multiline = true;
			this.txtbxLog.Name = "txtbxLog";
			this.txtbxLog.ReadOnly = true;
			this.txtbxLog.Size = new System.Drawing.Size(561, 209);
			this.txtbxLog.TabIndex = 3;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(26, 203);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDisplayArea
			// 
			this.btnDisplayArea.Location = new System.Drawing.Point(121, 203);
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
			this.ClientSize = new System.Drawing.Size(981, 257);
			this.Controls.Add(this.btnDisplayArea);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtbxLog);
			this.Controls.Add(this.cmbbxRadius);
			this.Controls.Add(this.txtbxRadius);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Дополнительное задание";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtbxRadius;
		private System.Windows.Forms.ComboBox cmbbxRadius;
		private System.Windows.Forms.TextBox txtbxLog;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDisplayArea;
	}
}

