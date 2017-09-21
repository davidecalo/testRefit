using Android.App;
using Android.Widget;
using Android.OS;
using TestRefit.Network;
using System.Collections.Generic;
using Android.Util;

namespace TestRefit.Droid
{
    [Activity(Label = "TestRefit", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate {
                //button.Text = $"{count++} clicks!";
                GetRecipe();
            };
        }

        private async void GetRecipe(){
            WS ws = new WS();
            List<Recipe> list = await ws.CallService();
			Log.Debug("OK", "OK");
		}
    }
}

