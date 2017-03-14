using System;
using System.Collections.Generic;
using Microsoft.Azure.Mobile.Analytics;
using Xamarin.Forms;

namespace MobileCenter_Test
{
	public partial class ModalPage : ContentPage
	{
		public ModalPage()
		{
			Analytics.TrackEvent("Navigation", new Dictionary<string, string> {
				{ "[Page]", "ModalPage" }
			});

			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Analytics.TrackEvent("Event", new Dictionary<string, string> {
				{ "[Tap]", "Dismiss button tapped!" }
			});
			Navigation.PopModalAsync();
		}
	}
}
