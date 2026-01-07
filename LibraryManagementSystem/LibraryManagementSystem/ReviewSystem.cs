using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ReviewForm : Form
    {
        private int bookId;
        private int userId;
        private string connectionString;

        public ReviewForm(int selectedBookId, int currentUserId)
        {
            InitializeComponent();

            bookId = selectedBookId;
            userId = currentUserId;
            connectionString = ConfigurationManager.ConnectionStrings["LibraryDBConnection"].ConnectionString;
            lblBookTitle.Text = "Selected Book ID: " + bookId;
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void LoadReviews()
        {
            lstReviews.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT ReviewID, Comment, Rating FROM Reviews WHERE BookID = @bookId",
                    conn);

                cmd.Parameters.AddWithValue("@bookId", bookId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int totalRating = 0;
                int reviewCount = 0;

                while (reader.Read())
                {
                    int reviewId = Convert.ToInt32(reader["ReviewID"]);
                    string comment = reader["Comment"].ToString();
                    int rating = Convert.ToInt32(reader["Rating"]);

                    lstReviews.Items.Add(new ReviewItem
                    {
                        ReviewID = reviewId,
                        Text = $"{comment} (Rating: {rating})"
                    });

                    totalRating += rating;
                    reviewCount++;
                }

                
                double avg = 0; 

                if (reviewCount > 0)
                {
                    avg = (double)totalRating / reviewCount; 
                    int fullStars = (int)Math.Round(avg);

                    
                    star1.ForeColor = Color.Gold;
                    star2.ForeColor = Color.Gold;
                    star3.ForeColor = Color.Gold;
                    star4.ForeColor = Color.Gold;
                    star5.ForeColor = Color.Gold;

                    if (fullStars < 5) star5.ForeColor = Color.Gray;
                    if (fullStars < 4) star4.ForeColor = Color.Gray;
                    if (fullStars < 3) star3.ForeColor = Color.Gray;
                    if (fullStars < 2) star2.ForeColor = Color.Gray;
                    if (fullStars < 1) star1.ForeColor = Color.Gray;

                    lblAverageRating.Text = "Average: " + avg.ToString("0.0");
                }
                else
                {
                    
                    star1.ForeColor = Color.Gray;
                    star2.ForeColor = Color.Gray;
                    star3.ForeColor = Color.Gray;
                    star4.ForeColor = Color.Gray;
                    star5.ForeColor = Color.Gray;
                    lblAverageRating.Text = "No ratings have been given yet.";
                }
            }
        }



        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("Please enter a comment.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

               
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Reviews WHERE BookID = @bookId AND UserID = @userId",
                    conn);

                checkCmd.Parameters.AddWithValue("@bookId", bookId);
                checkCmd.Parameters.AddWithValue("@userId", userId);

                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("You have already reviewed this book.");
                    return;
                }

               
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO Reviews (BookID, UserID, Comment, Rating) " +
                    "VALUES (@bookId, @userId, @comment, @rating)",
                    conn);

                insertCmd.Parameters.AddWithValue("@bookId", bookId);
                insertCmd.Parameters.AddWithValue("@userId", userId);
                insertCmd.Parameters.AddWithValue("@comment", txtComment.Text);
                insertCmd.Parameters.AddWithValue("@rating", (int)nudRating.Value);

                insertCmd.ExecuteNonQuery();
            }

            txtComment.Clear();
            nudRating.Value = 1;

            LoadReviews();
        }


        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
            if (lstReviews.SelectedItem == null)
            {
                MessageBox.Show("Please select a review to delete.");
                return;
            }

            ReviewItem item = (ReviewItem)lstReviews.SelectedItem;
            int reviewId = item.ReviewID;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Reviews WHERE ReviewID = @id AND UserID = @userID",
                    conn);

                cmd.Parameters.AddWithValue("@id", reviewId);
                cmd.Parameters.AddWithValue("@userID", userId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadReviews();
        }

    }

    public class ReviewItem
     {
        public int ReviewID { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }

}
