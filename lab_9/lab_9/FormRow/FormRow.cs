using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab_9.FormRow
{
	abstract class FormRow : FlowLayoutPanel
	{
		public enum ControlOrder { LabelFirst, FieldFirst }

		protected static Font mainFont = new Font("Verdana", 12);

		public Label Label { get; private set; }
		public Control Field { get; private set; }

		protected FormRow(string labelText, ControlOrder controlOrder = ControlOrder.LabelFirst) : base()
		{
			this.AutoSize = true;

			this.Label = new Label
			{
				Text = labelText,
				Font = mainFont,
				Anchor = AnchorStyles.Left,
				TextAlign = ContentAlignment.MiddleLeft,
				AutoSize = true,
			};

			this.Field = this.CreateField();
			this.Field.Font = mainFont;
			this.Field.Anchor = AnchorStyles.Right;
			this.Field.AutoSize = true;

			var controls = new Control[] { this.Label, this.Field };
			foreach (var control in (controlOrder == ControlOrder.LabelFirst ? controls : controls.Reverse().ToArray()))
			{
				this.Controls.Add(control);
			}
		}


		abstract protected Control CreateField();

		public override string ToString()
		{
			return $"{this.Label.Text}: {this.Field.Text}";
		}
	}
}
