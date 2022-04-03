namespace WFA_HastaneRendevu
{
    partial class BransEkleForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBransEkle = new System.Windows.Forms.Button();
            this.txtBrans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBransEkle);
            this.groupBox1.Controls.Add(this.txtBrans);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(216, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(341, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branş";
            // 
            // btnBransEkle
            // 
            this.btnBransEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBransEkle.Location = new System.Drawing.Point(39, 116);
            this.btnBransEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnBransEkle.Name = "btnBransEkle";
            this.btnBransEkle.Size = new System.Drawing.Size(227, 49);
            this.btnBransEkle.TabIndex = 2;
            this.btnBransEkle.Text = "Branş Ekle";
            this.btnBransEkle.UseVisualStyleBackColor = true;
            this.btnBransEkle.Click += new System.EventHandler(this.btnBransEkle_Click);
            // 
            // txtBrans
            // 
            this.txtBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBrans.Location = new System.Drawing.Point(37, 71);
            this.txtBrans.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(227, 34);
            this.txtBrans.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş Ad:";
            // 
            // BransEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "BransEkleForm";
            this.Text = "Form2";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBransEkle;
        private System.Windows.Forms.TextBox txtBrans;
        private System.Windows.Forms.Label label1;
    }
}