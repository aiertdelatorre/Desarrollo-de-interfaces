using System;

public class Esaldia
{
	public string EsaldiaBatuta {get; set;}
	private string EsaldiaOrain { get; set;}

	public Esaldia()
	{
	}

	public void EsaldiaBatu(String Esaldiagehitu)
	{
		EsaldiaOrain = EsaldiaBatuta;
		EsaldiaBatuta = EsaldiaOrain + Esaldiagehitu;
    }






}
