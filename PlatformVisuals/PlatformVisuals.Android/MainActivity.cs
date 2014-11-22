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
using System.IO;

//[Activity(Label = "Xamarin.Forms.Labs.Sample.Droid", MainLauncher = true,
//	ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
//public class MainActivity : XFormsApplicationDroid


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

//			var docFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
//			//Console.WriteLine ("Data path:" + Database.DatabaseFilePath);
//			var dbFile = Path.Combine(docFolder, "banco.db"); // FILE NAME TO USE WHEN COPIED
//			if (!System.IO.File.Exists(dbFile)) {
//				var s = Resources.OpenRawResource(Resource.Raw.data);  // DATA FILE RESOURCE ID
//				FileStream writeStream = new FileStream(dbFile, FileMode.OpenOrCreate, FileAccess.Write);
//				ReadWriteStream(s, writeStream);
//			}
		
			//SetPage(App.GetMainPage(dbPath));
        }


    }
}

