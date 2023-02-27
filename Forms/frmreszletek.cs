using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220227
{
    public partial class frmreszletek : Form
    {
        public string Nev { get; set; }
        public frmreszletek(string nev)
        {
            Nev = nev;
            InitializeComponent();
        }

        private void frmreszletek_Load(object sender, EventArgs e)
        {
            lblNev.Text = Nev;

            List<int> evek = new();
            List<string> foglalkozasok = new();

            SqlConnection con = new(Properties.Resources.ConnectionString);
            con.Open();
            string sql = "SELECT kituntetes.ev " +
                "FROM szemely " +
                "INNER JOIN kituntetes ON kituntetes.szemelyId = szemely.id " +
                $"WHERE szemely.nev = '{Nev}';";

            SqlDataAdapter adapter = new();
            adapter.SelectCommand = new(sql, con);
            SqlDataReader reader = adapter.SelectCommand.ExecuteReader();

            while (reader.Read())
            {
                evek.Add(reader.GetInt32(0));
            }

            reader.Close();

            sql = "SELECT foglalkozas.megnevezes " +
                "FROM szemely " +
                "INNER JOIN foglalkozas ON foglalkozas.szemelyId = szemely.id " +
                $"WHERE szemely.nev = '{Nev}';";

            adapter.SelectCommand = new(sql, con);
            reader = adapter.SelectCommand.ExecuteReader();

            while (reader.Read())
            {
                foglalkozasok.Add(reader.GetString(0));
            }

            reader.Close();
            con.Close();

            foreach (string foglalkozas in foglalkozasok)
            {
                lblFoglalkozasok.Text += $"[*] {foglalkozas}\n";
            }

            for (int i = 0; i < evek.Count; i++)
            {
                lblEvek.Text += $"{evek[i]}";
                if (i < evek.Count - 1)
                    lblEvek.Text += ", ";
            }

        }
    }
}
