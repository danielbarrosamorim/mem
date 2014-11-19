﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections;


namespace PlatformVisuals
{	
	public partial class MemoryView : ContentPage
	{	
		public MemoryView ()
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

		//		public string ValidaCarta = "";
		public Button BotaoAtivo  ;
		public Button PenultimoBotaoAtivo  ;

		//		public Bu PosicaoAtiva ;


		void  OnButtonClicked1(object sender, EventArgs args)
		{

			var objeto1 = App.MemoryRepo.SelectValue(1);
			Botao1.Text= objeto1.Value.ToString();
			Botao1.TextColor = Color.Black;


			if (BotaoAtivo != null)
			{
				if (BotaoAtivo.Text == Botao1.Text)
				{
					Device.StartTimer (TimeSpan.FromSeconds (2), () => 
						{
					Botao1.IsVisible = false;
					BotaoAtivo.TextColor = Color.Yellow;
					BotaoAtivo.IsVisible = false;
							return true;
						});
				}
				else {
					Botao1.Text = "";
					BotaoAtivo.Text = "";
				}
			}
			BotaoAtivo = Botao1;
			//PosicaoAtiva = Botao1;


		}

		void OnButtonClicked2(object sender, EventArgs args)
		{

			var objeto2 = App.MemoryRepo.SelectValue(2);
			Botao2.Text= objeto2.Value.ToString();
			Botao2.TextColor = Color.Black;

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao2.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao2.IsVisible = false;
					BotaoAtivo.IsVisible = false;
					;
					//				});
				}
				else {
					//	Botao2.Text = "";
					//	BotaoAtivo.Text = "";
				}
			}
			//Botao2.IsEnabled = false;
			//PenultimoBotaoAtivo = BotaoAtivo;
			BotaoAtivo = Botao2;


		}

		void OnButtonClicked3(object sender, EventArgs args)
		{

			var objeto3 = App.MemoryRepo.SelectValue(3);
			Botao3.Text= objeto3.Value.ToString();
			Botao3.TextColor = Color.Black;

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao3.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => 
					Botao3.IsVisible = false;
					BotaoAtivo.IsVisible = false;
				}
				else {
					Botao3.Text = "";
					BotaoAtivo.Text = "";
				}

			}
			//PenultimoBotaoAtivo = BotaoAtivo;
			BotaoAtivo = Botao3;


			//			Botao3.Text="1";
			//
			//			Device.StartTimer(TimeSpan.FromSeconds(2), () =>
			//				{
			//					//this.DateTime = DateTime.Now;
			//
			//					if (ValidaCarta == Botao3.Text)
			//					{
			//						Botao3.IsVisible = false;
			//						BotaoAtivo.IsVisible = false;
			//					}
			//
			//					return true;
			//				});       


		}

		void OnButtonClicked4(object sender, EventArgs args)
		{
			var objeto4 = App.MemoryRepo.SelectValue(4);
			Botao4.Text= objeto4.Value.ToString();
			Botao4.TextColor = Color.Black;

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao4.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao4.IsVisible = false;
					BotaoAtivo.IsVisible = false;
				} 
				else {
					//	Botao4.Text = "";
					//	BotaoAtivo.Text = "";
				}
			}

			//PenultimoBotaoAtivo = BotaoAtivo;
			BotaoAtivo = Botao4;
		}

		void OnButtonClicked5(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(5);
			int result = objeto.Value;
			Botao5.Text= result.ToString();
			Botao5.TextColor = Color.Black;


			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao5.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao5.IsVisible = false;
					BotaoAtivo.IsVisible = false;
					//	BotaoAtivo.IsVisible = "";
					//	BotaoAtivo = null;
					//	return true;
					//				});
				}
				else {
					//	Botao5.Text = "";
					//	BotaoAtivo.Text = "";
				}
			}
			//PenultimoBotaoAtivo = BotaoAtivo;
			BotaoAtivo = Botao5;



		}

		void OnButtonClicked6(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(6);
			int result = objeto.Value;
			Botao6.Text= result.ToString();
			Botao6.TextColor = Color.Black;

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao6.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao6.IsVisible = false;
					BotaoAtivo.IsVisible = false;
				}
				else {
					//	Botao6.Text = "";
					//	BotaoAtivo.Text = "";
				}
			}
			//PenultimoBotaoAtivo = BotaoAtivo;
			BotaoAtivo = Botao5;

		}

		void OnButtonClicked7(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(7);
			int result = objeto.Value;
			Botao7.Text= result.ToString();
			Botao7.TextColor = Color.Black;

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao6.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao7.IsVisible = false;
					BotaoAtivo.IsVisible = false;
				}
				else {
					//	Botao7.Text = "";
					//	BotaoAtivo.Text = "";
				}
			}
			BotaoAtivo = Botao7;



		}
		void OnButtonClicked8(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(8);
			int result = objeto.Value;
			Botao8.Text= result.ToString();
			Botao8.TextColor = Color.Black;

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao8.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao8.IsVisible = false;
					BotaoAtivo.IsVisible = false;
				}
				else {
					//	Botao8.Text = "";
					//	BotaoAtivo.Text = "";
				}
			}
			BotaoAtivo = Botao8;

		}

		void OnButtonClicked9(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(9);
			int result = objeto.Value;
			Botao9.Text= result.ToString();
			Botao9.TextColor = Color.Black;


			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao9.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao9.IsVisible = false;
					BotaoAtivo.IsVisible = false;
				}
				else {
					//	Botao9.Text = "";
					//	BotaoAtivo.Text = "";
				}
			}
			BotaoAtivo = Botao9;

		}

		void OnButtonClicked10(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(10);
			int result = objeto.Value;
			Botao10.Text= result.ToString();
			Botao10.TextColor = Color.Black;


			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao10.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao10.IsVisible = false;
					BotaoAtivo.IsVisible = false;
				}
				else {
					//	Botao10.Text = "";
					//	BotaoAtivo.Text = "";
				}
			}
			BotaoAtivo = Botao10;

		}

		void OnButtonClicked11(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(11);
			int result = objeto.Value;
			Botao11.Text= result.ToString();
			Botao11.TextColor = Color.Black;

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao11.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao11.IsVisible = false;
					BotaoAtivo.IsVisible = false;
				}
				else {
					//	Botao11.Text = "";
					//	BotaoAtivo.Text = "";
				}
			}
			BotaoAtivo = Botao11;


		}

		void OnButtonClicked12(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(12);
			int result = objeto.Value;
			Botao12.Text= result.ToString();
			Botao12.TextColor = Color.Black;

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao12.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao12.IsVisible = false;
					BotaoAtivo.IsVisible = false;
				}
				else {
					//	Botao12.Text = "";
					//	BotaoAtivo.Text = "";
				}
			}
			BotaoAtivo = Botao12;



		}




	}
}
