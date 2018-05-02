using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Facturation.DAL;

namespace Facturation.BL
{
    class CLASS_FACTURE
    {
        public static int PS_INSERTFACTURE(DateTime datefacture, decimal montant_facture, decimal montant_rest, string Code_cl, DataTable contient)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("PS_INSERTFACTURE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@DATE_FACTURE", SqlDbType.Date, datefacture),
                DataAccessLayer.CreateParameter("@MONTANT_FACTURE", SqlDbType.Decimal, montant_facture),
                DataAccessLayer.CreateParameter("@MONTANT_REST", SqlDbType.Decimal, montant_rest),
                DataAccessLayer.CreateParameter("@CODE_CL", SqlDbType.NVarChar, Code_cl),
                DataAccessLayer.CreateParameter("@CONTIENT", SqlDbType.Structured, contient));
            DataAccessLayer.Close();
            return i;
        }

        public static string PS_MAXFACTURE()
        {
            DataAccessLayer.Open();
            string code = Convert.ToString(DataAccessLayer.ExecuteScalar("PS_MAXFACTURE", CommandType.StoredProcedure));
            DataAccessLayer.Close();
            return code;
        }

        public static string MAXFACTURE()
        {
            DataAccessLayer.Open();
            string max = Convert.ToString(DataAccessLayer.ExecuteScalar("MAXFACTURE", CommandType.StoredProcedure));
            DataAccessLayer.Close();
            return max;
        }
    }
}
