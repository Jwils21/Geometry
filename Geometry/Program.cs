using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Program {
		static void Main(string[] args) {
			Square sqr = new Square();
			sqr.LengthOfSides = 1.5;
			double area = sqr.GetArea();
			double perimeter = sqr.GetPerimeter();
			Console.WriteLine("Area: {0}, Perimeter: {1}.", area, perimeter);

			Square sqr2 = new Square();
			sqr2.LengthOfSides = 3.3;
			sqr2.Print();

			Rectangle Rect = new Rectangle();
			Rect.height = 1.2;
			Rect.width = 8.2;
			Rect.Print();

			Circle Cir = new Circle();
			Cir.Radius = 1;
			Cir.Print();
		}
	}
}
