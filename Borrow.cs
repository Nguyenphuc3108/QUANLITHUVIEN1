using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLITHUVIENSQL1
{
    public partial class Borrow : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Borrow()
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
                MessageBox.Show("An error occurred during connection!" + ex.Message);
            }
        }




        private void Borrow_Load(object sender, EventArgs e)
        {
            createConnection();
            display();

        }
        private void display()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Borrow ";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvBorrow.DataSource = dt;
            conn.Close();
        }
        private void createNewBorrow()
        {
            try
            {
               
                String sql = "INSERT INTO Borrow (borrow_id,book_id,member_id,borrow_date,return_date,status)"
                    + " VALUES (@borrow_id,@book_id,@member_id,@borrow_date,@return_date,@status)";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@borrow_id", SqlDbType.Int);
                cmd.Parameters["@borrow_id"].Value = Convert.ToInt32(tbborrowid.Text);

                cmd.Parameters.Add("@book_id", SqlDbType.Int);
                cmd.Parameters["@book_id"].Value = Convert.ToInt32(tbbookid.Text);

                cmd.Parameters.Add("@member_id", SqlDbType.Int);
                cmd.Parameters["@member_id"].Value = Convert.ToInt32(tbmemberid.Text);

                cmd.Parameters.Add("@borrow_date", SqlDbType.Date);
                cmd.Parameters["@borrow_date"].Value = DateTime.Parse(dtpborrowdate.Text);

                cmd.Parameters.Add("@return_date", SqlDbType.Date);
                cmd.Parameters["@return_date"].Value = DateTime.Parse(dtpreturndate.Text);

                cmd.Parameters.Add("@status", SqlDbType.VarChar);
                cmd.Parameters["@status"].Value = tbstatus.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add successfully!");
                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during creation!" + ex.Message);
                conn.Close();

            }
        }

        
        private void DeleteBorrow()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string sql = "DELETE FROM Borrow WHERE borrow_id = @borrow_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@borrow_id", SqlDbType.Int);
                int borrow_id = Convert.ToInt32(tbborrowid.Text);
                cmd.Parameters["@borrow_id"].Value = borrow_id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully!", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Question);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in DeleteBorrow" + ex.Message);
            }
        }
        private void UpDateBorrow()
        {
            try
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                String sql = "UPDATE Borrow SET borrow_id = @borrow_id, book_id = @book_id, member_id = @member_id," +
                    " borrow_date = @borrow_date, return_date = @return_date, status = @status WHERE borrow_id = @borrow_id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@borrow_id", Convert.ToInt32(tbborrowid.Text));
                cmd.Parameters.AddWithValue("@book_id", Convert.ToInt32(tbbookid.Text));
                cmd.Parameters.AddWithValue("@member_id", Convert.ToInt32(tbmemberid.Text));
                cmd.Parameters.AddWithValue("@borrow_date", DateTime.Parse(dtpborrowdate.Text));
                cmd.Parameters.AddWithValue("@return_date", DateTime.Parse(dtpreturndate.Text));
                cmd.Parameters.AddWithValue("@status", tbstatus.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!", "successfully", MessageBoxButtons.OK);
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during the update process!" + ex.Message);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            createNewBorrow();
            display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBorrow();
            display();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpDateBorrow();
            display();
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            Bookmanagement bookmanagement = new Bookmanagement();
            bookmanagement.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Do you want to exit?", "confirm", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbsearch.Text.Trim();
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "SELECT * FROM Borrow WHERE borrow_id LIKE @searchText";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                dgvBorrow.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error in search: " + ex.Message);
            }
        }

        private void dgvBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBorrow.Rows[e.RowIndex];
                tbborrowid.Text = row.Cells["borrow_id"].Value.ToString();
                tbbookid.Text = row.Cells["book_id"].Value.ToString();
                tbmemberid.Text = row.Cells["member_id"].Value.ToString();
                dtpborrowdate.Text = row.Cells["borrow_date"].Value.ToString();
                dtpreturndate.Text = row.Cells["return_date"].Value.ToString();
                tbstatus.Text = row.Cells["status"].Value.ToString();
                tbborrowid.Text = row.Cells["borrow_id"].Value.ToString();

            }
        }
    }

}

