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
    public partial class Form_Article : MetroForm
    {
        public Form_Article()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                CLASS_PRODUCT.PS_INSERTPRODUCT(txtname.Text, Convert.ToDecimal(txtPrice.Text), int.Parse(txtQut.Text));
                MessageBox.Show("Ajouter avec succes!");
                txtname.Clear();
                txtPrice.Clear();
                txtQut.Clear();
                txtname.Focus();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Number);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
