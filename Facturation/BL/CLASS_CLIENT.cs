using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Facturation.DAL;

namespace Facturation.BL
{
    class CLASS_CLIENT
    {
        public static int PS_INSERTCLIENT(string name, string adress, string city, decimal balance)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("PS_INSERTCLIENT", CommandType.StoredProcedure, 
                DataAccessLayer.CreateParameter("@nom_cl", SqlDbType.NVarChar, name),
                DataAccessLayer.CreateParameter("@adress", SqlDbType.NVarChar, adress),
                DataAccessLayer.CreateParameter("@ville", SqlDbType.NVarChar, city),
                DataAccessLayer.CreateParameter("@solde", SqlDbType.Decimal, balance));
            DataAccessLayer.Close();
            return i;
        }
    }
}
