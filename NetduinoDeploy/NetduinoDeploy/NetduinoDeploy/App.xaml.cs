﻿using Xamarin.Forms;

namespace NetduinoDeploy
{
	public partial class App : Application
	{
		public App ()
		{
    		InitializeComponent();
            
			MainPage = new NetduinoDeploy.MainPage();
		}

        public static void SendConsoleMessage(string logEntry)
        {
            MessagingCenter.Send(App.Current, "Console", logEntry);
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}