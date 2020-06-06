using System.Windows.Forms;

namespace lab_9.FormRow
{
	class CheckBoxRow : FormRow
	{
		public CheckBoxRow(string labelText) : base(labelText, ControlOrder.FieldFirst)
		{ }

		protected override Control CreateField()
		{
			return new CheckBox();
		}

		public override string ToString()
		{
			return $"{this.Label.Text}: {((this.Field as CheckBox).Checked ? "Да" : "Нет")}";
		}
	}
}
