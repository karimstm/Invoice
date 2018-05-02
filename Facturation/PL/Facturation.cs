using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using Facturation.BL;

namespace Facturation.PL
{
    public partial class Facturation : MetroForm
    {
        public Facturation()
        {
            InitializeComponent();
            txtCodevent.Text =  CLASS_FACTURE.PS_MAXFACTURE();
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            Search frm = new Search("Client");
            frm.ShowDialog();
            if (frm.dgv.Rows.Count > 0)
            {
                txtCodeclient.Text = frm.dgv.SelectedRows[0].Cells[0].Value.ToString();
                string[] fullname = frm.dgv.SelectedRows[0].Cells[1].Value.ToString().Split(' ');
                txtname.Text = fullname[1].ToString();
                txtfirstname.Text = fullname[0].ToString();
                txtsold.Text = frm.dgv.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnarticle_Click(object sender, EventArgs e)
        {
            Search frm = new Search("Article");
            frm.ShowDialog();
            if (frm.dgv.Rows.Count > 0)
            {
                txtarticle.Text = frm.dgv.SelectedRows[0].Cells[0].Value.ToString();
                txtdesigniation.Text = frm.dgv.SelectedRows[0].Cells[1].Value.ToString();
                txtprice.Text = frm.dgv.SelectedRows[0].Cells[2].Value.ToString();
                txtQteStock.Text = frm.dgv.SelectedRows[0].Cells[3].Value.ToString();
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnaddclient_Click(object sender, EventArgs e)
        {
            new Form_Client().ShowDialog();
        }

        private void btnaddpro_Click(object sender, EventArgs e)
        {
            new Form_Article().ShowDialog();
        }

        private void txtQtevendu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != d)
            {
                e.Handled = true;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtQtevendu.Text) > int.Parse(txtQteStock.Text))
            {
                MessageBox.Show("Quantite de vendus est superieur a la quantite de stock");
                return;
            }
            if (txtarticle.Text == string.Empty)
            {
                MessageBox.Show("SVP! Ajouter un produit");
                return;
            }
            if (txtQtevendu.Text == "" || double.Parse(txtQtevendu.Text) <= 0)
            {
                MessageBox.Show("S'il vous plaît entrer la quantité du produit comme l'exige");
                return;
            }
            for (int i = 0; i < dgvFacture.Rows.Count; i++)
            {
                if (txtarticle.Text == dgvFacture.Rows[i].Cells[0].Value.ToString())
                {
                    dgvFacture.Rows[i].Cells[3].Value = Convert.ToDecimal(dgvFacture.Rows[i].Cells[3].Value.ToString()) + Convert.ToDecimal(txtQtevendu.Text);
                    //MessageBox.Show("Ce produit a déjà été ajouté.");
                    return;
                }
            }

            dgvFacture.Rows.Add(txtarticle.Text, txtdesigniation.Text, txtprice.Text, txtQtevendu.Text, Convert.ToDecimal(Convert.ToInt32(txtQtevendu.Text) * Convert.ToDecimal(txtprice.Text)));
            CalcTotal();
            


        }

        private void CalcTotal()
        {
            decimal rest = 0;
            decimal total = 0;
            for (int i = 0; i < dgvFacture.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgvFacture.Rows[i].Cells[4].Value.ToString());
            }
            txttotal.Text = total.ToString();
            rest = Convert.ToDecimal(txtsold.Text) - total;
            if (rest > 0)
            {
                txtrest.Text = "0";
            }
            else
            {
                rest = rest * -1;
                txtrest.Text = rest.ToString();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvFacture.Rows.Remove(dgvFacture.CurrentRow);
            CalcTotal();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddnewPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("REF");
                dt.Columns.Add("QUT_CD");
                foreach (DataGridViewRow dr in dgvFacture.Rows)
                {
                    dt.Rows.Add(dr.Cells[0].Value, dr.Cells[3].Value);
                }
                CLASS_FACTURE.PS_INSERTFACTURE(dateTimePicker1.Value, Convert.ToDecimal(txttotal.Text), Convert.ToDecimal(txtrest.Text), txtCodeclient.Text, dt);
                MessageBox.Show("Ajoute reussit.");
                PrintPurchase.Enabled = true;

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.Number.ToString());
            }
        }

        private void PrintPurchase_Click(object sender, EventArgs e)
        {
            RPT.RPT_FORM frm = new RPT.RPT_FORM();
            string I = CLASS_FACTURE.MAXFACTURE();
            RPT.Facture raport = new RPT.Facture();
            raport.SetParameterValue("@NO_FACTURE", I);
            frm.crystalReportViewer1.ReportSource = raport;
            frm.ShowDialog();

            txtQtevendu.Clear();
            txtarticle.Clear();
            txtdesigniation.Clear();
            txtprice.Clear();
            txtQteStock.Clear();
            txtCodeclient.Clear();
            txtname.Clear();
            txtfirstname.Clear();
            txtsold.Clear();
            dgvFacture.Rows.Clear();
        }
    }
}
