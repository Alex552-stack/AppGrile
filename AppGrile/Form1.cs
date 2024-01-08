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
		FileReader fileReader;
		private int IntrebareCurenta = 0;
		private int NrIntrebariCorecte = 0;
		private int NrIntrebariGresite = 0;
		int NrIntrebari;

		public Form1()
		{
			InitializeComponent();
			CitireFisier();
			UpdateEcran();
			textIntrebariCorecte.Text = NrIntrebariCorecte.ToString(); //init text
			textIntrebariGresite.Text = NrIntrebariGresite.ToString(); //init text
			textIntrebariRamase.Text = (NrIntrebari - IntrebareCurenta - 1).ToString(); //init text
		}
		private void UpdateEcran()
		{
			if (IntrebareCurenta + 1 < NrIntrebari) //atata timp cat nu s-a ajuns la sfarsit
			{
				ContainerIntrebare.Controls.Clear(); //sterge intrebarea curenta
				NextButton.Enabled = false; //disable la butonul de mers mai departe
				IntrebareCurenta++; 
				Intrebare intrebare = new Intrebare(fileReader.Read()); //creare obiect now de tip Intrebare
				intrebare.Text = "Custom Element"; 
				intrebare.MyCustomAction += Intrebare_MyActionOccurred; //trigger ul de event(imi permite sa accesez o functie din acest obiect din clasa Intrebare)
				intrebare.Dock = DockStyle.Bottom;
				ContainerIntrebare.Controls.Add(intrebare); //adaugarea intrebarii pe ecran
				
			}
			else //daca s-a ajuns la final
			{
				ContainerIntrebare.Controls.Clear(); //sterge intrebarea
				ContainerIntrebare.Controls.Add(new EcranFinal()); //adauga ecranul final
				NextButton.Enabled = false; 
			}
		}

		private void Intrebare_MyActionOccurred(object sender, EventArgs e) //evenimentul care e apelat din intrebare
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
			string filePath = @"../../Grila/test1.txt";
			fileReader = new FileReader(filePath);
			NrIntrebari = fileReader.NrIntrebari;
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
