namespace Igraca_ploca
{
    partial class PocetniEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetniEkran));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Igrac1 = new System.Windows.Forms.TextBox();
            this.textBox_Igrac2 = new System.Windows.Forms.TextBox();
            this.groupBox_Igrac1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Zelena1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Zuta1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Plava1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Crvena1 = new System.Windows.Forms.RadioButton();
            this.groupBox_Igrac2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Zelena2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Zuta2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Plava2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Crvena2 = new System.Windows.Forms.RadioButton();
            this.button_Kreni = new System.Windows.Forms.Button();
            this.button_Povratak = new System.Windows.Forms.Button();
            this.groupBox_Igrac1.SuspendLayout();
            this.groupBox_Igrac2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Igrač 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(242, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Igrač 2:";
            // 
            // textBox_Igrac1
            // 
            this.textBox_Igrac1.Location = new System.Drawing.Point(64, 25);
            this.textBox_Igrac1.Name = "textBox_Igrac1";
            this.textBox_Igrac1.Size = new System.Drawing.Size(145, 21);
            this.textBox_Igrac1.TabIndex = 4;
            // 
            // textBox_Igrac2
            // 
            this.textBox_Igrac2.Location = new System.Drawing.Point(290, 25);
            this.textBox_Igrac2.Name = "textBox_Igrac2";
            this.textBox_Igrac2.Size = new System.Drawing.Size(145, 21);
            this.textBox_Igrac2.TabIndex = 5;
            // 
            // groupBox_Igrac1
            // 
            this.groupBox_Igrac1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Igrac1.Controls.Add(this.radioButton_Zelena1);
            this.groupBox_Igrac1.Controls.Add(this.radioButton_Zuta1);
            this.groupBox_Igrac1.Controls.Add(this.radioButton_Plava1);
            this.groupBox_Igrac1.Controls.Add(this.radioButton_Crvena1);
            this.groupBox_Igrac1.Location = new System.Drawing.Point(19, 66);
            this.groupBox_Igrac1.Name = "groupBox_Igrac1";
            this.groupBox_Igrac1.Size = new System.Drawing.Size(190, 167);
            this.groupBox_Igrac1.TabIndex = 6;
            this.groupBox_Igrac1.TabStop = false;
            this.groupBox_Igrac1.Text = "Boja:";
            // 
            // radioButton_Zelena1
            // 
            this.radioButton_Zelena1.AutoSize = true;
            this.radioButton_Zelena1.ForeColor = System.Drawing.Color.Green;
            this.radioButton_Zelena1.Location = new System.Drawing.Point(45, 115);
            this.radioButton_Zelena1.Name = "radioButton_Zelena1";
            this.radioButton_Zelena1.Size = new System.Drawing.Size(63, 19);
            this.radioButton_Zelena1.TabIndex = 3;
            this.radioButton_Zelena1.TabStop = true;
            this.radioButton_Zelena1.Text = "Zelena";
            this.radioButton_Zelena1.UseVisualStyleBackColor = true;
            this.radioButton_Zelena1.CheckedChanged += new System.EventHandler(this.odabirIgrac);
            // 
            // radioButton_Zuta1
            // 
            this.radioButton_Zuta1.AutoSize = true;
            this.radioButton_Zuta1.ForeColor = System.Drawing.Color.Yellow;
            this.radioButton_Zuta1.Location = new System.Drawing.Point(45, 89);
            this.radioButton_Zuta1.Name = "radioButton_Zuta1";
            this.radioButton_Zuta1.Size = new System.Drawing.Size(49, 19);
            this.radioButton_Zuta1.TabIndex = 2;
            this.radioButton_Zuta1.TabStop = true;
            this.radioButton_Zuta1.Text = "Žuta";
            this.radioButton_Zuta1.UseVisualStyleBackColor = true;
            this.radioButton_Zuta1.CheckedChanged += new System.EventHandler(this.odabirIgrac);
            // 
            // radioButton_Plava1
            // 
            this.radioButton_Plava1.AutoSize = true;
            this.radioButton_Plava1.ForeColor = System.Drawing.Color.Blue;
            this.radioButton_Plava1.Location = new System.Drawing.Point(45, 64);
            this.radioButton_Plava1.Name = "radioButton_Plava1";
            this.radioButton_Plava1.Size = new System.Drawing.Size(55, 19);
            this.radioButton_Plava1.TabIndex = 1;
            this.radioButton_Plava1.TabStop = true;
            this.radioButton_Plava1.Text = "Plava";
            this.radioButton_Plava1.UseVisualStyleBackColor = true;
            this.radioButton_Plava1.CheckedChanged += new System.EventHandler(this.odabirIgrac);
            // 
            // radioButton_Crvena1
            // 
            this.radioButton_Crvena1.AutoSize = true;
            this.radioButton_Crvena1.ForeColor = System.Drawing.Color.Red;
            this.radioButton_Crvena1.Location = new System.Drawing.Point(45, 39);
            this.radioButton_Crvena1.Name = "radioButton_Crvena1";
            this.radioButton_Crvena1.Size = new System.Drawing.Size(64, 19);
            this.radioButton_Crvena1.TabIndex = 0;
            this.radioButton_Crvena1.TabStop = true;
            this.radioButton_Crvena1.Text = "Crvena";
            this.radioButton_Crvena1.UseVisualStyleBackColor = true;
            this.radioButton_Crvena1.CheckedChanged += new System.EventHandler(this.odabirIgrac);
            // 
            // groupBox_Igrac2
            // 
            this.groupBox_Igrac2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Igrac2.Controls.Add(this.radioButton_Zelena2);
            this.groupBox_Igrac2.Controls.Add(this.radioButton_Zuta2);
            this.groupBox_Igrac2.Controls.Add(this.radioButton_Plava2);
            this.groupBox_Igrac2.Controls.Add(this.radioButton_Crvena2);
            this.groupBox_Igrac2.Location = new System.Drawing.Point(245, 66);
            this.groupBox_Igrac2.Name = "groupBox_Igrac2";
            this.groupBox_Igrac2.Size = new System.Drawing.Size(190, 167);
            this.groupBox_Igrac2.TabIndex = 7;
            this.groupBox_Igrac2.TabStop = false;
            this.groupBox_Igrac2.Text = "Boja:";
            // 
            // radioButton_Zelena2
            // 
            this.radioButton_Zelena2.AutoSize = true;
            this.radioButton_Zelena2.ForeColor = System.Drawing.Color.Green;
            this.radioButton_Zelena2.Location = new System.Drawing.Point(45, 115);
            this.radioButton_Zelena2.Name = "radioButton_Zelena2";
            this.radioButton_Zelena2.Size = new System.Drawing.Size(63, 19);
            this.radioButton_Zelena2.TabIndex = 3;
            this.radioButton_Zelena2.TabStop = true;
            this.radioButton_Zelena2.Text = "Zelena";
            this.radioButton_Zelena2.UseVisualStyleBackColor = true;
            this.radioButton_Zelena2.CheckedChanged += new System.EventHandler(this.odabirIgrac);
            // 
            // radioButton_Zuta2
            // 
            this.radioButton_Zuta2.AutoSize = true;
            this.radioButton_Zuta2.ForeColor = System.Drawing.Color.Yellow;
            this.radioButton_Zuta2.Location = new System.Drawing.Point(45, 90);
            this.radioButton_Zuta2.Name = "radioButton_Zuta2";
            this.radioButton_Zuta2.Size = new System.Drawing.Size(49, 19);
            this.radioButton_Zuta2.TabIndex = 2;
            this.radioButton_Zuta2.TabStop = true;
            this.radioButton_Zuta2.Text = "Žuta";
            this.radioButton_Zuta2.UseVisualStyleBackColor = true;
            this.radioButton_Zuta2.CheckedChanged += new System.EventHandler(this.odabirIgrac);
            // 
            // radioButton_Plava2
            // 
            this.radioButton_Plava2.AutoSize = true;
            this.radioButton_Plava2.ForeColor = System.Drawing.Color.Blue;
            this.radioButton_Plava2.Location = new System.Drawing.Point(45, 65);
            this.radioButton_Plava2.Name = "radioButton_Plava2";
            this.radioButton_Plava2.Size = new System.Drawing.Size(55, 19);
            this.radioButton_Plava2.TabIndex = 1;
            this.radioButton_Plava2.TabStop = true;
            this.radioButton_Plava2.Text = "Plava";
            this.radioButton_Plava2.UseVisualStyleBackColor = true;
            this.radioButton_Plava2.CheckedChanged += new System.EventHandler(this.odabirIgrac);
            // 
            // radioButton_Crvena2
            // 
            this.radioButton_Crvena2.AutoSize = true;
            this.radioButton_Crvena2.ForeColor = System.Drawing.Color.Red;
            this.radioButton_Crvena2.Location = new System.Drawing.Point(45, 40);
            this.radioButton_Crvena2.Name = "radioButton_Crvena2";
            this.radioButton_Crvena2.Size = new System.Drawing.Size(64, 19);
            this.radioButton_Crvena2.TabIndex = 0;
            this.radioButton_Crvena2.TabStop = true;
            this.radioButton_Crvena2.Text = "Crvena";
            this.radioButton_Crvena2.UseVisualStyleBackColor = true;
            this.radioButton_Crvena2.CheckedChanged += new System.EventHandler(this.odabirIgrac);
            // 
            // button_Kreni
            // 
            this.button_Kreni.Location = new System.Drawing.Point(245, 256);
            this.button_Kreni.Name = "button_Kreni";
            this.button_Kreni.Size = new System.Drawing.Size(75, 25);
            this.button_Kreni.TabIndex = 8;
            this.button_Kreni.Text = "Kreni";
            this.button_Kreni.UseVisualStyleBackColor = true;
            this.button_Kreni.Click += new System.EventHandler(this.button_Kreni_Click);
            // 
            // button_Povratak
            // 
            this.button_Povratak.Location = new System.Drawing.Point(134, 256);
            this.button_Povratak.Name = "button_Povratak";
            this.button_Povratak.Size = new System.Drawing.Size(75, 25);
            this.button_Povratak.TabIndex = 9;
            this.button_Povratak.Text = "Povratak";
            this.button_Povratak.UseVisualStyleBackColor = true;
            this.button_Povratak.Click += new System.EventHandler(this.button_Povratak_Click);
            // 
            // PocetniEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(456, 303);
            this.Controls.Add(this.button_Povratak);
            this.Controls.Add(this.button_Kreni);
            this.Controls.Add(this.groupBox_Igrac2);
            this.Controls.Add(this.groupBox_Igrac1);
            this.Controls.Add(this.textBox_Igrac2);
            this.Controls.Add(this.textBox_Igrac1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PocetniEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " RIZIK";
            this.groupBox_Igrac1.ResumeLayout(false);
            this.groupBox_Igrac1.PerformLayout();
            this.groupBox_Igrac2.ResumeLayout(false);
            this.groupBox_Igrac2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Igrac1;
        private System.Windows.Forms.TextBox textBox_Igrac2;
        private System.Windows.Forms.GroupBox groupBox_Igrac1;
        private System.Windows.Forms.RadioButton radioButton_Zelena1;
        private System.Windows.Forms.RadioButton radioButton_Zuta1;
        private System.Windows.Forms.RadioButton radioButton_Plava1;
        private System.Windows.Forms.RadioButton radioButton_Crvena1;
        private System.Windows.Forms.GroupBox groupBox_Igrac2;
        private System.Windows.Forms.RadioButton radioButton_Zelena2;
        private System.Windows.Forms.RadioButton radioButton_Zuta2;
        private System.Windows.Forms.RadioButton radioButton_Plava2;
        private System.Windows.Forms.RadioButton radioButton_Crvena2;
        private System.Windows.Forms.Button button_Kreni;
        private System.Windows.Forms.Button button_Povratak;
    }
}