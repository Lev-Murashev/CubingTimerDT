using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube
{
	class Scramble
	{
		public string scr { get; private set; }
		public Scramble()
		{
			getnext();
		}
		class Turn
		{
			private string[] sides = new string[6] { "R", "L", "U", "D", "B", "F" };
			private string[] directions = new string[3] { "", "\'", "2" };
			public string side;
			public string direction;
			public void Get_random_turn()
			{
				Random rnd = new Random();
				int drctn = rnd.Next(3);
				direction = directions[drctn];
				int sd = rnd.Next(6);
				side = sides[sd];
			}
		}
		public string getnext()
		{
			scr = "";
			Turn turn = new Turn();
			turn.Get_random_turn();
			for (int i = 1; i < 20; i++)
			{
				scr += turn.side + turn.direction + " ";
				Turn rnd_turn = new Turn();
				do
				{
					rnd_turn.Get_random_turn();
				} while (rnd_turn.side == turn.side);
				turn = rnd_turn;
			}
			return scr;
		}
	}
}
