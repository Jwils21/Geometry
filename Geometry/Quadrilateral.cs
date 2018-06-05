using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Quadrilateral {
		public int Side1 { get; set; }
		public int Side2 { get; set; }
		public int Side3 { get; set; }
		public int Side4 { get; set; }

		public int GetPerimeter() {
			return (Side1 + Side2 + Side3 + Side4);
		}
		public virtual int GetArea() {
			return -1;
		}
		public Quadrilateral(int side1, int side2, int side3, int side4) {
			Side1 = side1;
			Side2 = side2;
			Side3 = side3;
			Side4 = Side4;
		}

		public Quadrilateral() {

		}

	}
}
