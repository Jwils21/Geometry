using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Rectangle {
		//Properties
		public double height { get; set; }
		public double width { get; set; }
		//Methods
		public double GetArea() {
			return height * width;
		}
		public double GetPerimeter() {
			return 2 * (height + width);
		}
		public void Print() {
			Console.WriteLine($"A rectangle with a height of {height} and and a width of {width} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");
		}
	}
}
