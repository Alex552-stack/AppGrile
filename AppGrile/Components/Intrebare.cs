using AppGrile.Clases;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppGrile.Components
{
	public partial class Intrebare : UserControl
	{
		DateIntrebare Date;
		public event EventHandler MyCustomAction;
		CheckBox[] Vector;
		bool ok;
		public Intrebare(DateIntrebare date)
		{
			Date = date;
			InitializeComponent();
			Vector = new CheckBox[date.Optiuni.Count()];
			Initializare();

		}

		private void Initializare()
		{
			NumeIntrebare.Text = Date.textIntrebare;
			TabelOptiuniIntrebare.AutoSize = false;
			TabelOptiuniIntrebare.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			for (int j = 0; j < Date.Optiuni.Count(); j++)
			{
				TabelOptiuniIntrebare.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

				CheckBox checkBox = new CheckBox();
				checkBox.Text = Date.Optiuni[j];
				checkBox.AutoSize = true;
				TabelOptiuniIntrebare.Controls.Add(checkBox, j, 0);
				Vector[j] = checkBox;
			}
			if(Date.Poza != "")
			{
				ContainerPoza.ImageLocation = $"../../Images/{Date.Poza}";
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			ok = true;
			for (int i = 0; i < Date.Optiuni.Count(); i++)
			{
				if (Vector[i].Checked != Date.raspunsuriCorecte[i])
				{
					ok = false;
					break;
				}
			}
			if (ok)
				button1.BackColor = Color.Green;
			else
				button1.BackColor = Color.Red;
			button1.Enabled = false;
			MyCustomAction.Invoke(ok, EventArgs.Empty);
		}
	}
}
