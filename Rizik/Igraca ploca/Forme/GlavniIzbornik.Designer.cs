namespace Igraca_ploca
{
    partial class GlavniIzbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavniIzbornik));
            this.button_NovaIgra = new System.Windows.Forms.Button();
            this.button_Statistika = new System.Windows.Forms.Button();
            this.button_O_Igri = new System.Windows.Forms.Button();
            this.button_PravilaIgre = new System.Windows.Forms.Button();
            this.button_Izlaz = new System.Windows.Forms.Button();
            this.label_Rizik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_NovaIgra
            // 
            this.button_NovaIgra.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_NovaIgra.Location = new System.Drawing.Point(37, 36);
            this.button_NovaIgra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_NovaIgra.Name = "button_NovaIgra";
            this.button_NovaIgra.Size = new System.Drawing.Size(175, 75);
            this.button_NovaIgra.TabIndex = 0;
            this.button_NovaIgra.Text = "Nova igra";
            this.button_NovaIgra.UseVisualStyleBackColor = true;
            this.button_NovaIgra.Click += new System.EventHandler(this.button_NovaIgra_Click);
            // 
            // button_Statistika
            // 
            this.button_Statistika.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Statistika.Location = new System.Drawing.Point(37, 132);
            this.button_Statistika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Statistika.Name = "button_Statistika";
            this.button_Statistika.Size = new System.Drawing.Size(175, 75);
            this.button_Statistika.TabIndex = 1;
            this.button_Statistika.Text = "Statistika";
            this.button_Statistika.UseVisualStyleBackColor = true;
            this.button_Statistika.Click += new System.EventHandler(this.button_Statistika_Click);
            // 
            // button_O_Igri
            // 
            this.button_O_Igri.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_O_Igri.Location = new System.Drawing.Point(240, 132);
            this.button_O_Igri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_O_Igri.Name = "button_O_Igri";
            this.button_O_Igri.Size = new System.Drawing.Size(175, 75);
            this.button_O_Igri.TabIndex = 3;
            this.button_O_Igri.Text = "O igri";
            this.button_O_Igri.UseVisualStyleBackColor = true;
            this.button_O_Igri.Click += new System.EventHandler(this.button_O_Igri_Click);
            // 
            // button_PravilaIgre
            // 
            this.button_PravilaIgre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_PravilaIgre.Location = new System.Drawing.Point(240, 36);
            this.button_PravilaIgre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_PravilaIgre.Name = "button_PravilaIgre";
            this.button_PravilaIgre.Size = new System.Drawing.Size(175, 75);
            this.button_PravilaIgre.TabIndex = 5;
            this.button_PravilaIgre.Text = "Pravila igre";
            this.button_PravilaIgre.UseVisualStyleBackColor = true;
            this.button_PravilaIgre.Click += new System.EventHandler(this.button_PravilaIgre_Click);
            // 
            // button_Izlaz
            // 
            this.button_Izlaz.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Izlaz.Location = new System.Drawing.Point(328, 231);
            this.button_Izlaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Izlaz.Name = "button_Izlaz";
            this.button_Izlaz.Size = new System.Drawing.Size(87, 36);
            this.button_Izlaz.TabIndex = 7;
            this.button_Izlaz.Text = "Izlaz";
            this.button_Izlaz.UseVisualStyleBackColor = true;
            this.button_Izlaz.Click += new System.EventHandler(this.button_Izlaz_Click);
            // 
            // label_Rizik
            // 
            this.label_Rizik.AutoSize = true;
            this.label_Rizik.BackColor = System.Drawing.Color.Transparent;
            this.label_Rizik.ForeColor = System.Drawing.Color.Red;
            this.label_Rizik.Location = new System.Drawing.Point(14, 276);
            this.label_Rizik.Name = "label_Rizik";
            this.label_Rizik.Size = new System.Drawing.Size(76, 16);
            this.label_Rizik.TabIndex = 8;
            this.label_Rizik.Text = "Rizik v1.00";
            // 
            // GlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(456, 303);
            this.Controls.Add(this.label_Rizik);
            this.Controls.Add(this.button_Izlaz);
            this.Controls.Add(this.button_PravilaIgre);
            this.Controls.Add(this.button_O_Igri);
            this.Controls.Add(this.button_Statistika);
            this.Controls.Add(this.button_NovaIgra);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " RIZIK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_NovaIgra;
        private System.Windows.Forms.Button button_Statistika;
        private System.Windows.Forms.Button button_O_Igri;
        private System.Windows.Forms.Button button_PravilaIgre;
        private System.Windows.Forms.Button button_Izlaz;
        private System.Windows.Forms.Label label_Rizik;
    }
}