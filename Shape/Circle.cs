using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	internal class Circle : Shape
	{
		double r;
		public Circle(string color, double r, bool isHoley = false) : base(color, isHoley)
		{
			this.r = r;
		}

		public double R { get => r; set => r = value; }

		public override double Area()
		{
			return Math.Pow(r, 2) * Math.PI;
		}


		public override double Perimeter()
		{
			return 2 * r * Math.PI;
		}

		public override string? ToString()
		{
			return "Kör" + base.ToString();
		}
	}
}
