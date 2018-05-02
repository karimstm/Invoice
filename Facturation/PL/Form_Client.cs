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
    public partial class Form_Client : MetroForm
    {
        public Form_Client()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                CLASS_CLIENT.PS_INSERTCLIENT(txtName.Text, txtAdress.Text, txtcity.Text, Convert.ToDecimal(txtbalance.Text));
                MessageBox.Show("Ajouter avec succes!");
                txtbalance.Clear();
                txtAdress.Clear();
                txtcity.Clear();
                txtName.Clear();
                txtName.Focus();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.Number.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
