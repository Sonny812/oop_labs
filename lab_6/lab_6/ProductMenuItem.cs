using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6
{
	class ProductMenuItem: FlowLayoutPanel
	{
		public readonly Product product;
		private readonly Label label;
		private readonly NumericUpDown nud;

		public event EventHandler CountChange;

		public int Count { get => (int)this.nud.Value; }

		public ProductMenuItem(Product product) : base()
		{
			this.AutoSize = true;

			this.product = product;

			this.label = new Label();
			this.label.Text = product.Title;
			this.label.Anchor = AnchorStyles.Left;
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

			this.nud = new NumericUpDown();

			this.nud.Minimum = 1;
			this.nud.ValueChanged += (s, e) => CountChange(this, new EventArgs());
			
			this.Controls.Add(this.label);
			this.Controls.Add(this.nud);

			this.Enabled = false;
		}
	}
}
