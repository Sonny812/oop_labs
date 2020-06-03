using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCalculate1_Click(object sender, EventArgs e)
		{
			txtbxResult1.Clear();

			if (!validate1())
			{
				return;
			}

			var x = double.Parse(txtbxX.Text);
			var h = double.Parse(txtbxH.Text);

			for (var y = 2.0; y <= 3.0; y += h)
			{
				var alpha = Math.Acos(y / x);

				txtbxResult1.Text += $"x = {x, 5:F3}, y = {y, 5:F3}, α = {alpha * 180 / Math.PI, 10:F5} {Environment.NewLine}";
			}
		}

		private bool validate1()
		{
			if (!double.TryParse(txtbxX.Text, out _) || !double.TryParse(txtbxH.Text, out _))
			{
				MessageBox.Show("x и h должны быть числами");

				return false;
			}

			return true;
		}

		private void btnCalculate2_Click(object sender, EventArgs e)
		{
			const int PAW_COUNT = 64;
			const int MAX_RABBIT_COUNT = PAW_COUNT / 4;
			const int MAX_GEESE_COUNT = PAW_COUNT / 2;

			int result = 0;

			for (int rabbitCount = 0; rabbitCount <= MAX_RABBIT_COUNT; rabbitCount++)
			{
				for (int geeseCount = 0; geeseCount <= MAX_GEESE_COUNT; geeseCount++)
				{
					if (rabbitCount * 4 + geeseCount * 2 == PAW_COUNT)
					{
						result++;
						txtbxResult2.Text += $"Количество кроликов: {rabbitCount}. Количество гусей: {geeseCount}. {Environment.NewLine}";
					}
				}
			}

			lblResult2.Text = "Количество сочетаний: " + result;
		}

		private void btnCalculate3_Click(object sender, EventArgs e)
		{
			if (!validate3())
			{
				return;
			}

			var sum = double.Parse(txtbxDepositAmount.Text);
			var rate = double.Parse(txtbxDepositRate.Text);
			
			for (int i = 0; i < int.Parse(txtbxDepositTerm.Text); i++)
			{
				sum += sum * rate / 100;
			}

			MessageBox.Show($"Сумма вклада: {sum} руб");
		}

		private bool validate3()
		{
			if (!double.TryParse(txtbxDepositAmount.Text, out _))
			{
				MessageBox.Show("Сумма должна быть числом");

				return false;
			}

			if (!double.TryParse(txtbxDepositRate.Text, out _))
			{
				MessageBox.Show("Ставка должна быть числом");

				return false;
			}

			if (!int.TryParse(txtbxDepositTerm.Text, out _))
			{
				MessageBox.Show("Срок должен быть целым числом");

				return false;
			}

			return true;
		}
	}
}
