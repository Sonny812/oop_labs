using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab_9.FormRow
{
	class RadioButtonGroupRow : FormRow
	{
		public RadioButtonGroupRow(string labelText, List<string> choices) : base(labelText)
		{
			var field = (this.Field as FlowLayoutPanel);

			choices.ForEach(x => field.Controls.Add(new RadioButton() { Text = x }));
			field.Controls.Cast<RadioButton>().First().Checked = true;
		}

		protected override Control CreateField()
		{
			return new FlowLayoutPanel();
		}

		public override string ToString()
		{
			return $"{this.Label.Text}: {this.Field.Controls.Cast<RadioButton>().First(x => x.Checked).Text}";
		}
	}
}
