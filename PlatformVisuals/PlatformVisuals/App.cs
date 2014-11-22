using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using SQLite.Net.Interop;


namespace PlatformVisuals
{
	public class App
	{
		public static MemoryRepository MemoryRepo { get; private set; }

		public static MemoryImage MemoryImage { get; private set; }

		public static Page GetMainPage(ISQLitePlatform sqlitePlatform, string dbPath)
		{
			//set database path first, then retrieve main page
			MemoryRepo = new MemoryRepository(sqlitePlatform, dbPath);

			MemoryImage = new MemoryImage(sqlitePlatform, dbPath);


			//return new PlatformVisualsPage();

			//return new MemoryView();

			return new MemoryViewImage();

		}
	}
}

//
//namespace PlatformVisuals
//{
//    public class App
//    {
//        public static Page GetMainPage()
//        {
//            return new NavigationPage(new PlatformVisualsPage());
//
//			//Button a = new Button;
//        }
//    }
//}
