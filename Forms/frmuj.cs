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
    public partial class frmuj : Form
    {
        public frmuj()
        {
            InitializeComponent();
        }

        private void OnUjSzemelyClick(object sender, EventArgs e)
        {
            string sep = ", ";
            string nev = tbSzemelyNev.Text;
            string fogl = tbSzemelyFogl.Text;

            if (string.IsNullOrWhiteSpace(nev) || string.IsNullOrWhiteSpace(fogl))
            {
                MessageBox.Show("Ne hagyjon üres mezőket!");
                return;
            }

            SqlConnection con = new(Properties.Resources.ConnectionString);
            con.Open();
            string sql =  $"SELECT id FROM szemely WHERE nev = '{nev}';";
            SqlDataAdapter adapter = new();
            adapter.SelectCommand = new(sql, con);
            SqlDataReader reader = adapter.SelectCommand.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Ilyen személy már létezik az adatbázisban!");
                reader.Close();
                return;
            }
            reader.Close();

            
        }

        private void OnUjDijClick(object sender, EventArgs e)
        {

        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            nupDijEv.Minimum = 2017;
            nupDijEv.Maximum = DateTime.Now.Year;
        }
    }
}
