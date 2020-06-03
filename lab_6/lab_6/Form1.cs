using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace lab_6
{
	public partial class Form1 : Form
	{
		Product[] products =
		{
			new Product("Суп", 30),
			new Product("Рис", 50),
			new Product("Гречка", 50),
			new Product("Пирожок", 20),
			new Product("Чай", 15),
			new Product("Кофе", 20),
		};

		List<ProductMenuItem> productMenuItems { get => flpMenu.Controls.Cast<ProductMenuItem>().ToList(); }

		public Form1()
		{
			InitializeComponent();

			foreach (var product in products)
			{
				var productItem = new ProductMenuItem(product);

				productItem.EnabledChanged += (s, e) => RecalculateResult();
				productItem.CountChanged += (s, e) => RecalculateResult();

				this.flpMenu.Controls.Add(productItem);
				this.clbMenu.Items.Add(product);
			}
		}

		private void clbMenu_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			var checkedProduct = clbMenu.Items[e.Index] as Product;

			productMenuItems.Find(x => x.Product == checkedProduct).Enabled = e.NewValue == CheckState.Checked;
		}

		private void RecalculateResult()
		{
			this.txtbxResult.Clear();

			this.txtbxResult.Text = "Блюдо\t\tСтоимость\tКоличество\tСумма" + Environment.NewLine;
			var total = 0.0;

			foreach (var menuItem in productMenuItems.Where(x => x.Enabled))
			{
				var product = menuItem.Product;
				var count = menuItem.Count;
				var subtotal = count * product.Price;

				this.txtbxResult.Text += $"{product.Title}\t\t{product.Price} руб.\t\t{count}\t\t{subtotal}руб.{Environment.NewLine}";

				total += subtotal;
			}

			this.txtbxResult.Text += "----------" + Environment.NewLine + Environment.NewLine;
			this.txtbxResult.Text += $"Итого: {total} руб";
		}
	}
}
