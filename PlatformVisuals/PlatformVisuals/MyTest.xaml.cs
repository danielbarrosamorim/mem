using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections;

namespace PlatformVisuals
{	
	public partial class MyTest : ContentPage 
	{	
		public MyTest()
		{
			InitializeComponent ();

			// Load table : memory

			//			 App.MemoryRepo.InsertPosition (10);
			//			 App.MemoryRepo.InsertPosition (11);
			//			 App.MemoryRepo.InsertPosition (12);
			//			 App.MemoryRepo.InsertPosition (13);
			//			 App.MemoryRepo.InsertPosition (14);
			//			 App.MemoryRepo.InsertPosition (15);
			//			 App.MemoryRepo.InsertPosition (10);
			//			 App.MemoryRepo.InsertPosition (11);
			//			 App.MemoryRepo.InsertPosition (12);
			//			 App.MemoryRepo.InsertPosition (13);
			//			 App.MemoryRepo.InsertPosition (14);
			//			 App.MemoryRepo.InsertPosition (15);
			//
			// Load table : memory_rand

			App.MemoryRepo.DeleteAllValues();
			App.MemoryRepo.InsertValue (11);
			App.MemoryRepo.InsertValue (10);
			App.MemoryRepo.InsertValue (14);
			App.MemoryRepo.InsertValue (13);
			App.MemoryRepo.InsertValue (11);
			App.MemoryRepo.InsertValue (10);
			App.MemoryRepo.InsertValue (12);
			App.MemoryRepo.InsertValue (12);
			App.MemoryRepo.InsertValue (13);
			App.MemoryRepo.InsertValue (15);
			App.MemoryRepo.InsertValue (14);
			App.MemoryRepo.InsertValue (15);
		}

		public Button ButAtivo  ;
		public Button UltButAtivo  ;
		public Button PenUltButAtivo  ;
		public bool match = false;
		public int x = 0 ;


		//		public Bu PosicaoAtiva ;


		//		void OnButtonClicked(object sender, EventArgs args)
		//		{
		//
		//			//Botao3.Text = args.ToString ();
		//		//	Botao3.Text = sender.Name.ToString ();
		//
		//			
		//		}

		//		public Task Ativacao ()
		//		{
		//			ButAtivo.IsVisible = false;
		//			UltButAtivo.IsVisible = false;
		//			//return true;
		//		}
		//
		void OnButtonClicked1(object sender, EventArgs args)
		{

			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao1;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao1;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao1;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao1;
			}


			var objeto1 = App.MemoryRepo.SelectValue(1);
			Botao1.Text= objeto1.Value.ToString();
			Botao1.TextColor = Color.Black;
			Botao1.BorderWidth = 3 ;
			Botao1.BorderColor = Color.Red;
			Botao1.IsEnabled = false;
			Botao1.Image = "big_ben.jpg";

			//Botao1.
			x = x + 1;

			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					//					Device.StartTimer (TimeSpan.FromMilliseconds (1000), async () => 
					//						{
					//							return Task.Run( Ativacao());
					//						//	Ativacao ();
					//						}

					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;		


					//	);
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;

			}
			//			else if (UltButAtivo != null && PenUltButAtivo != null && match == true)
			//			{
			//				PenUltButAtivo.BorderWidth = 0 ;
			//				PenUltButAtivo.BorderColor = Color.Accent;
			//				PenUltButAtivo.TextColor = Color.White;
			//			}

		}
//
		void OnButtonClicked2(object sender, EventArgs args)
		{

			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao2;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao2;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao2;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao2;
			}


			var objeto2 = App.MemoryRepo.SelectValue(2);
			Botao2.Text= objeto2.Value.ToString();
			Botao2.TextColor = Color.Black;
			Botao2.BorderWidth = 3 ;
			Botao2.BorderColor = Color.Red;
			Botao2.IsEnabled = false;
			//Botao1.Image = "Icon.png";
			//Botao1.
			x = x + 1;

			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					//				Device.StartTimer (TimeSpan.FromSeconds (1), () => 
					//					{
					//match = true;
					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;					
					//					});
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;
			}
			//			else if (UltButAtivo != null && PenUltButAtivo != null && match == true)
			//			{
			//				PenUltButAtivo.BorderWidth = 0 ;
			//				PenUltButAtivo.BorderColor = Color.Accent;
			//				PenUltButAtivo.TextColor = Color.White;
			//			}
		}

		void OnButtonClicked3(object sender, EventArgs args)
		{

			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao3;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao3;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao3;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao3;
			}


			var objeto3 = App.MemoryRepo.SelectValue(3);
			Botao3.Text= objeto3.Value.ToString();
			Botao3.TextColor = Color.Black;
			Botao3.BorderWidth = 3 ;
			Botao3.BorderColor = Color.Red;
			Botao3.IsEnabled = false;
			//Botao1.Image = "Icon.png";
			//Botao1.
			x = x + 1;


			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					//match = true;
					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;					
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;
			}
			//			else if (UltButAtivo != null && PenUltButAtivo != null && match == true)
			//			{
			//				PenUltButAtivo.BorderWidth = 0 ;
			//				PenUltButAtivo.BorderColor = Color.Accent;
			//				PenUltButAtivo.TextColor = Color.White;
			//			}

		}

		void OnButtonClicked4(object sender, EventArgs args)
		{

			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao4;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao4;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao4;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao4;
			}


			var objeto4 = App.MemoryRepo.SelectValue(4);
			Botao4.Text= objeto4.Value.ToString();
			Botao4.TextColor = Color.Black;
			Botao4.BorderWidth = 3 ;
			Botao4.BorderColor = Color.Red;
			Botao4.IsEnabled = false;
			//Botao1.Image = "Icon.png";
			//Botao1.
			x = x + 1;


			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					//match = true;
					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;					
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;
			}
			//			else if (UltButAtivo != null && PenUltButAtivo != null && match == true)
			//			{
			//			    PenUltButAtivo.BorderWidth = 0 ;
			//				PenUltButAtivo.BorderColor = Color.Accent;
			//				PenUltButAtivo.TextColor = Color.White;
			//			}



		}

		void OnButtonClicked5(object sender, EventArgs args)
		{

			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao5;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao5;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao5;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao5;
			}


			var objeto5 = App.MemoryRepo.SelectValue(5);
			Botao5.Text= objeto5.Value.ToString();
			Botao5.TextColor = Color.Black;
			Botao5.BorderWidth = 3 ;
			Botao5.BorderColor = Color.Red;
			Botao5.IsEnabled = false;
			//Botao1.Image = "Icon.png";
			//Botao1.
			x = x + 1;


			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					//match = true;
					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;					
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;
			}
			//			else if (UltButAtivo != null && PenUltButAtivo != null && match == true)
			//			{
			//				PenUltButAtivo.BorderWidth = 0 ;
			//				PenUltButAtivo.BorderColor = Color.Accent;
			//				PenUltButAtivo.TextColor = Color.White;
			//			}

		}

		void OnButtonClicked6(object sender, EventArgs args)
		{

			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao6;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao6;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao6;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao6;
			}


			var objeto6 = App.MemoryRepo.SelectValue(6);
			Botao6.Text= objeto6.Value.ToString();
			Botao6.TextColor = Color.Black;
			Botao6.BorderWidth = 3 ;
			Botao6.BorderColor = Color.Red;
			Botao6.IsEnabled = false;
			//Botao1.Image = "Icon.png";
			//Botao1.
			x = x + 1;


			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					//match = true;
					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;					
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;

			}
			//			else if (UltButAtivo != null && PenUltButAtivo != null && match == true)
			//			{
			//				PenUltButAtivo.BorderWidth = 0 ;
			//				PenUltButAtivo.BorderColor = Color.Accent;
			//				PenUltButAtivo.TextColor = Color.White;
			//			}

		}

		void OnButtonClicked7(object sender, EventArgs args)
		{
			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao7;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao7;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao7;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao7;
			}


			var objeto7 = App.MemoryRepo.SelectValue(7);
			Botao7.Text= objeto7.Value.ToString();
			Botao7.TextColor = Color.Black;
			Botao7.BorderWidth = 3 ;
			Botao7.BorderColor = Color.Red;
			Botao7.IsEnabled = false;
			//Botao1.Image = "Icon.png";
			//Botao1.
			x = x + 1;

			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;					
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;

			}


		}

		void OnButtonClicked8(object sender, EventArgs args)
		{
			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao8;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao8;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao8;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao8;
			}


			var objeto8 = App.MemoryRepo.SelectValue(8);
			Botao8.Text= objeto8.Value.ToString();
			Botao8.TextColor = Color.Black;
			Botao8.BorderWidth = 3 ;
			Botao8.BorderColor = Color.Red;
			Botao8.IsEnabled = false;
			//Botao1.Image = "Icon.png";
			//Botao1.
			x = x + 1;

			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;					
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;

			}
		}

		void OnButtonClicked9(object sender, EventArgs args)
		{
			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao9;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao9;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao9;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao9;
			}


			var objeto9 = App.MemoryRepo.SelectValue(9);
			Botao9.Text= objeto9.Value.ToString();
			Botao9.TextColor = Color.Black;
			Botao9.BorderWidth = 3 ;
			Botao9.BorderColor = Color.Red;
			Botao9.IsEnabled = false;
			//Botao1.Image = "Icon.png";
			//Botao1.
			x = x + 1;

			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;					
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;

			}

		}

		void OnButtonClicked10(object sender, EventArgs args)
		{
			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao10;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao10;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao10;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao10;
			}


			var objeto10 = App.MemoryRepo.SelectValue(10);
			Botao10.Text= objeto10.Value.ToString();
			Botao10.TextColor = Color.Black;
			Botao10.BorderWidth = 3 ;
			Botao10.BorderColor = Color.Red;
			Botao10.IsEnabled = false;
			//Botao1.Image = "Icon.png";
			//Botao1.
			x = x + 1;

			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;					
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;

			}
		}

		void OnButtonClicked11(object sender, EventArgs args)
		{
			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao11;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao11;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao11;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao11;
			}


			var objeto11 = App.MemoryRepo.SelectValue(11);
			Botao11.Text= objeto11.Value.ToString();
			Botao11.TextColor = Color.Black;
			Botao11.BorderWidth = 3 ;
			Botao11.BorderColor = Color.Red;
			Botao11.IsEnabled = false;
			//Botao1.Image = "Icon.png";
			//Botao1.
			x = x + 1;

			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;					
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;

			}
		}

		void OnButtonClicked12(object sender, EventArgs args)
		{
			if (ButAtivo == null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				//UltButAtivo = null;
				ButAtivo = Botao12;
			} else if (ButAtivo != null && UltButAtivo == null && PenUltButAtivo == null) {
				//PenUltButAtivo = null;
				UltButAtivo = ButAtivo;
				ButAtivo = Botao12;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo == null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao12;
			} else if (ButAtivo != null && UltButAtivo != null && PenUltButAtivo != null) {
				PenUltButAtivo = UltButAtivo;
				UltButAtivo =  ButAtivo ;
				ButAtivo = Botao12;
			}


			var objeto12 = App.MemoryRepo.SelectValue(12);
			Botao12.Text= objeto12.Value.ToString();
			Botao12.TextColor = Color.Black;
			Botao12.BorderWidth = 3 ;
			Botao12.BorderColor = Color.Red;
			Botao12.IsEnabled = false;
			//Botao1.Image = "Icon.png";
			//Botao1.
			x = x + 1;

			if (UltButAtivo != null)
			{

				if (UltButAtivo.Text == ButAtivo.Text)
				{
					ButAtivo.IsVisible = false;
					UltButAtivo.IsVisible = false;					
				}
			}

			if (UltButAtivo != null && PenUltButAtivo != null && x == 3)
			{
				UltButAtivo.BorderWidth = 0 ;
				UltButAtivo.BorderColor = Color.Accent;
				UltButAtivo.TextColor = Color.White;
				UltButAtivo.IsEnabled = true;

				PenUltButAtivo.BorderWidth = 0 ;
				PenUltButAtivo.BorderColor = Color.Accent;
				PenUltButAtivo.TextColor = Color.White;
				PenUltButAtivo.IsEnabled = true;

				x = 1;

			}

		}




	}
}

