namespace LibraryManagementSystem
{
    partial class ReviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewForm));
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lstReviews = new System.Windows.Forms.ListBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.btnDeleteReview = new System.Windows.Forms.Button();
            this.lblAverageRating = new System.Windows.Forms.Label();
            this.lblReviewCount = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.Label();
            this.star2 = new System.Windows.Forms.Label();
            this.star3 = new System.Windows.Forms.Label();
            this.star4 = new System.Windows.Forms.Label();
            this.star5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBookTitle.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.White;
            this.lblBookTitle.Location = new System.Drawing.Point(50, 31);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(146, 23);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Selected Book ->";
            // 
            // lstReviews
            // 
            this.lstReviews.BackColor = System.Drawing.Color.Gray;
            this.lstReviews.ForeColor = System.Drawing.Color.White;
            this.lstReviews.FormattingEnabled = true;
            this.lstReviews.Location = new System.Drawing.Point(45, 91);
            this.lstReviews.Name = "lstReviews";
            this.lstReviews.Size = new System.Drawing.Size(200, 30);
            this.lstReviews.TabIndex = 1;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComment.BackColor = System.Drawing.Color.Gray;
            this.txtComment.ForeColor = System.Drawing.Color.White;
            this.txtComment.Location = new System.Drawing.Point(171, 207);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtComment.Size = new System.Drawing.Size(387, 76);
            this.txtComment.TabIndex = 2;
            // 
            // nudRating
            // 
            this.nudRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRating.BackColor = System.Drawing.Color.White;
            this.nudRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudRating.ForeColor = System.Drawing.Color.Navy;
            this.nudRating.Location = new System.Drawing.Point(620, 34);
            this.nudRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(120, 21);
            this.nudRating.TabIndex = 3;
            this.nudRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddReview
            // 
            this.btnAddReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddReview.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddReview.ForeColor = System.Drawing.Color.Black;
            this.btnAddReview.Location = new System.Drawing.Point(171, 305);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(133, 58);
            this.btnAddReview.TabIndex = 4;
            this.btnAddReview.Text = "Add Review";
            this.btnAddReview.UseVisualStyleBackColor = false;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // btnDeleteReview
            // 
            this.btnDeleteReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteReview.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteReview.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReview.Location = new System.Drawing.Point(404, 305);
            this.btnDeleteReview.Name = "btnDeleteReview";
            this.btnDeleteReview.Size = new System.Drawing.Size(154, 56);
            this.btnDeleteReview.TabIndex = 5;
            this.btnDeleteReview.Text = "Delete Selected Review";
            this.btnDeleteReview.UseVisualStyleBackColor = false;
            this.btnDeleteReview.Click += new System.EventHandler(this.btnDeleteReview_Click);
            // 
            // lblAverageRating
            // 
            this.lblAverageRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAverageRating.AutoSize = true;
            this.lblAverageRating.BackColor = System.Drawing.Color.Navy;
            this.lblAverageRating.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAverageRating.ForeColor = System.Drawing.Color.White;
            this.lblAverageRating.Location = new System.Drawing.Point(444, 31);
            this.lblAverageRating.Name = "lblAverageRating";
            this.lblAverageRating.Size = new System.Drawing.Size(148, 23);
            this.lblAverageRating.TabIndex = 6;
            this.lblAverageRating.Text = "Average Rating: -";
            // 
            // lblReviewCount
            // 
            this.lblReviewCount.AutoSize = true;
            this.lblReviewCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReviewCount.ForeColor = System.Drawing.Color.White;
            this.lblReviewCount.Location = new System.Drawing.Point(61, 64);
            this.lblReviewCount.Name = "lblReviewCount";
            this.lblReviewCount.Size = new System.Drawing.Size(13, 13);
            this.lblReviewCount.TabIndex = 8;
            this.lblReviewCount.Text = "0";
            // 
            // star1
            // 
            this.star1.AutoSize = true;
            this.star1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.star1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.star1.ForeColor = System.Drawing.Color.Gray;
            this.star1.Location = new System.Drawing.Point(598, 73);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(33, 31);
            this.star1.TabIndex = 9;
            this.star1.Text = "★";
            // 
            // star2
            // 
            this.star2.AutoSize = true;
            this.star2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.star2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.star2.ForeColor = System.Drawing.Color.Gray;
            this.star2.Location = new System.Drawing.Point(626, 73);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(33, 31);
            this.star2.TabIndex = 10;
            this.star2.Text = "★";
            // 
            // star3
            // 
            this.star3.AutoSize = true;
            this.star3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.star3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.star3.ForeColor = System.Drawing.Color.Gray;
            this.star3.Location = new System.Drawing.Point(653, 73);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(33, 31);
            this.star3.TabIndex = 11;
            this.star3.Text = "★";
            // 
            // star4
            // 
            this.star4.AutoSize = true;
            this.star4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.star4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.star4.ForeColor = System.Drawing.Color.Gray;
            this.star4.Location = new System.Drawing.Point(677, 73);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(33, 31);
            this.star4.TabIndex = 12;
            this.star4.Text = "★";
            // 
            // star5
            // 
            this.star5.AutoSize = true;
            this.star5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.star5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.star5.ForeColor = System.Drawing.Color.Gray;
            this.star5.Location = new System.Drawing.Point(707, 73);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(33, 31);
            this.star5.TabIndex = 13;
            this.star5.Text = "★";
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.lblReviewCount);
            this.Controls.Add(this.lblAverageRating);
            this.Controls.Add(this.btnDeleteReview);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lstReviews);
            this.Controls.Add(this.lblBookTitle);
            this.Name = "ReviewForm";
            this.Text = "ReviewSystem";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

        

        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.ListBox lstReviews;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.Button btnDeleteReview;
        private System.Windows.Forms.Label lblAverageRating;
        private System.Windows.Forms.Label lblReviewCount;
        private System.Windows.Forms.Label star1;
        private System.Windows.Forms.Label star2;
        private System.Windows.Forms.Label star3;
        private System.Windows.Forms.Label star4;
        private System.Windows.Forms.Label star5;
    }
}