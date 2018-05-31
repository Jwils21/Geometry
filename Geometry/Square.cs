using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Square {
		//What data do we need so we can let this class model a square to calculate the area of a square.
		// we need length of side and the magnitude of that measure

		public double LengthOfSides { get; set; }

		public double GetArea() {
			return LengthOfSides * LengthOfSides;
		}
		public double GetPerimeter() {
			return LengthOfSides * 4;
		}
		public void Print() {
			Console.WriteLine($"A square with length {LengthOfSides} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");

		}

	}
}
