using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller {
	class Program {
		static void Main( string[ ] args ) {
			SystematicDieRoller sdr = new SystematicDieRoller(123456789, 20, 20);
			sdr.Run( );

		
		}
	}
}
