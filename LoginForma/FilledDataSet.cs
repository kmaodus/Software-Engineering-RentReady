using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForma
{
    class FilledDataSet
    {
        public DataSet dataSet;
        public FilledDataSet(string query)
        {
            dataSet = new DataSet();

            string strConnect = "Data Source=31.147.204.119\\PISERVER,1433;" +
                "Initial Catalog=18082_DB;Persist Security Info=True;" +
                "User ID=18082_User;Password=jXfC+2]_";

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection = new SqlConnection(strConnect);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSet);
            sqlConnection.Close();
        }
    }
}
