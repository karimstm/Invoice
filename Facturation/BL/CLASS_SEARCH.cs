using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Facturation.DAL;

namespace Facturation.BL
{
    class CLASS_SEARCH
    {
        public static DataTable PS_SEARCHCLIENT()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("PS_SEARCHCLIENT", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable PS_SEARCHARTICLE()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("PS_SEARCHARTICLE", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
    }
}
