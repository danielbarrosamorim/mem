using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using SQLite.Net.Interop;

namespace PlatformVisuals
{
	class MemoryViewImage : ContentPage
	{
		// Number of squares horizontally and vertically,
		//  but if you change it, some code will break.
		static readonly int NUM = 4; // 4 x 4 
	
		// Array of XuzzleSquare views, and empty row & column.
		SquareImage[,] squares = new SquareImage[NUM, NUM];
		int emptyRow = NUM - 1;
		int emptyCol = NUM - 1;

		StackLayout stackLayout;
		AbsoluteLayout absoluteLayout;
		double squareSize;
		bool isBusy;
		//bool isPlaying;

		public MemoryViewImage()
		{

			// Load database

			App.MemoryImage.DeleteAllValues();
			App.MemoryImage.InsertValue (11, "eiffel.jpg" );
			App.MemoryImage.InsertValue (10, "big_ben.jpg");
			App.MemoryImage.InsertValue (14, "london_eye.jpg");
			App.MemoryImage.InsertValue (13, "london_museum.jpg");
			App.MemoryImage.InsertValue (11, "eiffel.jpg" );
			App.MemoryImage.InsertValue (16, "Icon.png");
			App.MemoryImage.InsertValue (10, "big_ben.jpg");
			App.MemoryImage.InsertValue (12, "louvre");
			App.MemoryImage.InsertValue (12, "louvre");
			App.MemoryImage.InsertValue (13, "london_museum.jpg");
			App.MemoryImage.InsertValue (15, "the_shard_view.jpg");
			App.MemoryImage.InsertValue (14, "london_eye.jpg");
			App.MemoryImage.InsertValue (15, "the_shard_view.jpg");
			App.MemoryImage.InsertValue (16, "Icon.jpg");
			App.MemoryImage.InsertValue (17, "Icon.jpg");
			App.MemoryImage.InsertValue (18, "Icon.jpg");




			// AbsoluteLayout to host the squares.
			absoluteLayout = new AbsoluteLayout()
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};

			// Create XuzzleSquare's for all the rows and columns.
			string text = "{XAMARIN.FORMS}A";
			string winText = "CONGRATULATIONSA";
			int index = 0;

			for (int row = 0; row < NUM; row++)
			{
				for (int col = 0; col < NUM; col++)
				{

					// Instantiate XuzzleSquare.
					SquareImage square = new SquareImage(text[index], winText[index], index)
					{
						Row = row,
						Col = col
					};

					// Add tap recognition
					TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer
					{
						Command = new Command(OnSquareTapped),
						CommandParameter = square
					};
					square.GestureRecognizers.Add(tapGestureRecognizer);

					// Add it to the array and the AbsoluteLayout.
					squares[row, col] = square;
					absoluteLayout.Children.Add(square);
					index++;
				}
			}
			// Put everything in a StackLayout.
			stackLayout = new StackLayout
			{
				Children = 
				{
					absoluteLayout
				}
				};
			stackLayout.SizeChanged += OnStackSizeChanged;

			// And set that to the content of the page.
			this.Padding = 
				new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);
			this.Content = stackLayout;
		}

		void OnStackSizeChanged(object sender, EventArgs args)
		{
			double width = stackLayout.Width;
			double height = stackLayout.Height;

			if (width <= 0 || height <= 0)
				return;

			// Orient StackLayout based on portrait/landscape mode.
			stackLayout.Orientation = (width < height) ? StackOrientation.Vertical : 
				StackOrientation.Horizontal;

			// Calculate square size and position based on stack size.
			squareSize = Math.Min(width, height) / NUM;
			absoluteLayout.WidthRequest = NUM * squareSize;
			absoluteLayout.HeightRequest = NUM * squareSize;
			Font font = Font.SystemFontOfSize(0.4 * squareSize, FontAttributes.Bold);

			foreach (View view in absoluteLayout.Children)
			{
				SquareImage square = (SquareImage)view;
				square.Font = font;

				AbsoluteLayout.SetLayoutBounds(square,
					new Rectangle(square.Col * squareSize, 
						square.Row * squareSize, 
						squareSize, 
						squareSize));
			}
		}

		async void OnSquareTapped (object parameter)
		{
			if (isBusy)
				return;

			isBusy = true;
			SquareImage tappedSquare = (SquareImage)parameter;
			//await ShiftIntoEmpty (tappedSquare.Row, tappedSquare.Col);
			isBusy = false;

		}

	}
}
