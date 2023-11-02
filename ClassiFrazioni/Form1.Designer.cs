namespace ClassiFrazioni
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.somm = new System.Windows.Forms.Button();
            this.sottr = new System.Windows.Forms.Button();
            this.molt = new System.Windows.Forms.Button();
            this.divisione = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.den2 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.den1 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ristext = new System.Windows.Forms.TextBox();
            this.sempl = new System.Windows.Forms.Button();
            this.Vdec = new System.Windows.Forms.Button();
            this.Vfraz = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numdec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operazioni Frazioni";
            // 
            // somm
            // 
            this.somm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somm.Location = new System.Drawing.Point(20, 241);
            this.somm.Name = "somm";
            this.somm.Size = new System.Drawing.Size(266, 40);
            this.somm.TabIndex = 2;
            this.somm.Text = "Somma";
            this.somm.UseVisualStyleBackColor = true;
            this.somm.Click += new System.EventHandler(this.somm_Click);
            // 
            // sottr
            // 
            this.sottr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sottr.Location = new System.Drawing.Point(20, 287);
            this.sottr.Name = "sottr";
            this.sottr.Size = new System.Drawing.Size(266, 40);
            this.sottr.TabIndex = 3;
            this.sottr.Text = "Sottrai";
            this.sottr.UseVisualStyleBackColor = true;
            this.sottr.Click += new System.EventHandler(this.sottr_Click);
            // 
            // molt
            // 
            this.molt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.molt.Location = new System.Drawing.Point(20, 333);
            this.molt.Name = "molt";
            this.molt.Size = new System.Drawing.Size(266, 40);
            this.molt.TabIndex = 4;
            this.molt.Text = "Moltiplica";
            this.molt.UseVisualStyleBackColor = true;
            this.molt.Click += new System.EventHandler(this.molt_Click);
            // 
            // divisione
            // 
            this.divisione.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisione.Location = new System.Drawing.Point(20, 379);
            this.divisione.Name = "divisione";
            this.divisione.Size = new System.Drawing.Size(266, 40);
            this.divisione.TabIndex = 5;
            this.divisione.Text = "Dividi";
            this.divisione.UseVisualStyleBackColor = true;
            this.divisione.Click += new System.EventHandler(this.divisione_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Denominatore";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Numeratore";
            // 
            // den2
            // 
            this.den2.Location = new System.Drawing.Point(181, 145);
            this.den2.Multiline = true;
            this.den2.Name = "den2";
            this.den2.Size = new System.Drawing.Size(105, 27);
            this.den2.TabIndex = 12;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(20, 145);
            this.num2.Multiline = true;
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(97, 27);
            this.num2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Denominatore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Numeratore";
            // 
            // den1
            // 
            this.den1.Location = new System.Drawing.Point(181, 85);
            this.den1.Multiline = true;
            this.den1.Name = "den1";
            this.den1.Size = new System.Drawing.Size(105, 27);
            this.den1.TabIndex = 17;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(20, 85);
            this.num1.Multiline = true;
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(97, 27);
            this.num1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Risultato";
            // 
            // ristext
            // 
            this.ristext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ristext.Location = new System.Drawing.Point(460, 153);
            this.ristext.Multiline = true;
            this.ristext.Name = "ristext";
            this.ristext.Size = new System.Drawing.Size(159, 128);
            this.ristext.TabIndex = 23;
            // 
            // sempl
            // 
            this.sempl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sempl.Location = new System.Drawing.Point(20, 195);
            this.sempl.Name = "sempl";
            this.sempl.Size = new System.Drawing.Size(266, 40);
            this.sempl.TabIndex = 24;
            this.sempl.Text = "Semplifica";
            this.sempl.UseVisualStyleBackColor = true;
            this.sempl.Click += new System.EventHandler(this.sempl_Click);
            // 
            // Vdec
            // 
            this.Vdec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vdec.Location = new System.Drawing.Point(292, 333);
            this.Vdec.Name = "Vdec";
            this.Vdec.Size = new System.Drawing.Size(266, 40);
            this.Vdec.TabIndex = 25;
            this.Vdec.Text = "Decimale";
            this.Vdec.UseVisualStyleBackColor = true;
            this.Vdec.Click += new System.EventHandler(this.Vdec_Click);
            // 
            // Vfraz
            // 
            this.Vfraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vfraz.Location = new System.Drawing.Point(292, 379);
            this.Vfraz.Name = "Vfraz";
            this.Vfraz.Size = new System.Drawing.Size(266, 40);
            this.Vfraz.TabIndex = 26;
            this.Vfraz.Text = "Frazione";
            this.Vfraz.UseVisualStyleBackColor = true;
            this.Vfraz.Click += new System.EventHandler(this.Vfraz_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Numero decimale";
            // 
            // numdec
            // 
            this.numdec.Location = new System.Drawing.Point(592, 346);
            this.numdec.Multiline = true;
            this.numdec.Name = "numdec";
            this.numdec.Size = new System.Drawing.Size(105, 27);
            this.numdec.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numdec);
            this.Controls.Add(this.Vfraz);
            this.Controls.Add(this.Vdec);
            this.Controls.Add(this.sempl);
            this.Controls.Add(this.ristext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.den1);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.den2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.divisione);
            this.Controls.Add(this.molt);
            this.Controls.Add(this.sottr);
            this.Controls.Add(this.somm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button somm;
        private System.Windows.Forms.Button sottr;
        private System.Windows.Forms.Button molt;
        private System.Windows.Forms.Button divisione;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox den2;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox den1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ristext;
        private System.Windows.Forms.Button sempl;
        private System.Windows.Forms.Button Vdec;
        private System.Windows.Forms.Button Vfraz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox numdec;
    }
}

