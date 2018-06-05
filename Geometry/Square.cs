using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Square : Rectangle{

		public override int GetArea() {
			return this.Side1 * this.Side2;
		}

		public Square(int LenOfSide) : base(LenOfSide, LenOfSide) {
		}

		public Square() {

		}

	}
}
