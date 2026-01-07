using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private string connectionString;

        public LoginForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager
                .ConnectionStrings["LibraryDBConnection"]
                .ConnectionString;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Username FROM Users WHERE Username=@u AND Password=@p";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["UserID"]);
                    string userNameFromDb = reader["Username"].ToString();

                    MessageBox.Show("Login successful.");

                    MainForm mainForm = new MainForm(userId, userNameFromDb);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }

                reader.Close();
            }
        }

    }
}
