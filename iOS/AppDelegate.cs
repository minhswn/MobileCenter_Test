using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Foundation;
using UIKit;

namespace MobileCenter_Test.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			MobileCenter.Start("4eefe06a-fe03-4615-8d20-2cc3ada04781", typeof(Analytics), typeof(Crashes));
			MobileCenter.Configure("4eefe06a-fe03-4615-8d20-2cc3ada04781");

			LoadApplication(new App());	

			return base.FinishedLaunching(app, options);
		}
	}
}
