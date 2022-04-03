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
    public partial class DoktorEkleForm : Form
    {
        public DoktorEkleForm()
        {
            InitializeComponent();
        }
        public static List<Doktor> doktorlistesi = new List<Doktor>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDoktorAd.Text == "")
            {

                MessageBox.Show("Boş bırakılamaz! Doktor girin.");
            }
            else
            {
                Doktor dk = new Doktor();
                dk.DoktorAd = txtDoktorAd.Text;
                dk.BransAd = cmbBrans.SelectedItem.ToString();
                doktorlistesi.Add(dk);

                DialogResult dr2 = new DialogResult();
                dr2 = MessageBox.Show(" Yeni bir doktor eklemek ister misiniz? ", "Uyarı", MessageBoxButtons.YesNo);

                if (dr2 == DialogResult.No)
                {
                    RandevuForm rf = new RandevuForm();
                    rf.Show();
                    this.Hide();
                }
            }
            
        }

        private void DoktorEkleForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Yönlendiriliyorsunuz");

            foreach(Brans bırans in BransEkleForm.bıranslistesi)
            {
                cmbBrans.Items.Add(bırans);
            }
        }
    }
}
