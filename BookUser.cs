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

namespace QUANLITHUVIENSQL1
{
    public partial class BookUser : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public BookUser()
        {
            InitializeComponent();
            createConnection();
        }
        private void createConnection()
        {
            try
            {
                String stringConnection = "Server=ASUS-VIVOBOOK\\NGUYENNHUPHUC;Database=QUANLITHUVIEN;Integrated Security = true";
                conn = new SqlConnection(stringConnection);
                cmd = new SqlCommand();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during connection" + ex.Message);
            }
        }


        private void BookUser_Load(object sender, EventArgs e)
        {
            createConnection();
            display();
        }
        private void display()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Books ";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvbookUser.DataSource = dt;
            conn.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text.Trim();
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "SELECT * FROM Books WHERE book_id LIKE @searchText";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                dgvbookUser.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error in search: " + ex.Message);
            }
        }



        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Do you want to return to the Login page?", "confirm", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("do you want to exit?", "confirm", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvbookUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvbookUser.Rows[e.RowIndex];
                tbbookID.Text = row.Cells["book_id"].Value.ToString();
                tbtitle.Text = row.Cells["title"].Value.ToString();
                tbauthor.Text = row.Cells["author"].Value.ToString();
                tbgenre.Text = row.Cells["genre"].Value.ToString();
                dtppublishdate.Text = row.Cells["publish_date"].Value.ToString();
                tbquantity.Text = row.Cells["quantity"].Value.ToString();
                tbbookID.Text = row.Cells["book_id"].Value.ToString();

            }
        }
    }
}
