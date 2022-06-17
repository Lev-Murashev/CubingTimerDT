using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace cube
{
	class Timer
	{
		DispatcherTimer timer;
		TimeSpan time;
		TimeSpan tik = new TimeSpan(0, 0, 0, 0, 10);
		public Timer()
		{
			timer = new DispatcherTimer();
			timer.Tick += new EventHandler(timerTick);
			timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
			time = new TimeSpan(0, 0, 0, 0, 0);
		}
		private void timerTick(object sender, EventArgs e)
		{
			time += tik;
		}
		public void start()
		{
			time = new TimeSpan(0, 0, 0, 0, 0);
			timer.Start();
		}
		public void stop()
		{
			timer.Stop();
		}
		public override string ToString()
		{
			return time.ToString();
		}
	}
}
