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
using Facturation.BL;

namespace Facturation.PL
{
    public partial class Search : MetroForm
    {
        public Search(string check)
        {
            InitializeComponent();

            if (check == "Client")
            {
                DataTable dt = CLASS_SEARCH.PS_SEARCHCLIENT();
                dgv.DataSource = dt;
            }
            else
            {
                DataTable dt = CLASS_SEARCH.PS_SEARCHARTICLE();
                dgv.DataSource = dt;
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
