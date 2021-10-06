
namespace PRACA_NA_OCENE
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.imie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zatwierdz = new System.Windows.Forms.Label();
            this.przycisk_z = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(94, 72);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(100, 20);
            this.imie.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "badanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "imie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // zatwierdz
            // 
            this.zatwierdz.AutoSize = true;
            this.zatwierdz.Location = new System.Drawing.Point(118, 31);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(97, 13);
            this.zatwierdz.TabIndex = 7;
            this.zatwierdz.Text = "Zatwierdz pacjenta";
            // 
            // przycisk_z
            // 
            this.przycisk_z.Location = new System.Drawing.Point(215, 88);
            this.przycisk_z.Name = "przycisk_z";
            this.przycisk_z.Size = new System.Drawing.Size(75, 23);
            this.przycisk_z.TabIndex = 8;
            this.przycisk_z.Text = "zatwierdz";
            this.przycisk_z.UseVisualStyleBackColor = true;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(90, 152);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(200, 20);
            this.data.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "badanie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 184);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data);
            this.Controls.Add(this.przycisk_z);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label zatwierdz;
        private System.Windows.Forms.Button przycisk_z;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Label label5;
    }
}

