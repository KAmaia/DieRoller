using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller {
	class Program {
		static void Main( string[ ] args ) {
			//magic numbers: First is number of rolls, second and third are how many sides per die (Assuming 2 dice)
			SystematicDieRoller sdr = new SystematicDieRoller(123456789, 10, 10);
			sdr.Run( );
		}
	}
}
