namespace AppGrile.Clases
{
	public class DateIntrebare
	{
		public int NrIntrebari;
		public string textIntrebare ;
		public string[] Optiuni;
		public bool[] raspunsuriCorecte;
		public string Poza;
		public DateIntrebare()
		{
			Optiuni = new string[4];
			raspunsuriCorecte = new bool[4];
		}

	}
}
