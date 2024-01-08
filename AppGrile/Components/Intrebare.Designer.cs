namespace AppGrile.Components
{
	partial class Intrebare
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intrebare));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.NumeIntrebare = new System.Windows.Forms.MaskedTextBox();
			this.ContainerPoza = new System.Windows.Forms.PictureBox();
			this.TabelOptiuniIntrebare = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ContainerPoza)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(384, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(8, 22);
			this.textBox1.TabIndex = 1;
			// 
			// NumeIntrebare
			// 
			this.NumeIntrebare.Location = new System.Drawing.Point(3, 16);
			this.NumeIntrebare.Name = "NumeIntrebare";
			this.NumeIntrebare.Size = new System.Drawing.Size(617, 22);
			this.NumeIntrebare.TabIndex = 2;
			this.NumeIntrebare.Text = "Ceva";
			// 
			// ContainerPoza
			// 
			this.ContainerPoza.BackColor = System.Drawing.Color.Transparent;
			this.ContainerPoza.Image = ((System.Drawing.Image)(resources.GetObject("ContainerPoza.Image")));
			this.ContainerPoza.Location = new System.Drawing.Point(626, 0);
			this.ContainerPoza.Name = "ContainerPoza";
			this.ContainerPoza.Size = new System.Drawing.Size(317, 238);
			this.ContainerPoza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ContainerPoza.TabIndex = 3;
			this.ContainerPoza.TabStop = false;
			// 
			// TabelOptiuniIntrebare
			// 
			this.TabelOptiuniIntrebare.AutoSize = true;
			this.TabelOptiuniIntrebare.ColumnCount = 4;
			this.TabelOptiuniIntrebare.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.77419F));
			this.TabelOptiuniIntrebare.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.22581F));
			this.TabelOptiuniIntrebare.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
			this.TabelOptiuniIntrebare.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
			this.TabelOptiuniIntrebare.Location = new System.Drawing.Point(3, 44);
			this.TabelOptiuniIntrebare.Name = "TabelOptiuniIntrebare";
			this.TabelOptiuniIntrebare.RowCount = 1;
			this.TabelOptiuniIntrebare.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TabelOptiuniIntrebare.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TabelOptiuniIntrebare.Size = new System.Drawing.Size(617, 105);
			this.TabelOptiuniIntrebare.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(125, 155);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(377, 43);
			this.button1.TabIndex = 5;
			this.button1.Text = "Trimite";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Intrebare
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.TabelOptiuniIntrebare);
			this.Controls.Add(this.ContainerPoza);
			this.Controls.Add(this.NumeIntrebare);
			this.Controls.Add(this.textBox1);
			this.Name = "Intrebare";
			this.Size = new System.Drawing.Size(943, 241);
			((System.ComponentModel.ISupportInitialize)(this.ContainerPoza)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MaskedTextBox NumeIntrebare;
		private System.Windows.Forms.PictureBox ContainerPoza;
		private System.Windows.Forms.TableLayoutPanel TabelOptiuniIntrebare;
		private System.Windows.Forms.Button button1;
	}
}
