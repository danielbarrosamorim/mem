using System;
using System.Collections.Generic;


namespace PlatformVisuals
{
	public  class ListadeCartoes 
	{


		static List<int> lista = new List<int>()
		{
			10,
			11,
			12,
			13,
			14,
			15,
			10,
			11,
			12,
			13,
			14,
			15,
		};

		public ListadeCartoes ()
		{
	
		}

	

		static int Quantidade (List<int> lista)
		{
			return lista.Count;

		}

		static void RemoveElemento (List<int> lista, int pos)
		{
			lista.RemoveAt(pos);
		}

				

	}
}

