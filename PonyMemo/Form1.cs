using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PonyMemo
{
    public partial class Form1 : Form
    {
        public object DataGridView1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textEtsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtEtsi.Text))

                {

                    this.ponitTableAdapter.Fill(this.poniTiedot.Ponit);
                    ponitBindingSource.DataSource = this.poniTiedot.Ponit;
                    //DataGridView1.DataSource = ponitBindingSource;
                }

                else
                {
                    var query = from o in this.poniTiedot.Ponit
                                where o.Nimi.Contains(txtEtsi.Text) || o.RekNro == txtEtsi.Text || o.Isä == txtEtsi.Text || o.Emä.Contains(txtEtsi.Text)
                                select o;
                    this.ponitTableAdapter.Fill(this.poniTiedot.Ponit);
                    ponitBindingSource.DataSource = this.poniTiedot.Ponit;
                    //DataGridView1.DataSource = query.ToList();
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                if (MessageBox.Show("Oletko varma, että haluat poistaa tiedot?", "Ilmoitus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                    ponitBindingSource.RemoveCurrent();
            }
        }

        private void btnSelaa_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        kuvalaatikko.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Viesti", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUusi_Click(object sender, EventArgs e)
        {
            try
            {
                paneeli.Enabled = true;
                txtNimi.Focus();
                this.poniTiedot.Ponit.AddPonitRow(this.poniTiedot.Ponit.NewPonitRow());
                ponitBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Viesti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ponitBindingSource.ResetBindings(false);
            }
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            paneeli.Enabled = true;
            txtNimi.Focus();
        }

        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            paneeli.Enabled = false;
            ponitBindingSource.ResetBindings(false);
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            try
            {
                ponitBindingSource.EndEdit();
                ponitTableAdapter.Update(this.poniTiedot.Ponit);
                paneeli.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Viesti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ponitBindingSource.ResetBindings(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ponitBindingSource.DataSource = this.poniTiedot.Ponit;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ponitTableAdapter.Fill(this.poniTiedot.Ponit);
            ponitBindingSource.DataSource = this.poniTiedot.Ponit;
        }
    }
}
