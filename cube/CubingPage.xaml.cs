using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace cube
{
	/// <summary>
	/// Логика взаимодействия для CubingPage.xaml
	/// </summary>
	public partial class CubingPage : Page
	{
		Model model;
		DispatcherTimer timer;
		bool is_solving;
		public CubingPage()
		{
			InitializeComponent();
			model = new Model(Puzzels.cube3);
			timer = new DispatcherTimer();
			timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
			timer.Tick += (s, e) => { time_tb.Text = model.timer.ToString(); };
			is_solving = false;
			PreSet();
		}
		private void PreSet()
		{
			scramble_tb.Text = model.scramble.scr;
		}

		private void main_bt_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			if (is_solving)
			{
				is_solving = false;
				model.Stop();
				timer.Stop();
				PreSet();
			}
			else
			{
				is_solving = true;
				model.Start();
				timer.Start();
			}

		}

		private void main_bt_Click(object sender, RoutedEventArgs e)
		{
			if (is_solving)
			{
				is_solving = false;
				model.Stop();
				timer.Stop();
				PreSet();
			}
			else
			{
				is_solving = true;
				model.Start();
				timer.Start();
			}
		}
	}
}
