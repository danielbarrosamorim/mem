using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using SQLite.Net.Interop;


namespace PlatformVisuals
{
	class SquareImage : ContentView
	{
		Label label;
		string normText, winText;

		public SquareImage(char normChar, char winChar, int index)
		{
			this.Index = index;
			this.normText = normChar.ToString();
			this.winText = winChar.ToString();

			// A Frame surrounding an Image and a Label with its name.

			var objeto = App.MemoryImage.SelectValue(index+1);
			string str_img = objeto.Img.ToString();

			Image Image = new Image
			{
				//Source = "Icon_144x144.png",

				Source = str_img,
				Aspect = Aspect.AspectFill,
				WidthRequest = 200,
				HeightRequest = 200,

			};


			label = new Label
			{
				Text = this.normText,
				HorizontalOptions = LayoutOptions.Center,
				Font = Font.SystemFontOfSize(NamedSize.Micro),
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
					
			// this.Padding = new Thickness(3);
			this.Content = new Frame
			{
				OutlineColor = Color.Accent,
				Padding = new Thickness(1, 1, 1, 1),

				Content = new StackLayout
				{
					//Spacing = 0,
					Children = 
					{
						//label,
						Image,
					}
				}
			};

			// Don't let touch pass us by.
			this.BackgroundColor = Color.Transparent;

		}

		// Retain current Row and Col position.
		public int Index { private set; get; }
		public int Row { set; get; }
		public int Col { set; get; }

		public Font Font
		{
			set { label.Font = value; }
		}

	}
}
