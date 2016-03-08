using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller {
	class SystematicDieRoller {
		private bool running;
		private int maxRolls;


		private Dictionary<int, int> results = new Dictionary<int, int>();
		private List<Die> dice = new List<Die>();

		public SystematicDieRoller( int maxRolls, int numberOfDice, int Sides) {
			for(int x = 0; x < numberOfDice; x++ ) {
				dice.Add( new Die( Sides ) );
			}
			this.maxRolls = maxRolls;
		}

		public void Run( ) {
			running = true;
			while ( running ) {
				DictionaryInit( );
				DisplayRunInfo( );
				for ( int i = 1; i < maxRolls; i++ ) {
					int total = 0;
					foreach ( Die d in dice ) {
						total += d.Roll( );
					}

					results[total] += 1;
				}
				DisplayResults( );
				Console.WriteLine( "(Q)uit or (R)eroll?" );
				handleInput( Console.ReadKey( true ) );
			}
			Console.WriteLine( "Press AnyKey To Continue." );
			Console.ReadKey( );
		}


		//init the dictionary
		private void DictionaryInit( ) {
			for (int i = 2; i <= dice.Count * dice[0].NumberOfSides; i++  ) {
				if ( !results.ContainsKey( i ) ) {
					results.Add( i, 0 );
				}
				else {
					results[i] = 0;
				}
			}
		}

		private void DisplayRunInfo( ) {
			Console.Clear( );
			Console.WriteLine( "Using The Following Values:" );
			Console.WriteLine( "Number Of Dice: " + dice.Count );
			Console.WriteLine( "Rolling: " + maxRolls + " times." );
		}

		private void DisplayResults( ) {
			foreach ( KeyValuePair<int, int> kvp in results ) {
				double percentage;
				percentage = ( (double) kvp.Value / (double) maxRolls ) * 100;
				Console.Write( "Of: " + maxRolls + " Rolls: " + kvp.Key +
					" appeared: " + kvp.Value + " times or: " + percentage + "% of the time\n" );
			}
		}

		private void handleInput( ConsoleKeyInfo keyInfo ) {
			switch ( keyInfo.Key ) {
				case ( ConsoleKey.Q ):
					running = false;
					break;
				case ( ConsoleKey.R ):
					//Don't need to do anything here except restart the process.
					break;
				default:
					break;
			}
		}
	}
}
