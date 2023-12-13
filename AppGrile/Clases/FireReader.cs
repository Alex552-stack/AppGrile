using System.Collections.Generic;
using System.IO;

namespace AppGrile.Clases
{
	public class FileReader
	{
		private StreamReader sr;
		public readonly int NrIntrebari;
		public FileReader(string filePath)
		{
			sr = new StreamReader(filePath);
			NrIntrebari = int.Parse(sr.ReadLine());
			sr.ReadLine();
		}

		public DateIntrebare Read()
		{
			List<DateIntrebare> date = new List<DateIntrebare>();
			//NrIntrebari = int.Parse(sr.ReadLine()); //prima linie nr de intrebare
			//sr.ReadLine(); //spatiu gol

			
				DateIntrebare intrebare = new DateIntrebare();
				intrebare.textIntrebare = sr.ReadLine(); //citire textIntrebare
				intrebare.NrIntrebari = NrIntrebari;
				for (int i = 0; i < 4; i++)
				{
					intrebare.Optiuni[i] = sr.ReadLine(); //optiunile
				}
				for (int i = 0; i < 4; i++)
				{
					intrebare.raspunsuriCorecte[i] = sr.ReadLine().Contains("1"); //true/false, folosesc contains pentru eventualele caractere in plus cum ar fi ' '
				}
				intrebare.Poza = sr.ReadLine(); //nume fisier intrebare
				date.Add(intrebare);
				sr.ReadLine();
			
			return intrebare;
		}
	}
}
