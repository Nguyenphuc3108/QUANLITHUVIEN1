using System.Data.SqlClient;
namespace QUANLITHUVIENSQL1
{
    public partial class Login : Form
    {
        SqlConnection conn;

        public Login()
        {
            InitializeComponent();
            createConnection();
        }
        private void createConnection()
        {
            try
            {
                String strConnection = "Server=ASUS-VIVOBOOK\\NGUYENNHUPHUC;Database=QUANLITHUVIEN;Integrated Security = true";
                conn = new SqlConnection(strConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra ở createConnection " + ex.Message);
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                String username = tbusername.Text;
                String password = tbpassword.Text;
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "SELECT TOP 1 * FROM Members WHERE Members.password='" + password + "' AND Members.name = '" + username + "'";
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                if (username != null && password != null && reader.HasRows)
                {
                    reader.Read();

                    int retrievedRole = reader.GetInt32(reader.GetOrdinal("role_id"));

                    AppData.isLogin = true;
                    AppData.username = username;

                    if (retrievedRole == 1)
                    {
                        AppData.role = AppData.Role_Admin;
                        MessageBox.Show("Logged in successfully!");
                        members members = new members();
                        members.Show();
                        this.Hide();
                    }
                    else
                    {
                        AppData.role = AppData.Role_User;
                        MessageBox.Show("Logged in successfully!");
                        BookUser bookUser = new BookUser();
                        bookUser.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong login name or password!");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in btnLogin_Click " + ex.Message);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {
            tbpassword.PasswordChar = '*';
        }

        private void checkboxshow_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxshow.Checked)
            {
                tbpassword.PasswordChar = '\0';

            }
            else
            {
                tbpassword.PasswordChar = '*';
            }
        }
    }
}
