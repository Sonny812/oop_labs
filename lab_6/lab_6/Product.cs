namespace lab_6
{
	class Product
	{
		public readonly string Title;
		public readonly double Price;

		public Product (string title, double price)
		{
			this.Title = title;
			this.Price = price;
		}

		public override string ToString()
		{
			return $"{this.Title} - {this.Price} руб.";
		}
	}
}
