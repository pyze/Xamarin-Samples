using Android.App;
using Android.Widget;
using Android.OS;
using pyze.xamarin.android;
using pyze.xamarin.android.PyzeEvents;

namespace PyzeAndroidSample
{
	[Activity(Label = "PyzeAndroidSample", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			Pyze.Initialize(this);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += delegate { 
				button.Text = string.Format("{0} clicks!", count++);
				PyzeCustomEvents.PostCustomEvent("Button Clicked!");
				Pyze.ShowInAppMessage(this, (sender, e) =>
				{
					//Handle button click here	
				});
			};
		}
	}
}

