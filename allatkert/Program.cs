﻿namespace allatkert
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ViziAllat vizi = new("Delfin", "nőstény", 14, 3);
			SzarazfoldiHideg hideg = new("Pingvin", "hím", 6, 1);
			SzarazfoldiMediterran mediterran = new("Kanári", "tojó", 1, 2);
			SzarazfoldiMeleg meleg = new("Gepárd", "hím", 20, 5);
			SzarazfoldiTropusi tropusi = new("Gyűrűsfarkú maki", "hím", 9, 3);
			Allatkert allatkert = new();
			List<string> nevek = allatkert.AllatokNeve(vizi, hideg, mediterran, meleg, tropusi);
			List<int> sebessegek = allatkert.AllatokSebessege(vizi, hideg, mediterran, meleg, tropusi);

            Console.WriteLine("Állatkert telítettsége: ");
            Telitettseg(allatkert.Meret, nevek.Count);
			Thread.Sleep(3000);
			Verseny(nevek, sebessegek);
        }
		static void Telitettseg(int meret, int hossz)
		{
			string vonal = "-";
			string vonal2 = "|";
			string sor = new string(' ', meret + 2).Replace(" ", vonal);
            Console.WriteLine(sor);
            Console.Write(vonal2);
			Console.BackgroundColor = ConsoleColor.Green;
			for (int i = 0; i < hossz; i++)
			{
				Console.Write(" ");
			}
			Console.BackgroundColor = ConsoleColor.Black;
			for (int i = 0; i < meret-hossz; i++)
			{
				Console.Write(" ");
			}
			Console.WriteLine(vonal2);
            Console.WriteLine(sor);
        }
		static void Verseny(List<string> nevek, List<int> sebessegek)
		{
			Console.Clear();
			int startPos = LeghosszabbNev(nevek);
			for (int i = 0; i < 10; i++) 
			{
				foreach (var item in nevek)
				{
					Console.Write(item + " ");
					Console.SetCursorPosition(startPos + sebessegek[nevek.IndexOf(item)] * i, nevek.IndexOf(item));
					Console.WriteLine("O");
				}
				Thread.Sleep(1000);
				Console.Clear();
            }
        }
		static int LeghosszabbNev(List<string> nevek)
		{
			int max = 0;
            foreach (var item in nevek)
            {
                if (item.Length > max)
				{
					max = item.Length;
				}
            }
			return max;
        }
	}
}
