using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        private int currentUserId;
        private string currentUsername;
        private string connectionString;
        private int selectedBookId = -1;

        public MainForm(int userId, string username)
        {
            InitializeComponent();
            currentUserId = userId;
            currentUsername = username;
            connectionString = ConfigurationManager
                .ConnectionStrings["LibraryDBConnection"].ConnectionString;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("You are being redirected to the homepage. Welcome " + currentUsername);
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false;
            dgvBooks.ReadOnly = true;
            LoadBooks();
        }

        private void LoadBooks(string searchText = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT BookID, Title, Author 
                FROM Books
                WHERE Title LIKE @search 
                OR Author LIKE @search";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue(
                    "@search", "%" + searchText + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBooks.DataSource = dt;
                dgvBooks.ClearSelection();

                lblBookCount.Text = $"Total Books: {dt.Rows.Count}";

            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Approval",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void menuBooks_Click(object sender, EventArgs e)
        {
            BookManagementForm form = new BookManagementForm();
            form.ShowDialog();
        }

        private void manageBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookManagementForm form = new BookManagementForm();
            form.ShowDialog();
            LoadBooks();
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                selectedBookId = Convert.ToInt32(
                    dgvBooks.SelectedRows[0].Cells["BookID"].Value);
            }
        }

        private void manageReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Please choose a book first.");
                return;
            }
            ReviewForm reviewForm = new ReviewForm(selectedBookId,currentUserId);
            reviewForm.ShowDialog();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedBookId = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["BookID"].Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(txtSearch.Text);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com/maps/search/library+near+me"; 
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Map could not be opened: " + ex.Message);
            }
        }

    }
}
