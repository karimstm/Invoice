using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturation.DAL;
using System.Data;

namespace Facturation.BL
{
    class CLASS_PRODUCT
    {
        public static int PS_INSERTPRODUCT(string name, decimal price, int qte)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("PS_INSERTPRODUCT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@designation", SqlDbType.NVarChar, name),
                DataAccessLayer.CreateParameter("@pu", SqlDbType.Decimal, price),
                DataAccessLayer.CreateParameter("@qut_st", SqlDbType.Int, qte));
            DataAccessLayer.Close();
            return i;
        }
    }
}
