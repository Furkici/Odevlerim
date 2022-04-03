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
    public partial class BransEkleForm : Form
    {
        public BransEkleForm()
        {
            InitializeComponent();
        }
        public static List<Brans> bıranslistesi = new List<Brans>();
        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            if (txtBrans.Text == "")
            {
                
                MessageBox.Show("Boş bırakılamaz! Branş girin.");
            }
            else
            {
                Brans bıranş = new Brans();
                bıranş.BransAd = txtBrans.Text;

                bıranslistesi.Add(bıranş);
                MessageBox.Show(" Eklendi ");

                DialogResult dr1 = new DialogResult();
                dr1 = MessageBox.Show("Devam etmek için:'Evet' , Branş eklemek için:'Hayır' butonuna basın  ", "Devam edilsin mi?", MessageBoxButtons.YesNo);

                if (dr1 == DialogResult.Yes)
                {
                    DoktorEkleForm doktorEkleForm = new DoktorEkleForm();
                    doktorEkleForm.Show();
                    this.Hide();
                }
            }

            
            
         }

    }
}
