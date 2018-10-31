namespace Igraca_ploca
{
    partial class IgracaPloca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IgracaPloca));
            this.panel_polje = new System.Windows.Forms.Panel();
            this.button_zavrsiPotez = new System.Windows.Forms.Button();
            this.label_brPobjeda1 = new System.Windows.Forms.Label();
            this.label_brPobjeda2 = new System.Windows.Forms.Label();
            this.label_TI = new System.Windows.Forms.Label();
            this.label_BP = new System.Windows.Forms.Label();
            this.label_TrenutniIgrac = new System.Windows.Forms.Label();
            this.label_PostavljanjeTenkova = new System.Windows.Forms.Label();
            this.button_izlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_polje
            // 
            this.panel_polje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_polje.BackgroundImage")));
            this.panel_polje.Location = new System.Drawing.Point(25, 25);
            this.panel_polje.Name = "panel_polje";
            this.panel_polje.Size = new System.Drawing.Size(700, 500);
            this.panel_polje.TabIndex = 0;
            this.panel_polje.Paint += new System.Windows.Forms.PaintEventHandler(this.refreshBojnogPolja);
            this.panel_polje.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_bojnoPolje_MouseUp);
            // 
            // button_zavrsiPotez
            // 
            this.button_zavrsiPotez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zavrsiPotez.Location = new System.Drawing.Point(752, 242);
            this.button_zavrsiPotez.Name = "button_zavrsiPotez";
            this.button_zavrsiPotez.Size = new System.Drawing.Size(120, 50);
            this.button_zavrsiPotez.TabIndex = 1;
            this.button_zavrsiPotez.Text = "Završi potez bez napada";
            this.button_zavrsiPotez.UseVisualStyleBackColor = true;
            this.button_zavrsiPotez.Click += new System.EventHandler(this.button_zavrsiPotez_Click);
            // 
            // label_brPobjeda1
            // 
            this.label_brPobjeda1.AutoSize = true;
            this.label_brPobjeda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brPobjeda1.Location = new System.Drawing.Point(749, 92);
            this.label_brPobjeda1.Name = "label_brPobjeda1";
            this.label_brPobjeda1.Size = new System.Drawing.Size(12, 16);
            this.label_brPobjeda1.TabIndex = 2;
            this.label_brPobjeda1.Text = "/";
            // 
            // label_brPobjeda2
            // 
            this.label_brPobjeda2.AutoSize = true;
            this.label_brPobjeda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brPobjeda2.Location = new System.Drawing.Point(749, 118);
            this.label_brPobjeda2.Name = "label_brPobjeda2";
            this.label_brPobjeda2.Size = new System.Drawing.Size(12, 16);
            this.label_brPobjeda2.TabIndex = 3;
            this.label_brPobjeda2.Text = "\\";
            // 
            // label_TI
            // 
            this.label_TI.AutoSize = true;
            this.label_TI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_TI.Location = new System.Drawing.Point(749, 25);
            this.label_TI.Name = "label_TI";
            this.label_TI.Size = new System.Drawing.Size(70, 16);
            this.label_TI.TabIndex = 4;
            this.label_TI.Text = "Sada igra:";
            // 
            // label_BP
            // 
            this.label_BP.AutoSize = true;
            this.label_BP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_BP.Location = new System.Drawing.Point(749, 62);
            this.label_BP.Name = "label_BP";
            this.label_BP.Size = new System.Drawing.Size(89, 16);
            this.label_BP.TabIndex = 5;
            this.label_BP.Text = "Broj pobjeda:";
            // 
            // label_TrenutniIgrac
            // 
            this.label_TrenutniIgrac.AutoSize = true;
            this.label_TrenutniIgrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_TrenutniIgrac.Location = new System.Drawing.Point(825, 25);
            this.label_TrenutniIgrac.Name = "label_TrenutniIgrac";
            this.label_TrenutniIgrac.Size = new System.Drawing.Size(12, 16);
            this.label_TrenutniIgrac.TabIndex = 6;
            this.label_TrenutniIgrac.Text = "/";
            // 
            // label_PostavljanjeTenkova
            // 
            this.label_PostavljanjeTenkova.AutoSize = true;
            this.label_PostavljanjeTenkova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PostavljanjeTenkova.Location = new System.Drawing.Point(749, 183);
            this.label_PostavljanjeTenkova.Name = "label_PostavljanjeTenkova";
            this.label_PostavljanjeTenkova.Size = new System.Drawing.Size(159, 16);
            this.label_PostavljanjeTenkova.TabIndex = 7;
            this.label_PostavljanjeTenkova.Text = "Broj tenkova za postaviti: ";
            // 
            // button_izlaz
            // 
            this.button_izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_izlaz.Location = new System.Drawing.Point(786, 471);
            this.button_izlaz.Name = "button_izlaz";
            this.button_izlaz.Size = new System.Drawing.Size(111, 54);
            this.button_izlaz.TabIndex = 8;
            this.button_izlaz.Text = "Izlaz iz igre";
            this.button_izlaz.UseVisualStyleBackColor = true;
            this.button_izlaz.Click += new System.EventHandler(this.button_izlaz_Click);
            // 
            // IgracaPloca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(942, 548);
            this.Controls.Add(this.button_izlaz);
            this.Controls.Add(this.label_PostavljanjeTenkova);
            this.Controls.Add(this.label_TrenutniIgrac);
            this.Controls.Add(this.label_BP);
            this.Controls.Add(this.label_TI);
            this.Controls.Add(this.label_brPobjeda2);
            this.Controls.Add(this.label_brPobjeda1);
            this.Controls.Add(this.button_zavrsiPotez);
            this.Controls.Add(this.panel_polje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IgracaPloca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RIZIK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_polje;
        private System.Windows.Forms.Button button_zavrsiPotez;
        private System.Windows.Forms.Label label_brPobjeda1;
        private System.Windows.Forms.Label label_brPobjeda2;
        private System.Windows.Forms.Label label_TI;
        private System.Windows.Forms.Label label_BP;
        private System.Windows.Forms.Label label_TrenutniIgrac;
        private System.Windows.Forms.Label label_PostavljanjeTenkova;
        private System.Windows.Forms.Button button_izlaz;
    }
}

