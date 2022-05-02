using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL
    {
        public static DataTable IzvrsiSP(string spIme, List<SqlParameter> sqlParams = null)
        {
            //lozinka - jXfC+2]_
            string strConnect = "Data Source=31.147.204.119\\PISERVER,1433;" +
                "Initial Catalog=18082_DB;Persist Security Info=True;" +
                "User ID=18082_User;Password=jXfC+2]_";

            SqlConnection conn = new SqlConnection();
            DataTable dt = new DataTable();
            

            try
            {
                //Spajanje na bazu
                conn = new SqlConnection(strConnect);
                conn.Open();

                //Napravi sql naredbu/upit
                SqlCommand naredba = new SqlCommand(spIme, conn);
                naredba.CommandType = CommandType.StoredProcedure;
                naredba.Parameters.AddRange(sqlParams.ToArray());

                //Izvrši naredbu
                SqlCommand command = conn.CreateCommand();
                SqlDataReader dr = naredba.ExecuteReader();

                //Ispuni datatable s rezultatima
                dt.Load(dr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
