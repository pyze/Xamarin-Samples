using Foundation;
using pyze.xamarin.iOS;
using UIKit;

namespace PyzeiOSSample
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main(string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main(args, null, "AppDelegate");

			var keys = new object[] { "key1", "key2" };
			var values = new object[] { "value1", "value2" };
			var customAttributes = NSDictionary.FromObjectsAndKeys(values, keys);
			PyzeAd.PostAdRequested("Google", "home", "(320, 160)", "banner", customAttributes);

			PyzeCustomEvent.PostWithEventName("Blog Read");
		}
	}
}
