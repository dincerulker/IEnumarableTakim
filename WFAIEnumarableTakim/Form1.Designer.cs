
namespace WFAIEnumarableTakim
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
            this.btnGetir = new System.Windows.Forms.Button();
            this.lstFutbolcular = new System.Windows.Forms.ListBox();
            this.btnOyuncuEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFutbolcuAra = new System.Windows.Forms.Button();
            this.txtFutbolcuAraAdSoyad = new System.Windows.Forms.TextBox();
            this.nudFormaNoAra = new System.Windows.Forms.NumericUpDown();
            this.cboMevkiiAra = new System.Windows.Forms.ComboBox();
            this.btnMevkiiAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFormaNoAra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(12, 425);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(119, 23);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lstFutbolcular
            // 
            this.lstFutbolcular.FormattingEnabled = true;
            this.lstFutbolcular.Location = new System.Drawing.Point(13, 129);
            this.lstFutbolcular.Name = "lstFutbolcular";
            this.lstFutbolcular.Size = new System.Drawing.Size(378, 290);
            this.lstFutbolcular.TabIndex = 1;
            this.lstFutbolcular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFutbolcular_KeyDown);
            this.lstFutbolcular.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFutbolcular_MouseDoubleClick);
            // 
            // btnOyuncuEkle
            // 
            this.btnOyuncuEkle.Location = new System.Drawing.Point(273, 425);
            this.btnOyuncuEkle.Name = "btnOyuncuEkle";
            this.btnOyuncuEkle.Size = new System.Drawing.Size(118, 23);
            this.btnOyuncuEkle.TabIndex = 2;
            this.btnOyuncuEkle.Text = "OYUNCU EKLE";
            this.btnOyuncuEkle.UseVisualStyleBackColor = true;
            this.btnOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forma No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mevkii";
            // 
            // btnFutbolcuAra
            // 
            this.btnFutbolcuAra.Location = new System.Drawing.Point(212, 6);
            this.btnFutbolcuAra.Name = "btnFutbolcuAra";
            this.btnFutbolcuAra.Size = new System.Drawing.Size(177, 46);
            this.btnFutbolcuAra.TabIndex = 4;
            this.btnFutbolcuAra.Text = "Ada veya Formaya Göre Ara";
            this.btnFutbolcuAra.UseVisualStyleBackColor = true;
            this.btnFutbolcuAra.Click += new System.EventHandler(this.btnFutbolcuAra_Click);
            // 
            // txtFutbolcuAraAdSoyad
            // 
            this.txtFutbolcuAraAdSoyad.Location = new System.Drawing.Point(73, 6);
            this.txtFutbolcuAraAdSoyad.Name = "txtFutbolcuAraAdSoyad";
            this.txtFutbolcuAraAdSoyad.Size = new System.Drawing.Size(120, 20);
            this.txtFutbolcuAraAdSoyad.TabIndex = 5;
            // 
            // nudFormaNoAra
            // 
            this.nudFormaNoAra.Location = new System.Drawing.Point(74, 32);
            this.nudFormaNoAra.Name = "nudFormaNoAra";
            this.nudFormaNoAra.Size = new System.Drawing.Size(120, 20);
            this.nudFormaNoAra.TabIndex = 6;
            // 
            // cboMevkiiAra
            // 
            this.cboMevkiiAra.FormattingEnabled = true;
            this.cboMevkiiAra.Location = new System.Drawing.Point(73, 74);
            this.cboMevkiiAra.Name = "cboMevkiiAra";
            this.cboMevkiiAra.Size = new System.Drawing.Size(121, 21);
            this.cboMevkiiAra.TabIndex = 7;
            // 
            // btnMevkiiAra
            // 
            this.btnMevkiiAra.Location = new System.Drawing.Point(212, 74);
            this.btnMevkiiAra.Name = "btnMevkiiAra";
            this.btnMevkiiAra.Size = new System.Drawing.Size(177, 21);
            this.btnMevkiiAra.TabIndex = 4;
            this.btnMevkiiAra.Text = "Mevkiiye Göre Ara";
            this.btnMevkiiAra.UseVisualStyleBackColor = true;
            this.btnMevkiiAra.Click += new System.EventHandler(this.btnMevkiiAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 460);
            this.Controls.Add(this.cboMevkiiAra);
            this.Controls.Add(this.nudFormaNoAra);
            this.Controls.Add(this.txtFutbolcuAraAdSoyad);
            this.Controls.Add(this.btnMevkiiAra);
            this.Controls.Add(this.btnFutbolcuAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOyuncuEkle);
            this.Controls.Add(this.lstFutbolcular);
            this.Controls.Add(this.btnGetir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFormaNoAra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ListBox lstFutbolcular;
        private System.Windows.Forms.Button btnOyuncuEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFutbolcuAra;
        private System.Windows.Forms.TextBox txtFutbolcuAraAdSoyad;
        private System.Windows.Forms.NumericUpDown nudFormaNoAra;
        private System.Windows.Forms.ComboBox cboMevkiiAra;
        private System.Windows.Forms.Button btnMevkiiAra;
    }
}

