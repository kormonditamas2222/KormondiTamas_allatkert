namespace allatkert
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
			List<String> nevek = allatkert.AllatokNeve(vizi, hideg, mediterran, meleg, tropusi);
			List<int> sebessegek = allatkert.AllatokSebessege(vizi, hideg, mediterran, meleg, tropusi);

			
        }
	}
}
