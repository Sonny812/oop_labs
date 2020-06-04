using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace lab_7
{
	public partial class Form1 : Form
	{
		bool inputMode = true;

		const string OPERATION_BUTTON_TAG = "operationButton";
		const string INPUT_BUTTON_TAG = "inputButton";

		double firstOperand = 0;
		string currentOperation = "";

		Func<double, double> operationToRepeat;


		Dictionary<string, Func<double, double, double>> symbolOperationMap = new Dictionary<string, Func<double, double, double>>
		{
			{"+", (x, y) => x + y },
			{"-", (x, y) => x - y },
			{"*", (x, y) => x * y },
			{"/", (x, y) => y == 0 ? throw new DivideByZeroException() : x / y },
		};

		public Form1()
		{
			InitializeComponent();

			this.panelMain
				.Controls
				.Cast<Control>()
				.Where(x => x is Button)
				.ToList()
				.ForEach(x => this.AddHandlerForButton(x as Button));
		}

		private void AddHandlerForButton(Button button)
		{
			var tag = button.Tag?.ToString();

			if (tag is null)
			{
				return;
			}

			switch (tag)
			{
				case OPERATION_BUTTON_TAG:
					button.Click += OnOperationButtonClick;
					break;
				case INPUT_BUTTON_TAG:
					button.Click += OnInputButtonClick;
					break;
			}
		}

		private void OnInputButtonClick(object sender, EventArgs args)
		{
			if (!this.inputMode)
			{
				this.txtbxResult.Clear();
				this.inputMode = true;
			}

			this.txtbxResult.Text += (sender as Control).Text;
		}

		private void OnOperationButtonClick(object sender, EventArgs args)
		{
			this.currentOperation = (sender as Button).Text;
			this.firstOperand = double.Parse(txtbxResult.Text);

			this.inputMode = false;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.Reset();
		}

		public void Reset()
		{
			txtbxResult.Text = "0";
			this.inputMode = false;
			this.firstOperand = 0;
		}

		private void btnRemoveLast_Click(object sender, EventArgs e)
		{
			var sourceText = txtbxResult.Text;

			if (sourceText.Length == 0)
			{
				return;
			}

			txtbxResult.Text = sourceText.Remove(sourceText.Length - 1);
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			var secondOperand = double.Parse(txtbxResult.Text);

			double result;

			if (currentOperation is null)
			{
				result = operationToRepeat(secondOperand);
			}
			else
			{
				var operation = symbolOperationMap[this.currentOperation];
				result = operation(this.firstOperand, secondOperand);

				this.currentOperation = null;
				operationToRepeat = (x) => operation(x, secondOperand);
			}

			txtbxResult.Text = result.ToString();
			this.inputMode = false;
		}

		private void buttonNegate_Click(object sender, EventArgs e)
		{
			var value = double.Parse(txtbxResult.Text);

			txtbxResult.Text = (-value).ToString();
		}
	}
}
