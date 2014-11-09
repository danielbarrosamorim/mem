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
        }


		public string ValidaCarta = "";
		public Button BotaoAtivo ;

		private int randomico ( int min, int max)
		{
		Random rnd = new Random();
		int num = rnd.Next(min,max);
			return num;


		}





	

		// Valores de 10 a 15 ( 6 números)

		// loop que define os valores aleatórios dos botoes

//		public static void Shuffle<T>(this IList<T> list)  
//		{  
//			Random rng = new Random();  
//			int n = list.Count;  
//			while (n > 1) {  
//				n--;  
//				int k = rng.Next(n + 1);  
//				T value = list[k];  
//				list[k] = list[n];  
//				list[n] = value;  
//			}  
//		}





//
//			for (int i = 0; i < 12; i++) {
//
//				int min = 10;
//				int max = 15;
//				int aux = randomico(min, max);
//				int result = 15;
//
//			foreach (var item in lista) {
//
//				if item
//
//
//			}
//				if ()
//				{
//					lista[i] = result;
//				}
//
//			}
//		

		//{10,11,12,13,14,15,10,11,12,13,14,15};
		//public int[] copy = new int[12];
		//public List<int> lista = new List<int>(10);
		//lista.
		//lista.Add(0);
		//int qtd = Array.FindLastIndex(lista,false);
		//int qtd = lista.GetLength(0); 
		//int numToRemove = 4;
		//int numIndex = Array.IndexOf(lista , numToRemove);
		//lista = lista.Where((val, idx) => idx != numIndex).ToArray();

//		ListadeCartoes lista = new ListadeCartoes();
//		ListadeCartoes.Conteudo


		void OnButtonClicked1(object sender, EventArgs args)
		{
			int aleatorio = randomico(0,12);
			//Botao1.Text= randomico(10,16).ToString();
			//Botao1.Text= lista[aleatorio].ToString();
			Botao1.Text= qtd.ToString();
			//int pos = randomico (0,11);
			//Botao1.Text= lista[pos].ToString();

		//	Botao1.Text= qtd.ToString();

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
