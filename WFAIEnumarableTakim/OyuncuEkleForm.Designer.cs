
namespace WFAIEnumarableTakim
{
    partial class OyuncuEkleForm
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.cmbMevkii = new System.Windows.Forms.ComboBox();
            this.nudFormaNo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle2 = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFormaNo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(110, 6);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(138, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // cmbMevkii
            // 
            this.cmbMevkii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMevkii.FormattingEnabled = true;
            this.cmbMevkii.Items.AddRange(new object[] {
            "Kaleci",
            "Defans",
            "Ortasaha",
            "Forvet"});
            this.cmbMevkii.Location = new System.Drawing.Point(110, 36);
            this.cmbMevkii.Name = "cmbMevkii";
            this.cmbMevkii.Size = new System.Drawing.Size(138, 21);
            this.cmbMevkii.TabIndex = 1;
            // 
            // nudFormaNo
            // 
            this.nudFormaNo.Location = new System.Drawing.Point(110, 68);
            this.nudFormaNo.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudFormaNo.Name = "nudFormaNo";
            this.nudFormaNo.Size = new System.Drawing.Size(138, 20);
            this.nudFormaNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Futbolcu Ad.Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Futbolcu Mevkii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Forma Numarası";
            // 
            // btnEkle2
            // 
            this.btnEkle2.Location = new System.Drawing.Point(272, 13);
            this.btnEkle2.Name = "btnEkle2";
            this.btnEkle2.Size = new System.Drawing.Size(90, 39);
            this.btnEkle2.TabIndex = 6;
            this.btnEkle2.Text = "EKLE";
            this.btnEkle2.UseVisualStyleBackColor = true;
            this.btnEkle2.Click += new System.EventHandler(this.btnEkle2_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(272, 58);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(90, 33);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // OyuncuEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 103);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudFormaNo);
            this.Controls.Add(this.cmbMevkii);
            this.Controls.Add(this.txtAdSoyad);
            this.Name = "OyuncuEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OyuncuEkle";
            ((System.ComponentModel.ISupportInitialize)(this.nudFormaNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox cmbMevkii;
        private System.Windows.Forms.NumericUpDown nudFormaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle2;
        private System.Windows.Forms.Button btnIptal;
    }
}