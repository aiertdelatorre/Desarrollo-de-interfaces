using System;
using System.ComponentModel.DataAnnotations;

public class Kalkulatu
{	public Kalkulatu()
	{
	}

	public static double Eragiketa(List<Ariketa2> objektuak){
		double emaitza = 0;
		int a = 1;
		foreach(Ariketa2 i in objektuak)
		{
			emaitza += i.zenbakiak * a;
			a++;
		}
		return emaitza/4;
	}
}
