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
    public partial class Bookmanagement : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Bookmanagement()
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

        private void Bookmanagement_Load(object sender, EventArgs e)
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
            dgvbook.DataSource = dt;
            conn.Close();
        }

        private void createNewBook()
        {
            try
            {
                String sql = "INSERT INTO Books (book_id,title,author,genre,publish_date,quantity)"
                    + " VALUES (@book_id,@title,@author,@genre,@publish_date,@quantity)";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@book_id", SqlDbType.Int);
                cmd.Parameters["@book_id"].Value = Convert.ToInt32(tbbookID.Text);

                cmd.Parameters.Add("@title", SqlDbType.VarChar);
                cmd.Parameters["@title"].Value = tbtitle.Text.ToString();

                cmd.Parameters.Add("@author", SqlDbType.VarChar);
                cmd.Parameters["@author"].Value = tbauthor.Text.ToString();

                cmd.Parameters.Add("@genre", SqlDbType.VarChar);
                cmd.Parameters["@genre"].Value = tbgenre.Text.ToString();

                cmd.Parameters.Add("@publish_date", SqlDbType.Date);
                cmd.Parameters["@publish_date"].Value = DateTime.Parse(dtppublishdate.Text);

                cmd.Parameters.Add("@quantity", SqlDbType.Int);
                cmd.Parameters["@quantity"].Value = tbquantity.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error in the process!" + ex.Message);
            }


        }
        private void DeleteBook()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string sql = "DELETE FROM Books WHERE book_id = @book_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@book_id", SqlDbType.Int);
                int book_id = Convert.ToInt32(tbbookID.Text);
                cmd.Parameters["@book_id"].Value = book_id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully!", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Question);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in Deletebook" + ex.Message);
            }


        }
        private void UpDateBook()
        {
            try
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                String sql = "UPDATE Books SET book_id = @book_id, title = @title, author = @author, genre = @genre, publish_date = @publish_date, quantity = @quantity WHERE book_id = @book_id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@book_id", Convert.ToInt32(tbbookID.Text));
                cmd.Parameters.AddWithValue("@title", tbtitle.Text);
                cmd.Parameters.AddWithValue("@author", tbauthor.Text);
                cmd.Parameters.AddWithValue("@genre", tbgenre.Text);
                cmd.Parameters.AddWithValue("@publish_date", DateTime.Parse(dtppublishdate.Text));
                cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(tbquantity.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfully!", "successfully", MessageBoxButtons.OK);
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during the update process!" + ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            createNewBook();
            display();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
            display();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpDateBook();
            display();
        }



        private void btnback_Click(object sender, EventArgs e)
        {
            members members = new members();
            members.Show();
            this.Hide();

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.Show();
            this.Hide();
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

                dgvbook.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error in search: " + ex.Message);
            }
        }

        private void dgvbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvbook.Rows[e.RowIndex];
                tbbookID.Text = row.Cells["book_id"].Value.ToString();
                tbtitle.Text = row.Cells["title"].Value.ToString();
                tbauthor.Text = row.Cells["author"].Value.ToString();
                tbgenre.Text = row.Cells["genre"].Value.ToString();
                dtppublishdate.Text = row.Cells["publish_date"].Value.ToString();
                tbquantity.Text = row.Cells["quantity"].Value.ToString();

            }
        }

        private void dgvbook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
