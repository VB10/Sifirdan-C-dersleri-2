using System;
using System.Collections.Generic;

namespace AyseLearn2
{
	class MainClass
	{
		static int x;
	
		//dinamik liste olusturma deger
		//global değişken 10 uzunlugunda bir dizi
		static int[] list = new int[10];
		public static void Main(string[] args)
		{
			//listler
			//listeler içersinde birden çok
			//veriler int string char double ,,,,
			//dizi[1] getir ayşe

			//dinamik değişkenler var 
			//	var x = "ayse";


			//liste yapisi
			List<String> listem1 = new List<String>();
			listem1.Add("veli");
			listem1.Add("ayşe");
			listem1.Add("memoş");
			listem1.Add("sevrullah");
			//list_write_screen(listem1);


			//static değer dondurme
			x=5;
			x_change_Value();
			Console.WriteLine(x);






			//liste yapısı 2
			array_write_screen();

		}

		static void x_change_Value()
		{
			x = 6;

		}

		static void array_write_screen()
		{
			//dizimie değer ekleyip bunu ekrana basıyoruz
			for (int i = 0; i < 10; i++)
			{
				list[i] = i;
			}

			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
		}





		static void list_write_screen(List<string> listem1)
		{
			//listedeki değerleri ekranda gösteriyoruz
			foreach (var degerler in listem1)
			{
				Console.WriteLine(degerler + "\n");
			}
		}
}
}
