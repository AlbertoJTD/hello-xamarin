using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}

		private void NextPage(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Page3());
		}

		private void GoBack(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}