using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlatformVisuals
{
    public partial class PlatformVisualsPage
    {
        public PlatformVisualsPage()
        {

            InitializeComponent();
        }

		private async Task WaitAndExecute (int milisec)
		{
			await Task.Delay (milisec);
		}

		public string ValidaCarta = "";
		public Button BotaoAtivo ;



		void OnButtonClicked1(object sender, EventArgs args)
		{
			Botao1.Text="1";
			BotaoAtivo = Botao1;

			if (ValidaCarta == "")
			{
				ValidaCarta = Botao1.Text;
			}

		}

		void OnButtonClicked2(object sender, EventArgs args)
		{
			Botao2.Text="";

		}

		void OnButtonClicked3(object sender, EventArgs args)
		{
			Botao3.Text="1";

			Device.StartTimer(TimeSpan.FromSeconds(2), () =>
				{
					//this.DateTime = DateTime.Now;

					if (ValidaCarta == Botao3.Text)
					{
						Botao3.IsVisible = false;
						BotaoAtivo.IsVisible = false;
					}

					return true;
				});       





		}

		void OnButtonClicked4(object sender, EventArgs args)
		{
			Botao4.Text="";

		}

		void OnButtonClicked5(object sender, EventArgs args)
		{
			Botao5.Text="";

		}

		void OnButtonClicked6(object sender, EventArgs args)
		{
			Botao6.Text="";

		}

		void OnButtonClicked7(object sender, EventArgs args)
		{
			Botao7.Text="";

		}
		void OnButtonClicked8(object sender, EventArgs args)
		{
			Botao8.Text="";

		}

		void OnButtonClicked9(object sender, EventArgs args)
		{
			Botao9.Text="";

		}

		void OnButtonClicked10(object sender, EventArgs args)
		{
			Botao10.Text="";

		}

		void OnButtonClicked11(object sender, EventArgs args)
		{
			Botao11.Text="";

		}

		void OnButtonClicked12(object sender, EventArgs args)
		{
			Botao12.Text="";

		}
			


    }








}
