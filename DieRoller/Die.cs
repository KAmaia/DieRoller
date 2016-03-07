using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller {
	class Die {
		private static Random rnd = new Random();
		private int numberOfSides;

		public int NumberOfSides { get { return numberOfSides; } }

		public Die( int numberOfSides ) {
			this.numberOfSides = numberOfSides;
		}

		public int Roll( ) {
			return rnd.Next( 1, numberOfSides + 1 );
		}

	}
}
