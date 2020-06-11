using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace exam
{
	public partial class Form1 : Form
	{
		class Unit
		{
			public readonly string Name;
			public readonly double Coefficient;

			public Unit(string name, double coefficient)
			{
				this.Name = name;
				this.Coefficient = coefficient;
			}

			public override string ToString()
			{
				return this.Name;
			}
		}

		class Measure
		{
			public readonly double Value;
			public readonly Unit Unit;

			public Measure(double value, Unit unit)
			{
				this.Value = value;
				this.Unit = unit;
			}

			public double ToDefaultUnit()
			{
				return this.Unit.Coefficient * this.Value;
			}

			public override string ToString()
			{
				return $"{this.Value} {this.Unit}";
			}
		}

		class Rectangle
		{
			public readonly Measure Width;
			public readonly Measure Height;

			public Rectangle(Measure width, Measure height)
			{
				this.Width = width;
				this.Height = height;
			}

			public double Area()
			{
				return this.Width.ToDefaultUnit() * this.Height.ToDefaultUnit();
			}

			public double Perimeter()
			{
				return this.Width.ToDefaultUnit() * 2 + this.Height.ToDefaultUnit() * 2;
			}
		}


		Unit[] units = new Unit[] {
			new Unit("Милиметр", 0.001),
			new Unit("Сантиметр", 0.01),
			new Unit("Дециметр", 0.1),
			new Unit("Метр", 1.0),
			new Unit("Киломтер", 1000),
		};

		List<Rectangle> rectangles = new List<Rectangle>();

		public Form1()
		{
			InitializeComponent();
			foreach (ComboBox cmbbx in new ComboBox[] { this.cmbbxHeight, this.cmbbxWidth})
			{
				cmbbx.Items.AddRange(this.units);
				cmbbx.SelectedIndex = 3;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (!this.ValidateUserInput())
			{
				return;
			}

			var rectangle = new Rectangle(
				new Measure(double.Parse(this.txtbxWidth.Text), this.cmbbxWidth.SelectedItem as Unit),
				new Measure(double.Parse(this.txtbxHeight.Text), this.cmbbxHeight.SelectedItem as Unit)
			);

			this.rectangles.Add(rectangle);

			this.txtbxLog.Text += $"Добавлен новый прямоугольник. Высота: {rectangle.Height}, ширина: {rectangle.Width}, периметр: {rectangle.Perimeter()} метр, площадь: {rectangle.Area()} метр" + Environment.NewLine;

			if (this.rectangles.Count == 5)
			{
				this.btnAdd.Enabled = false;
				this.btnDisplayArea.Visible = true;
			}
		}

		private bool ValidateUserInput()
		{
			if (!double.TryParse(txtbxHeight.Text, out double height) || height <= 0 || !double.TryParse(txtbxWidth.Text, out double width) || width <= 0)
			{
				MessageBox.Show("Данные введены некорректно. Высота и ширина должна быть числами и больше 0");

				return false;
			}

			return true;
		}

		private void btnDisplayArea_Click(object sender, EventArgs e)
		{
			this.txtbxLog.Text += $"Сумма площадей всех созданных прямоугольников: {this.rectangles.Sum(x => x.Area())} м";
		}
	}
}
