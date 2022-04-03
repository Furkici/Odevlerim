using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRendevu
{
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
        }
        private void RandevuForm_Load(object sender, EventArgs e)
        {
            HastaKayıt hasta = new HastaKayıt();
            hasta.HastaAd = txtAdRandevu.Text;
            hasta.HastaSoyad=txtSoyadRandevu.Text ;
            hasta.TCKN = txtTcknRandevu.Text;

            foreach(Brans bırans in BransEkleForm.bıranslistesi)
            {
                cmbBransRandevu.Items.Add(bırans);
            }
        }
                
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            flpButton.Controls.Clear();
            int satir = 3;
            int sutun = 3;
            int saat = 9;
            int saataralıgı = 30;
                                                
            if (dateTimePicker1.Value<=DateTime.Now)
            {
              MessageBox.Show("İleri tarih seçilebilir");
                                                     
            }
            else
            {
                for (int a = 0; a < sutun; a++)
                {
                    for (int b = 0; b < satir; b++)
                    {
                        Button btn = new Button();
                        btn.Width = 60;
                        btn.Height = 25;
                        btn.Text = (saat++.ToString()) + ":" + (saataralıgı);
                        this.flpButton.Controls.Add(btn);
                        btn.Click += Btn_Click;
                                                
                    }
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("Seçiminiz : " + " TCKN : " + txtTcknRandevu.Text.ToString() + " İsim : " +  txtAdRandevu.Text.ToString() + " " + txtSoyadRandevu.Text.ToString()+ " Tarih: " + dateTimePicker1.Text.ToString() + " Saat: " + btn.Text  + " , " + " Dr. " + cmbDoktorRandevu.Text.ToString() + " Bölüm: " + cmbBransRandevu.Text.ToString() );
            btn.BackColor = Color.Red;
        }

        private void cmbBransRandevu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBransRandevu.Items.Clear();
            foreach(Doktor doktorlar in DoktorEkleForm.doktorlistesi)
            {
                foreach(Brans bırans in BransEkleForm.bıranslistesi)
                {
                    if(doktorlar.BransAd==bırans.BransAd)
                    {
                        cmbDoktorRandevu.Items.Add(doktorlar);
                    }
                }
            }
        }
        private void cmbBransRandevu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbDoktorRandevu.Items.Clear();
            foreach (Doktor doktor in DoktorEkleForm.doktorlistesi)
            {
                
                if(doktor.BransAd==cmbBransRandevu.Text)
                {
                    cmbDoktorRandevu.Items.Add(doktor.DoktorAd);
                }
            }
        }

        private void cmbDoktorRandevu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
