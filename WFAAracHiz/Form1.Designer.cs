
namespace WFAAracHiz
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.nudArac2Hiz = new System.Windows.Forms.NumericUpDown();
            this.nudHiz = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudArac2Hiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHiz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Location = new System.Drawing.Point(191, 189);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(418, 203);
            this.lblInfo.TabIndex = 7;
            // 
            // nudArac2Hiz
            // 
            this.nudArac2Hiz.Location = new System.Drawing.Point(191, 154);
            this.nudArac2Hiz.Margin = new System.Windows.Forms.Padding(6);
            this.nudArac2Hiz.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.nudArac2Hiz.Name = "nudArac2Hiz";
            this.nudArac2Hiz.Size = new System.Drawing.Size(418, 20);
            this.nudArac2Hiz.TabIndex = 5;
            this.nudArac2Hiz.ValueChanged += new System.EventHandler(this.nudArac2Hiz_ValueChanged_1);
            // 
            // nudHiz
            // 
            this.nudHiz.Location = new System.Drawing.Point(193, 89);
            this.nudHiz.Margin = new System.Windows.Forms.Padding(6);
            this.nudHiz.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.nudHiz.Name = "nudHiz";
            this.nudHiz.Size = new System.Drawing.Size(418, 20);
            this.nudHiz.TabIndex = 6;
            this.nudHiz.ValueChanged += new System.EventHandler(this.nudHiz_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Araç 2 Hız:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Araç 1 Hız:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.nudArac2Hiz);
            this.Controls.Add(this.nudHiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudArac2Hiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.NumericUpDown nudArac2Hiz;
        private System.Windows.Forms.NumericUpDown nudHiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

