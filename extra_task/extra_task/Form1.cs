using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace extra_task
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

		class Circle
		{
			public readonly Measure Radius;
			public Measure Diameter { get => new Measure(this.Radius.Value * 2, this.Radius.Unit); }

			public Circle(Measure radius)
			{
				this.Radius = radius;
			}

			public virtual double Area()
			{
				return Math.PI * this.Radius.ToDefaultUnit() * this.Radius.ToDefaultUnit(); 
			}
		}

		class Sphere : Circle
		{
			public Sphere(Measure radius) : base(radius)
			{ 
			}

			public override double Area()
			{
				var r = this.Radius.ToDefaultUnit();

				return 4 * Math.PI * r * r;
			}

			public double Volume()
			{
				return (4.0 / 3.0) * Math.PI * Math.Pow(this.Radius.ToDefaultUnit(), 3);
			}
		}
		
		Unit[] units = new Unit[] {
			new Unit("Милиметр", 0.001),
			new Unit("Сантиметр", 0.01),
			new Unit("Дециметр", 0.1),
			new Unit("Метр", 1.0),
			new Unit("Киломтер", 1000),
		};

		List<Sphere> spheres = new List<Sphere>();

		public Form1()
		{
			InitializeComponent();

			this.cmbbxRadius.Items.AddRange(units);
			this.cmbbxRadius.SelectedIndex = 3;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (!this.ValidateUserInput())
			{
				return;
			}

			var sphere = new Sphere(new Measure(double.Parse(this.txtbxRadius.Text), this.cmbbxRadius.SelectedItem as Unit));

			this.spheres.Add(sphere);

			this.txtbxLog.Text += $"Добавлена новая сфера. Радиус: {sphere.Radius}, площадь поверхности: {sphere.Area()} метр, объем: {sphere.Volume()} метр" + Environment.NewLine;

			if (this.spheres.Count == 5)
			{
				this.btnAdd.Enabled = false;
				this.btnDisplayArea.Visible = true;
			}
		}

		private bool ValidateUserInput()
		{
			if (!double.TryParse(txtbxRadius.Text, out double radius) || radius <= 0)
			{
				MessageBox.Show("Данные введены некорректно. Радиус должен быть числом и больше 0");

				return false;
			}

			return true;
		}

		private void btnDisplayArea_Click(object sender, EventArgs e)
		{
			this.txtbxLog.Text += $"Сумма площадей всех созданных сфер: {this.spheres.Sum(x => x.Area())} м";
		}
	}
}
