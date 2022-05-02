using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    /// <summary>
    /// Klasa za provjeravanje već postojećih korisničkih imena unutar baze, preciznije tablica 'Vlasnik' i 'Zaposlenik'.
    /// </summary>
    public class ProvjeraKorIme
    {
        public Boolean Provjera(string konekcijaBaze, string upit)
        {
            Boolean dostupnoKorIme = false;
            SqlConnection conn = new SqlConnection(konekcijaBaze);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = upit;
            cmd.Connection = conn;

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                dostupnoKorIme = true;
            }

            conn.Close();
            return dostupnoKorIme;
        }
    }
}
