using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Circle {
		public double pi = Math.PI;

		public double Radius { get; set; }
		public double GetArea() {
			return (pi * (Radius * Radius));
		}
		public double GetPerimeter() {
			return (2 * pi * Radius);
		}
		public void Print() { 
			Console.WriteLine($"A circle with a radius of {Radius} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");
		}
	}
}
