using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
	internal class SzarazfoldiMeleg
	{
		private string nev;
		private string nem;
		private int tomeg;
		private int sebesseg;

		public SzarazfoldiMeleg(string nev, string nem, int tomeg, int sebesseg)
		{
			this.nev = nev;
			this.nem = nem;
			this.tomeg = tomeg;
			this.sebesseg = sebesseg;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Nem { get => nem; set => nem = value; }
		public int Tomeg { get => tomeg; set => tomeg = value; }
		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
	}
}
