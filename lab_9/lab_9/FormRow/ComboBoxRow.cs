using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab_9.FormRow
{
	class ComboBoxRow : FormRow
	{
		public ComboBoxRow(string labelText, List<string> choices) : base(labelText)
		{
			var field = this.Field as ComboBox;

			choices.ForEach(x => field.Items.Add(x));

			field.DropDownStyle = ComboBoxStyle.DropDownList;
			field.Width = field.Items.Cast<string>().Max(x => TextRenderer.MeasureText(x, mainFont).Width) + SystemInformation.VerticalScrollBarWidth;
			field.SelectedIndex = 0;
		}

		protected override Control CreateField()
		{
			return new ComboBox();
		}

		public override string ToString()
		{
			return $"{this.Label.Text}: {(this.Field as ComboBox).SelectedItem.ToString()}";
		}
	}
}
