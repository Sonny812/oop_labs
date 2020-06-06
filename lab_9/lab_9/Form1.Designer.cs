namespace lab_9
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
			this.components = new System.ComponentModel.Container();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rtxtbxResult = new System.Windows.Forms.RichTextBox();
			this.rtxtbxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuItemClear = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.leftPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.btnEnter = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.panel2.SuspendLayout();
			this.rtxtbxMenu.SuspendLayout();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.rtxtbxResult);
			this.panel2.Location = new System.Drawing.Point(491, 27);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(643, 412);
			this.panel2.TabIndex = 1;
			// 
			// rtxtbxResult
			// 
			this.rtxtbxResult.ContextMenuStrip = this.rtxtbxMenu;
			this.rtxtbxResult.Location = new System.Drawing.Point(0, 3);
			this.rtxtbxResult.Name = "rtxtbxResult";
			this.rtxtbxResult.Size = new System.Drawing.Size(627, 403);
			this.rtxtbxResult.TabIndex = 0;
			this.rtxtbxResult.Text = "";
			// 
			// rtxtbxMenu
			// 
			this.rtxtbxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemClear,
            this.menuItemSave,
            this.menuItemLoad});
			this.rtxtbxMenu.Name = "rtxtbxMenu";
			this.rtxtbxMenu.Size = new System.Drawing.Size(134, 70);
			// 
			// menuItemClear
			// 
			this.menuItemClear.Name = "menuItemClear";
			this.menuItemClear.Size = new System.Drawing.Size(133, 22);
			this.menuItemClear.Text = "Очистить";
			this.menuItemClear.Click += new System.EventHandler(this.ClearSourceControl);
			// 
			// menuItemSave
			// 
			this.menuItemSave.Name = "menuItemSave";
			this.menuItemSave.Size = new System.Drawing.Size(133, 22);
			this.menuItemSave.Text = "Сохранить";
			this.menuItemSave.Click += new System.EventHandler(this.SaveProfile);
			// 
			// menuItemLoad
			// 
			this.menuItemLoad.Name = "menuItemLoad";
			this.menuItemLoad.Size = new System.Drawing.Size(133, 22);
			this.menuItemLoad.Text = "Загрузить";
			this.menuItemLoad.Click += new System.EventHandler(this.LoadProfile);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 24);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(485, 478);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// leftPanel
			// 
			this.leftPanel.Location = new System.Drawing.Point(0, 27);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(485, 412);
			this.leftPanel.TabIndex = 3;
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(491, 455);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(75, 35);
			this.btnEnter.TabIndex = 4;
			this.btnEnter.Text = "Ввод";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(1003, 455);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(115, 35);
			this.btnLoad.TabIndex = 4;
			this.btnLoad.Text = "Загрузить";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.LoadProfile);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(886, 455);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(111, 35);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.SaveProfile);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
			this.toolStripMenuItem1.Text = "Файл";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
			this.toolStripMenuItem2.Text = "Сохранить";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.SaveProfile);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
			this.toolStripMenuItem3.Text = "Загрузить";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.LoadProfile);
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(1130, 24);
			this.mainMenu.TabIndex = 5;
			this.mainMenu.Text = "menuStrip1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1130, 502);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.leftPanel);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.mainMenu);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainMenuStrip = this.mainMenu;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Form1";
			this.Text = "Лабораторная работа №9";
			this.panel2.ResumeLayout(false);
			this.rtxtbxMenu.ResumeLayout(false);
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.FlowLayoutPanel leftPanel;
		private System.Windows.Forms.RichTextBox rtxtbxResult;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ContextMenuStrip rtxtbxMenu;
		private System.Windows.Forms.ToolStripMenuItem menuItemClear;
		private System.Windows.Forms.ToolStripMenuItem menuItemSave;
		private System.Windows.Forms.ToolStripMenuItem menuItemLoad;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.MenuStrip mainMenu;
	}
}

