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
    public partial class members : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public members()
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

        private void members_Load(object sender, EventArgs e)
        {
            createConnection();
            display();
        }
        private void display()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Members ";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvMember.DataSource = dt;
            conn.Close();
        }
        private void createNewMember()
        {
            try
            {
                String sql = "INSERT INTO Members (member_id,name,email,address,phone,role_id,password)"
                    + " VALUES (@member_id,@name,@email,@address,@phone,@role_id,@password)";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@member_id", SqlDbType.Int);
                cmd.Parameters["@member_id"].Value = Convert.ToInt32(tbMemberId.Text);

                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = tbName.Text.ToString();

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = tbEmail.Text.ToString();

                cmd.Parameters.Add("@address", SqlDbType.VarChar);
                cmd.Parameters["@address"].Value = tbAddress.Text.ToString();

                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters["@phone"].Value = tbPhone.Text.ToString();

                cmd.Parameters.Add("@role_id", SqlDbType.Int);
                cmd.Parameters["@role_id"].Value = Convert.ToInt32(tbRoleId.Text);

                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = tbpassword.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during creation!" + ex.Message);
            }
        }
        private void DeleteMember()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string sql = "DELETE FROM Members WHERE member_id = @member_id";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@member_id", SqlDbType.Int);
                int member_id = Convert.ToInt32(tbMemberId.Text);
                cmd.Parameters["@member_id"].Value = member_id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Question);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in Deletemember!" + ex.Message);
            }
        }

        private void UpDateMember()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                String sql = "UPDATE Members SET member_id = @member_id, name = @name, email = @email, address = @address, phone = @phone, role_id = @role_id,password = @password WHERE member_id = @member_id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@member_id", Convert.ToInt32(tbMemberId.Text));
                cmd.Parameters.AddWithValue("@name", tbName.Text);
                cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@address", tbAddress.Text);
                cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                cmd.Parameters.AddWithValue("@role_id", Convert.ToInt32(tbRoleId.Text));
                cmd.Parameters.AddWithValue("@password", tbpassword.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfully!", "successfully", MessageBoxButtons.OK);
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error during the update process!" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createNewMember();
            display();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpDateMember();
            display();
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

        private void btnnext_Click(object sender, EventArgs e)
        {
            Bookmanagement bookmanagement = new Bookmanagement();
            bookmanagement.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMember();
            display();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text.Trim();
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "SELECT * FROM Members WHERE member_id LIKE @searchText";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                dgvMember.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error in search: " + ex.Message);
            }
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMember.Rows[e.RowIndex];
                tbMemberId.Text = row.Cells["member_id"].Value.ToString();
                tbName.Text = row.Cells["name"].Value.ToString();
                tbEmail.Text = row.Cells["email"].Value.ToString();
                tbAddress.Text = row.Cells["address"].Value.ToString();
                tbPhone.Text = row.Cells["phone"].Value.ToString();
                tbRoleId.Text = row.Cells["role_id"].Value.ToString();
                tbpassword.Text = row.Cells["password"].Value.ToString();
                tbMemberId.Text = row.Cells["member_id"].Value.ToString();
            }
        }
    }
}


