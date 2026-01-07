using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (username == "" || email == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Fill in all the fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("The passwords don't match.");
                return;
            }

            string connectionString =@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                "INSERT INTO Users (Username, Password, Email) VALUES (@u, @p, @e)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@e", email);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Registration successful!");
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
