using System;

using Android.App;
using Android.Content.PM;
using Android.OS;

namespace OSMSharp.Forms.Sample.Droid
{
    [Activity(Label = "OSMSharp.Forms", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            OsmSharp.Android.UI.Native.Initialize();
            LoadApplication(new App());
        }
    }
}

