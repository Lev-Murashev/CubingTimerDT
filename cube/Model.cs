using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube
{
	class Model
	{
		Loader loader;
		Saver saver;
		Puzzels type;
		string path;
		public Timer timer { get; private set; }
		List<Solve> solves;	
		public Fools fool { private get; set; }
		public Scramble scramble { get; private set; }
		public Model(Puzzels Type)
		{
			type = Type;
			timer = new Timer();
			scramble = new Scramble();
			solves = new List<Solve>();
			fool = Fools.none;
		}
		public void Start()
		{
			if (fool != Fools.none)
			{
				solves[solves.Count].Fool = fool;
			}
			fool = Fools.none;
			timer.start();
		}
		public void Stop()
		{
			timer.stop();
			solves.Add(new Solve(type, scramble.scr,timer.ToString()));
			scramble.getnext();
		}

	}
}
