namespace WFA_HastaneRendevu
{
    partial class DoktorEkleForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBrans);
            this.groupBox2.Controls.Add(this.btnDoktorEkle);
            this.groupBox2.Controls.Add(this.txtDoktorAd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(211, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(341, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doktor Ekle";
            // 
            // cmbBrans
            // 
            this.cmbBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(37, 116);
            this.cmbBrans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(227, 37);
            this.cmbBrans.TabIndex = 3;
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorEkle.Location = new System.Drawing.Point(39, 177);
            this.btnDoktorEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(227, 49);
            this.btnDoktorEkle.TabIndex = 2;
            this.btnDoktorEkle.Text = "Doktor Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorAd.Location = new System.Drawing.Point(37, 73);
            this.txtDoktorAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(227, 34);
            this.txtDoktorAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doktor Ad:";
            // 
            // DoktorEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "DoktorEkleForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DoktorEkleForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.Label label2;
    }
}