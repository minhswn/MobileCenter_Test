using System.Collections.Generic;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace MobileCenter_Test
{
	public partial class MobileCenter_TestPage : ContentPage
	{
		public MobileCenter_TestPage()
		{
			Analytics.TrackEvent("Navigation", new Dictionary<string, string> { 
				{ "[Page]", "MobileCenter_TestPage" } 
			});

			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Analytics.TrackEvent("Event", new Dictionary<string, string> {
				{ "[Tap]", "Present modal tapped!" }
			});

			Navigation.PushModalAsync(new ModalPage());
		}

		void Alert_Clicked(object sender, System.EventArgs e)
		{
			Analytics.TrackEvent("Alert", new Dictionary<string, string> {
				{ "[Alert]", "Regular button tapped!" }
			});

			DisplayAlert("Message", "You won the game!", "OK");
		}

		void Crash_Clicked(object sender, System.EventArgs e)
		{
			Analytics.TrackEvent("Exception", new Dictionary<string, string> {
				{ "[Exception]", "Unhandled exception reached." }
			});

			Crashes.GenerateTestCrash();
		}
	}
}
