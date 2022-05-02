using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForma
{
    public partial class PlacenoDugovanjeForma : Form
    {
        int sID;
        float iznosStanarine;
        

        public PlacenoDugovanjeForma(int index, float stanarina)
        {
            InitializeComponent();
            sID = index;
            iznosStanarine = stanarina;
        }

        private void PlacenoDugovanjeForma_Load(object sender, EventArgs e)
        {

        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void potvrdiButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=31.147.204.119\\PISERVER,1433;" +
                "Initial Catalog=18082_DB;Persist Security Info=True;" +
                "User ID=18082_User;Password=jXfC+2]_";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("UPDATE Stan SET Dugovanje= Dugovanje - @p1 WHERE StanarID = @p2", sqlConnection);
            sqlCommand.Parameters.AddWithValue("p1", float.Parse(iznosTextBox.Text));
            sqlCommand.Parameters.AddWithValue("p2", sID);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Uspješno unesena transakcija.");
            this.Close();
        }

        private void uplacenaStanarinaButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=31.147.204.119\\PISERVER,1433;" +
                "Initial Catalog=18082_DB;Persist Security Info=True;" +
                "User ID=18082_User;Password=jXfC+2]_";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("UPDATE Stan SET Dugovanje= Dugovanje - @p1 WHERE StanarID = @p2", sqlConnection);
            sqlCommand.Parameters.AddWithValue("p1", iznosStanarine);
            sqlCommand.Parameters.AddWithValue("p2", sID);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Uspješno unesena transakcija.");
            this.Close();
        }
    }
}
