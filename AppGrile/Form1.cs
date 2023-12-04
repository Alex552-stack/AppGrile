using AppGrile.Clases;
using AppGrile.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AppGrile
{
	public partial class Form1 : Form
	{
		private List<DateIntrebare> dateIntrebare = new List<DateIntrebare>();
		private int IntrebareCurenta = 0;
		private int NrIntrebariCorecte = 0;
		private int NrIntrebariGresite = 0;
		int NrIntrebari;
		//private string textIntrebare = "Aceasta este o intrebare";
		//private string[] Optiuni = { "Option one", "Option two", "Option three", "Right Answer" };
		//private bool[] raspunsuriCorecte = { false, false, false, true };
		public Form1()
		{
			InitializeComponent();
			CitireFisier();
			UpdateEcran();
			textIntrebariCorecte.Text = NrIntrebariCorecte.ToString();
			textIntrebariGresite.Text = NrIntrebariGresite.ToString();
			textIntrebariRamase.Text = (NrIntrebari - IntrebareCurenta - 1).ToString();
		}
		private void UpdateEcran()
		{
			if (IntrebareCurenta + 1 < dateIntrebare.Count)
			{
				ContainerIntrebare.Controls.Clear();
				NextButton.Enabled = false;
				IntrebareCurenta++;
				Intrebare intrebare = new Intrebare(dateIntrebare[IntrebareCurenta]);
				intrebare.Text = "Custom Element";
				intrebare.MyCustomAction += Intrebare_MyActionOccurred;
				ContainerIntrebare.Controls.Add(intrebare);
			}
			else
			{
				ContainerIntrebare.Controls.Clear();
				ContainerIntrebare.Controls.Add(new EcranFinal());
				NextButton.Enabled = false;
			}
		}

		private void Intrebare_MyActionOccurred(object sender, EventArgs e)
		{
			bool ok = (bool)sender;
			if (ok)
				NrIntrebariCorecte++;
			else
				NrIntrebariGresite++;
			textIntrebariCorecte.Text = NrIntrebariCorecte.ToString();
			textIntrebariGresite.Text = NrIntrebariGresite.ToString();
			textIntrebariRamase.Text = (NrIntrebari - IntrebareCurenta - 1).ToString();
			NextButton.Enabled = true;
		}

		private void CitireFisier()
		{
			string filePath = @"../../input.txt";
			using (StreamReader sr = new StreamReader(filePath))
			{
				NrIntrebari = int.Parse(sr.ReadLine());
				IntrebareCurenta = -1;
				NrIntrebariCorecte = 0;
				NrIntrebariGresite = 0;
				sr.ReadLine();

				while (!sr.EndOfStream)
				{
					DateIntrebare intrebare = new DateIntrebare();
					intrebare.textIntrebare = sr.ReadLine();
					//intrebare.Optiuni = new List<string>();
					for (int i = 0; i < 4; i++)
					{
						intrebare.Optiuni[i] = sr.ReadLine();
					}
					for (int i = 0; i < 4; i++)
					{
						intrebare.raspunsuriCorecte[i] = sr.ReadLine().Contains("1");
					}
					intrebare.Poza = sr.ReadLine();
					dateIntrebare.Add(intrebare);
					sr.ReadLine();
				}
			}
		}

		private void CustomControl1_CustomEvent(object sender, EventArgs e)
		{
			// Handle the custom event
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			UpdateEcran();
		}
	}
}
