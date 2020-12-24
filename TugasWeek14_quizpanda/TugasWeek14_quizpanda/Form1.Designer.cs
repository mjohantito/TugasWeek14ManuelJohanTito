namespace TugasWeek14_quizpanda
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
            this.labelKalimat = new System.Windows.Forms.Label();
            this.labelHuruf = new System.Windows.Forms.Label();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxKalimat = new System.Windows.Forms.TextBox();
            this.textBoxHuruf = new System.Windows.Forms.TextBox();
            this.textBoxMenjadi = new System.Windows.Forms.TextBox();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.labelJudul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKalimat
            // 
            this.labelKalimat.AutoSize = true;
            this.labelKalimat.Location = new System.Drawing.Point(59, 120);
            this.labelKalimat.Name = "labelKalimat";
            this.labelKalimat.Size = new System.Drawing.Size(88, 13);
            this.labelKalimat.TabIndex = 0;
            this.labelKalimat.Text = "Masukan Kalimat";
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Location = new System.Drawing.Point(59, 172);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(80, 13);
            this.labelHuruf.TabIndex = 1;
            this.labelHuruf.Text = "Masukan Huruf";
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Location = new System.Drawing.Point(280, 172);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(44, 13);
            this.labelMenjadi.TabIndex = 2;
            this.labelMenjadi.Text = "Menjadi";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(59, 290);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(39, 13);
            this.labelHasil.TabIndex = 3;
            this.labelHasil.Text = "Hasil : ";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(159, 290);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(39, 13);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output";
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // textBoxKalimat
            // 
            this.textBoxKalimat.Location = new System.Drawing.Point(162, 120);
            this.textBoxKalimat.Name = "textBoxKalimat";
            this.textBoxKalimat.Size = new System.Drawing.Size(278, 20);
            this.textBoxKalimat.TabIndex = 5;
            this.textBoxKalimat.TextChanged += new System.EventHandler(this.textBoxKalimat_TextChanged);
            // 
            // textBoxHuruf
            // 
            this.textBoxHuruf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxHuruf.Location = new System.Drawing.Point(162, 169);
            this.textBoxHuruf.MaxLength = 1;
            this.textBoxHuruf.Name = "textBoxHuruf";
            this.textBoxHuruf.Size = new System.Drawing.Size(100, 20);
            this.textBoxHuruf.TabIndex = 6;
            // 
            // textBoxMenjadi
            // 
            this.textBoxMenjadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMenjadi.Location = new System.Drawing.Point(340, 169);
            this.textBoxMenjadi.MaxLength = 1;
            this.textBoxMenjadi.Name = "textBoxMenjadi";
            this.textBoxMenjadi.Size = new System.Drawing.Size(100, 20);
            this.textBoxMenjadi.TabIndex = 7;
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(162, 222);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(278, 23);
            this.buttonKonversi.TabIndex = 8;
            this.buttonKonversi.Text = "Konversi!";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(512, 21);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(276, 45);
            this.labelJudul.TabIndex = 9;
            this.labelJudul.Text = "QUIZ PANDAA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.textBoxMenjadi);
            this.Controls.Add(this.textBoxHuruf);
            this.Controls.Add(this.textBoxKalimat);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.labelHuruf);
            this.Controls.Add(this.labelKalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKalimat;
        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxKalimat;
        private System.Windows.Forms.TextBox textBoxHuruf;
        private System.Windows.Forms.TextBox textBoxMenjadi;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.Label labelJudul;
    }
}

