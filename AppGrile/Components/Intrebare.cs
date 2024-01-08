using AppGrile.Clases;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppGrile.Components
{
	public partial class Intrebare : UserControl
	{
		DateIntrebare Date; //datele intrebarii
		public event EventHandler MyCustomAction; //trigger pentru event in clasa parinte
		CheckBox[] Vector; 
		bool ok; //intrebare raspunsa corect/incorect
		public Intrebare(DateIntrebare date)
		{
			Date = date;
			InitializeComponent();
			Vector = new CheckBox[date.Optiuni.Count()]; // vector de marimea optiunilor(4)
			Initializare();

		}

		private void Initializare()
		{
			NumeIntrebare.Text = Date.textIntrebare; //intrebarea in sine
			TabelOptiuniIntrebare.AutoSize = false; //autosize
			TabelOptiuniIntrebare.RowStyles.Add(new RowStyle(SizeType.AutoSize)); //autosize
			for (int j = 0; j < Date.Optiuni.Count(); j++)
			{
				TabelOptiuniIntrebare.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); //autosize

				CheckBox checkBox = new CheckBox(); //checkBox element
				checkBox.Text = Date.Optiuni[j]; //text-ul optiunilor
				checkBox.AutoSize = false;
				checkBox.Size = new Size((int)TabelOptiuniIntrebare.ColumnStyles[j].Width*2, (int)TabelOptiuniIntrebare.RowStyles[0].Height*2);
				TabelOptiuniIntrebare.Controls.Add(checkBox, j, 0); //adaugat checkBox ul in grafica
				Vector[j] = checkBox; //salvat checkBox-ul
			}
			if(Date.Poza != "")
			{
				ContainerPoza.ImageLocation = $"../../Grila/{Date.Poza}"; //path poza
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			ok = true; //incep de la ideea ca intrebarea este raspunsa corect
			for (int i = 0; i < Date.Optiuni.Count(); i++)
			{
				if (Vector[i].Checked != Date.raspunsuriCorecte[i]) //caut situatie in care intrebarea este raspunsa incorect
				{
					ok = false;
					break;
				}
			}
			if (ok) //daca este corect, culoarea butonului verde
				button1.BackColor = Color.Green;
			else //daca este gresita, culoarea butonului rosu
				button1.BackColor = Color.Red;
			button1.Enabled = false; //acum pot sa trec la urmatoarea intrebare
			MyCustomAction.Invoke(ok, EventArgs.Empty); //folosit event-ul din clasa parinte 
		}
	}
}
