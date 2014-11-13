using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using SQLite.Net.Platform.XamarinAndroid;

namespace PlatformVisuals.Droid
{
    [Activity(Label = "PlatformVisuals", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : AndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);

			string dbPath = FileAccessHelper.GetLocalFilePath("memory.db3");
			SetPage(App.GetMainPage(new SQLitePlatformAndroid(), dbPath));
			//SetPage(App.GetMainPage(dbPath));
        }
    }
}

