using System;

namespace cube
{
	public enum Puzzels { cube2, cube3, cube4, pyraminx }
	public enum Fools { plus2, dns, dnf, none }
	class Solve
	{
		private Puzzels Type; 
		private string Time;
		private string scramble;
		public Fools Fool { get; set; }
		public Solve(Puzzels type, string scr, string time, Fools fool)
		{
			Type = type;
			scramble = scr;
			Time = time;
			Fool = fool;
		}
		public Solve(Puzzels type, string scr, string time)
		{
			Type = type;
			scramble = scr;
			Time = time;
			Fool = Fools.none;
		}
	}
}
