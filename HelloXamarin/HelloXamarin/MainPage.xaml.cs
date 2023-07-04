using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloXamarin
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		int count = 0;
		void Button_Clicked(object sender, System.EventArgs e)
		{
			//count++;
			//((Button)sender).Text = $"You clicked {count} times.";
			Navigation.PushAsync(new Page1());
		}

		private void GoToPage2(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Page2());
		}
	}
}
