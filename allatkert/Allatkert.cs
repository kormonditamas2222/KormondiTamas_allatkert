using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
	internal class Allatkert
	{
		static Random random = new();

		private int meret;

		public Allatkert()
		{
			this.meret = random.Next(5, 16);
		}

		public int Meret { get => meret; set => meret = value; }
		
		public List<String> AllatokNeve(ViziAllat vizi, SzarazfoldiHideg hideg, SzarazfoldiMediterran mediterran, SzarazfoldiMeleg meleg, SzarazfoldiTropusi tropusi)
		{
			List<String> nevek = new();
			nevek.Add(vizi.Nev);
			nevek.Add(hideg.Nev);
			nevek.Add(mediterran.Nev);
			nevek.Add(meleg.Nev);
			nevek.Add(tropusi.Nev);
			return nevek;
		}

		public List<int> AllatokSebessege(ViziAllat vizi, SzarazfoldiHideg hideg, SzarazfoldiMediterran mediterran, SzarazfoldiMeleg meleg, SzarazfoldiTropusi tropusi)
		{
			List<int> sebessegek = new();
			sebessegek.Add(vizi.Sebesseg);
			sebessegek.Add(hideg.Sebesseg);
			sebessegek.Add(mediterran.Sebesseg);
			sebessegek.Add(meleg.Sebesseg);
			sebessegek.Add(tropusi.Sebesseg);
			return sebessegek;
		}
	}
}
