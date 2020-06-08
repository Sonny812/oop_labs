using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab_9.FormRow
{
	class ListBoxRow : FormRow
	{
		public ListBoxRow(string labelText, List<string> choices) : base(labelText)
		{
			var field = this.Field as ListBox;

			choices.ForEach(x => field.Items.Add(x));
		}

		public override string ToString()
		{
			var items = (this.Field as ListBox).SelectedItems.Cast<string>();

			return $"{this.Label.Text}: {(items.Count() == 0 ? "-" : string.Join(", ", items))}";
		}

		protected override Control CreateField()
		{
			return new ListBox();
		}

	}
}
