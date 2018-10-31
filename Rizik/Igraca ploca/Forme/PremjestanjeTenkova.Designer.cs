namespace Igraca_ploca
{
    partial class PremjestanjeTenkova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PremjestanjeTenkova));
            this.label_Premjestanje = new System.Windows.Forms.Label();
            this.sliderOdabrano = new System.Windows.Forms.TrackBar();
            this.buttonPremjesti = new System.Windows.Forms.Button();
            this.brojTenkova = new System.Windows.Forms.Label();
            this.label_Pobjednik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOdabrano)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Premjestanje
            // 
            this.label_Premjestanje.AutoSize = true;
            this.label_Premjestanje.Location = new System.Drawing.Point(12, 44);
            this.label_Premjestanje.Name = "label_Premjestanje";
            this.label_Premjestanje.Size = new System.Drawing.Size(202, 13);
            this.label_Premjestanje.TabIndex = 0;
            this.label_Premjestanje.Text = "Odaberite koliko tenkova želite premjestiti";
            // 
            // sliderOdabrano
            // 
            this.sliderOdabrano.LargeChange = 1;
            this.sliderOdabrano.Location = new System.Drawing.Point(20, 81);
            this.sliderOdabrano.Name = "sliderOdabrano";
            this.sliderOdabrano.Size = new System.Drawing.Size(395, 45);
            this.sliderOdabrano.TabIndex = 1;
            this.sliderOdabrano.Scroll += new System.EventHandler(this.sliderOdabrano_Scroll);
            // 
            // buttonPremjesti
            // 
            this.buttonPremjesti.Location = new System.Drawing.Point(335, 144);
            this.buttonPremjesti.Name = "buttonPremjesti";
            this.buttonPremjesti.Size = new System.Drawing.Size(75, 23);
            this.buttonPremjesti.TabIndex = 2;
            this.buttonPremjesti.Text = "Premjesti";
            this.buttonPremjesti.UseVisualStyleBackColor = true;
            this.buttonPremjesti.Click += new System.EventHandler(this.buttonPremjestiClick);
            // 
            // brojTenkova
            // 
            this.brojTenkova.AutoSize = true;
            this.brojTenkova.Location = new System.Drawing.Point(213, 129);
            this.brojTenkova.Name = "brojTenkova";
            this.brojTenkova.Size = new System.Drawing.Size(13, 13);
            this.brojTenkova.TabIndex = 3;
            this.brojTenkova.Text = "0";
            // 
            // label_Pobjednik
            // 
            this.label_Pobjednik.AutoSize = true;
            this.label_Pobjednik.Location = new System.Drawing.Point(12, 18);
            this.label_Pobjednik.Name = "label_Pobjednik";
            this.label_Pobjednik.Size = new System.Drawing.Size(34, 13);
            this.label_Pobjednik.TabIndex = 4;
            this.label_Pobjednik.Text = "Igrač ";
            // 
            // PremjestanjeTenkova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 179);
            this.Controls.Add(this.label_Pobjednik);
            this.Controls.Add(this.brojTenkova);
            this.Controls.Add(this.buttonPremjesti);
            this.Controls.Add(this.sliderOdabrano);
            this.Controls.Add(this.label_Premjestanje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PremjestanjeTenkova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pobjeda!";
            ((System.ComponentModel.ISupportInitialize)(this.sliderOdabrano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Premjestanje;
        private System.Windows.Forms.TrackBar sliderOdabrano;
        private System.Windows.Forms.Button buttonPremjesti;
        private System.Windows.Forms.Label brojTenkova;
        private System.Windows.Forms.Label label_Pobjednik;
    }
}