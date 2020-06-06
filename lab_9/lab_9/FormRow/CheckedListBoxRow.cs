using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab_9.FormRow
{
	class CheckedListBoxRow : FormRow
	{
		public CheckedListBoxRow(string labelText, List<string> choices) : base(labelText)
		{
			var field = this.Field as CheckedListBox;

			choices.ForEach(x => field.Items.Add(x));
		}

		protected override Control CreateField()
		{
			return new CheckedListBox();
		}

		public override string ToString()
		{
			var items = (this.Field as CheckedListBox).CheckedItems.Cast<string>();

			return $"{this.Label.Text}: {(items.Count() == 0 ? "-" : string.Join(", ", items))}";
		}
	}
}
