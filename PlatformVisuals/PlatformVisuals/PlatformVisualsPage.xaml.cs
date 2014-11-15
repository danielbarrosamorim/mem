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
    public partial class PlatformVisualsPage 
    {
		public PlatformVisualsPage()
        {

            InitializeComponent();

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
//		public Bu PosicaoAtiva ;


		void  OnButtonClicked1(object sender, EventArgs args)
		{

			var objeto1 = App.MemoryRepo.SelectValue(1);
			Botao1.Text= objeto1.Value.ToString();

			if (BotaoAtivo != null)
			{
				if (BotaoAtivo.Text == Botao1.Text)
				{
					Botao1.Text = "";
					BotaoAtivo.Text = "";
					BotaoAtivo.IsEnabled = false;
					Botao1.IsEnabled = false;
				}
			}
			BotaoAtivo = Botao1;
			//PosicaoAtiva = Botao1;


		}

		void OnButtonClicked2(object sender, EventArgs args)
		{

			var objeto2 = App.MemoryRepo.SelectValue(2);
			Botao2.Text= objeto2.Value.ToString();

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao2.Text) {
//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao2.Text = "";
					BotaoAtivo.Text = "";
					BotaoAtivo.IsEnabled = false;
					Botao2.IsEnabled = false;
//				});
				}
			}
			BotaoAtivo = Botao2;


		}

		void OnButtonClicked3(object sender, EventArgs args)
		{

			var objeto3 = App.MemoryRepo.SelectValue(3);
			Botao3.Text= objeto3.Value.ToString();

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao3.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => 
					Botao3.Text = "";
					BotaoAtivo.Text = "";
					BotaoAtivo.IsEnabled = false;
					Botao3.IsEnabled = false;
				}
			}
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

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao4.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao4.Text = "";
					BotaoAtivo.Text = "";
					BotaoAtivo.IsEnabled = false;
					Botao4.IsEnabled = false;
				}
			}
			BotaoAtivo = Botao4;


		}

		void OnButtonClicked5(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(5);
			int result = objeto.Value;
			Botao5.Text= result.ToString();


			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao5.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao5.Text = "";
					BotaoAtivo.Text = "";
					BotaoAtivo.IsEnabled = false;
					Botao5.IsEnabled = false;
					//	BotaoAtivo.IsVisible = "";
					//	BotaoAtivo = null;
					//	return true;
					//				});
				}
			}
			BotaoAtivo = Botao5;



		}

		void OnButtonClicked6(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(6);
			int result = objeto.Value;
			Botao6.Text= result.ToString();

			if (BotaoAtivo != null) {
				if (BotaoAtivo.Text == Botao6.Text) {
					//				Device.StartTimer (TimeSpan.FromSeconds (2), () => {
					Botao6.Text = "";
					BotaoAtivo.Text = "";
					BotaoAtivo.IsEnabled = false;
					Botao6.IsEnabled = false;
				}
			}
			BotaoAtivo = Botao6;

		}

		void OnButtonClicked7(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(7);
			int result = objeto.Value;
			Botao7.Text= result.ToString();

		}
		void OnButtonClicked8(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(8);
			int result = objeto.Value;
			Botao8.Text= result.ToString();

		}

		void OnButtonClicked9(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(9);
			int result = objeto.Value;
			Botao9.Text= result.ToString();

		}

		void OnButtonClicked10(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(10);
			int result = objeto.Value;
			Botao10.Text= result.ToString();

		}

		void OnButtonClicked11(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(11);
			int result = objeto.Value;
			Botao11.Text= result.ToString();

		}

		void OnButtonClicked12(object sender, EventArgs args)
		{
			var objeto = App.MemoryRepo.SelectValue(12);
			int result = objeto.Value;
			Botao12.Text= result.ToString();

		}
			


    }








}
