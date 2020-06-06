using lab_9.FormRow;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BaseFormRow = lab_9.FormRow.FormRow;

namespace lab_9
{
	public partial class Form1 : Form
	{
		BaseFormRow[] rows = new BaseFormRow[] {
			new TextBoxRow("ФИО"),
			new RadioButtonGroupRow(
				"Пол",
				new List<string> { "мужской", "женский" }
			),
			new CheckedListBoxRow(
				"Иностранные языки",
				new List<string> {
					"Английский",
					"Немецкий",
					"Французский",
					"Испанский"
				}
			),
			new ComboBoxRow(
				"Тип документа",
				new List<string> {
					"Паспорт гражданина РФ",
					"Заграничный паспорт гражданина РФ",
					"Служебный паспорт РФ",
					"Дипломатический паспорт РФ"
				}
			),
			new CheckBoxRow("Страна пребывания является страной гражданства"),
		};

		public Form1()
		{
			InitializeComponent();
			
			foreach (var row in rows)
			{
				this.leftPanel.Controls.Add(row);
			}
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			this.rtxtbxResult.Clear();
			var resultBuilder = new StringBuilder();
			this.leftPanel.Controls.Cast<BaseFormRow>().ToList().ForEach(x => resultBuilder.Append(x.ToString() + Environment.NewLine));

			this.rtxtbxResult.Text = resultBuilder.ToString();
		}

		private void SaveProfile(object sender, EventArgs e)
		{
			var saveFileDialog = new SaveFileDialog
			{
				FileName = "profile.rtf",
				Filter = "Rich Text Format (*.rtf)|*.rtf"
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.rtxtbxResult.SaveFile(saveFileDialog.FileName);
			}
		}

		private void LoadProfile(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = "Rich Text Format (*.rtf)|*.rtf"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.rtxtbxResult.LoadFile(openFileDialog.FileName);
			}
		}

		private void ClearSourceControl(object sender, EventArgs e)
		{
			var menuItem = sender as ToolStripItem;
			var menu = menuItem.Owner as ContextMenuStrip;
			var control = menu.SourceControl as RichTextBox;

			control.Clear();
		} 
	}
}
