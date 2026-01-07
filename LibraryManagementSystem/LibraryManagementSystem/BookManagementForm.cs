using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LibraryManagementSystem
{
    public partial class BookManagementForm : Form
    {
        private string connectionString;

        public BookManagementForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager
                .ConnectionStrings["LibraryDBConnection"].ConnectionString;
        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT BookID, Title, Author FROM Books", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBooks.DataSource = dt;
                dgvBooks.ClearSelection();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please enter the book title and author.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Books (Title, Author) VALUES (@title, @author)", conn);

                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@author", txtAuthor.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadBooks();
            MessageBox.Show("Book added.");
        }


        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book.");
                return;
            }

            int bookId = Convert.ToInt32(
                dgvBooks.SelectedRows[0].Cells["BookID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Books WHERE BookID = @id", conn);

                cmd.Parameters.AddWithValue("@id", bookId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadBooks();
            MessageBox.Show("Book deleted.");
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
