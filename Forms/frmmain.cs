using Microsoft.Data.SqlClient;

namespace WFA220227
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void OnCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            MessageBox.Show($"row:{e.RowIndex} col:{e.ColumnIndex}");
            MessageBox.Show($"{dgv.Rows[e.RowIndex].Cells[1].Value}");
            */
            frmreszletek frmreszletek = new frmreszletek((string)dgv.Rows[e.RowIndex].Cells[1].Value);
            frmreszletek.ShowDialog();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            

            SqlConnection con = new(Properties.Resources.ConnectionString);
            con.Open();
            string sql = "SELECT ev, nev FROM kituntetes INNER JOIN szemely ON kituntetes.szemelyId = szemely.id ORDER BY ev DESC, nev ASC;";
            SqlDataReader reader = new SqlCommand(sql, con).ExecuteReader();
            
            while (reader.Read())
            {
                dgv.Rows.Add(reader[0], reader[1]);
                
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if ((int)row.Cells[0].Value % 2 == 0)
                row.DefaultCellStyle.BackColor = Color.LightCoral;
            }

            reader.Close();
            con.Close();
        }

        private void OnÚjClick(object sender, EventArgs e)
        {
            frmuj frmuj = new();
            frmuj.Show();
        }
    }
}