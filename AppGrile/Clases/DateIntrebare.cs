namespace AppGrile.Clases
{
	public class DateIntrebare
	{
		public string textIntrebare = "Aceasta este o intrebare";
		public string[] Optiuni = { "Option one", "Option two", "Option three", "Right Answer" };
		public bool[] raspunsuriCorecte = { false, false, false, true };
		public string Poza;
		public DateIntrebare(string textIntrebare = "Aceasta este o intrebare", string[] optiuni = null,	bool[] raspunsuriCorecte = null, string poza = "")
		{
			this.textIntrebare = textIntrebare;
			Optiuni = optiuni ?? new string[] { "Option one", "Option two", "Option three", "Right Answer" };
			this.raspunsuriCorecte = raspunsuriCorecte ?? new bool[] { false, false, false, true };
			Poza = poza;
		}
		public DateIntrebare()
		{

		}
	}
}
