﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new NavigationPage(new Page1());
			//MainPage = new TabbedPage1();
			NavigationPage navPage = new NavigationPage(new MainPage());
			MainPage = navPage;
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
