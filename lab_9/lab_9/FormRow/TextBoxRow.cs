using System.Windows.Forms;

namespace lab_9.FormRow
{
	class TextBoxRow : FormRow
	{
		public TextBoxRow(string labelText, int textBoxWidth = 300) : base(labelText)
		{
			this.Field.Width = textBoxWidth;
		}

		protected override Control CreateField()
		{
			return new TextBox();
		}
	}
}
