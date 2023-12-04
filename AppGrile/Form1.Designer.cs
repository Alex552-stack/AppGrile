namespace AppGrile
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textIntrebariRamase = new System.Windows.Forms.TextBox();
			this.textIntrebariGresite = new System.Windows.Forms.TextBox();
			this.textIntrebariCorecte = new System.Windows.Forms.TextBox();
			this.ContainerIntrebare = new System.Windows.Forms.Panel();
			this.NextButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textIntrebariRamase
			// 
			this.textIntrebariRamase.Enabled = false;
			this.textIntrebariRamase.Location = new System.Drawing.Point(12, 41);
			this.textIntrebariRamase.Name = "textIntrebariRamase";
			this.textIntrebariRamase.ReadOnly = true;
			this.textIntrebariRamase.Size = new System.Drawing.Size(205, 22);
			this.textIntrebariRamase.TabIndex = 1;
			this.textIntrebariRamase.Text = "ceva";
			this.textIntrebariRamase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textIntrebariGresite
			// 
			this.textIntrebariGresite.Enabled = false;
			this.textIntrebariGresite.Location = new System.Drawing.Point(283, 41);
			this.textIntrebariGresite.Name = "textIntrebariGresite";
			this.textIntrebariGresite.ReadOnly = true;
			this.textIntrebariGresite.Size = new System.Drawing.Size(205, 22);
			this.textIntrebariGresite.TabIndex = 2;
			this.textIntrebariGresite.Text = "ceva";
			this.textIntrebariGresite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textIntrebariCorecte
			// 
			this.textIntrebariCorecte.Enabled = false;
			this.textIntrebariCorecte.Location = new System.Drawing.Point(561, 41);
			this.textIntrebariCorecte.Name = "textIntrebariCorecte";
			this.textIntrebariCorecte.ReadOnly = true;
			this.textIntrebariCorecte.Size = new System.Drawing.Size(205, 22);
			this.textIntrebariCorecte.TabIndex = 3;
			this.textIntrebariCorecte.Text = "ceva";
			this.textIntrebariCorecte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ContainerIntrebare
			// 
			this.ContainerIntrebare.Location = new System.Drawing.Point(12, 114);
			this.ContainerIntrebare.Name = "ContainerIntrebare";
			this.ContainerIntrebare.Size = new System.Drawing.Size(776, 282);
			this.ContainerIntrebare.TabIndex = 4;
			// 
			// NextButton
			// 
			this.NextButton.Enabled = false;
			this.NextButton.Location = new System.Drawing.Point(539, 415);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(227, 23);
			this.NextButton.TabIndex = 5;
			this.NextButton.Text = "Next";
			this.NextButton.UseVisualStyleBackColor = true;
			this.NextButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(587, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Intrebari raspunse corect";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(315, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Intrebari raspunse incorect";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Intrebari ramase";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NextButton);
			this.Controls.Add(this.ContainerIntrebare);
			this.Controls.Add(this.textIntrebariCorecte);
			this.Controls.Add(this.textIntrebariGresite);
			this.Controls.Add(this.textIntrebariRamase);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textIntrebariRamase;
		private System.Windows.Forms.TextBox textIntrebariGresite;
		private System.Windows.Forms.TextBox textIntrebariCorecte;
		private System.Windows.Forms.Panel ContainerIntrebare;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

