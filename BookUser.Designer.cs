namespace QUANLITHUVIENSQL1
{
    partial class BookUser
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
            dtppublishdate = new DateTimePicker();
            lbpublishdate = new Label();
            lbgenre = new Label();
            lbauthor = new Label();
            lbtitle = new Label();
            lbbookID = new Label();
            tbquantity = new TextBox();
            tbgenre = new TextBox();
            tbauthor = new TextBox();
            tbtitle = new TextBox();
            tbbookID = new TextBox();
            lbsearch = new Label();
            tbSearch = new TextBox();
            dgvbookUser = new DataGridView();
            btnback = new Button();
            btnexit = new Button();
            lbquantity = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvbookUser).BeginInit();
            SuspendLayout();
            // 
            // dtppublishdate
            // 
            dtppublishdate.Location = new Point(553, 173);
            dtppublishdate.Name = "dtppublishdate";
            dtppublishdate.Size = new Size(259, 27);
            dtppublishdate.TabIndex = 47;
            // 
            // lbpublishdate
            // 
            lbpublishdate.AutoSize = true;
            lbpublishdate.Location = new Point(447, 171);
            lbpublishdate.Name = "lbpublishdate";
            lbpublishdate.Size = new Size(92, 20);
            lbpublishdate.TabIndex = 46;
            lbpublishdate.Text = "Publish Date";
            // 
            // lbgenre
            // 
            lbgenre.AutoSize = true;
            lbgenre.Location = new Point(447, 116);
            lbgenre.Name = "lbgenre";
            lbgenre.Size = new Size(48, 20);
            lbgenre.TabIndex = 45;
            lbgenre.Text = "Genre";
            // 
            // lbauthor
            // 
            lbauthor.AutoSize = true;
            lbauthor.Location = new Point(50, 235);
            lbauthor.Name = "lbauthor";
            lbauthor.Size = new Size(54, 20);
            lbauthor.TabIndex = 44;
            lbauthor.Text = "Author";
            // 
            // lbtitle
            // 
            lbtitle.AutoSize = true;
            lbtitle.Location = new Point(50, 178);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(38, 20);
            lbtitle.TabIndex = 43;
            lbtitle.Text = "Title";
            // 
            // lbbookID
            // 
            lbbookID.AutoSize = true;
            lbbookID.Location = new Point(50, 116);
            lbbookID.Name = "lbbookID";
            lbbookID.Size = new Size(62, 20);
            lbbookID.TabIndex = 42;
            lbbookID.Text = "Book ID";
            // 
            // tbquantity
            // 
            tbquantity.Location = new Point(553, 235);
            tbquantity.Name = "tbquantity";
            tbquantity.Size = new Size(125, 27);
            tbquantity.TabIndex = 41;
            // 
            // tbgenre
            // 
            tbgenre.Location = new Point(553, 109);
            tbgenre.Name = "tbgenre";
            tbgenre.Size = new Size(125, 27);
            tbgenre.TabIndex = 40;
            // 
            // tbauthor
            // 
            tbauthor.Location = new Point(159, 228);
            tbauthor.Name = "tbauthor";
            tbauthor.Size = new Size(125, 27);
            tbauthor.TabIndex = 39;
            // 
            // tbtitle
            // 
            tbtitle.Location = new Point(159, 171);
            tbtitle.Name = "tbtitle";
            tbtitle.Size = new Size(125, 27);
            tbtitle.TabIndex = 38;
            // 
            // tbbookID
            // 
            tbbookID.Location = new Point(159, 109);
            tbbookID.Name = "tbbookID";
            tbbookID.Size = new Size(125, 27);
            tbbookID.TabIndex = 37;
            // 
            // lbsearch
            // 
            lbsearch.AutoSize = true;
            lbsearch.Location = new Point(122, 303);
            lbsearch.Name = "lbsearch";
            lbsearch.Size = new Size(57, 20);
            lbsearch.TabIndex = 49;
            lbsearch.Text = "Search ";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(214, 296);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(260, 27);
            tbSearch.TabIndex = 48;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // dgvbookUser
            // 
            dgvbookUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbookUser.Location = new Point(1, 359);
            dgvbookUser.Name = "dgvbookUser";
            dgvbookUser.RowHeadersWidth = 51;
            dgvbookUser.Size = new Size(1144, 194);
            dgvbookUser.TabIndex = 50;
            dgvbookUser.CellClick += dgvbookUser_CellClick;
            // 
            // btnback
            // 
            btnback.Location = new Point(41, 26);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 51;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(1001, 26);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 52;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // lbquantity
            // 
            lbquantity.AutoSize = true;
            lbquantity.Location = new Point(447, 242);
            lbquantity.Name = "lbquantity";
            lbquantity.Size = new Size(65, 20);
            lbquantity.TabIndex = 53;
            lbquantity.Text = "Quantity";
            // 
            // BookUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 565);
            Controls.Add(lbquantity);
            Controls.Add(btnexit);
            Controls.Add(btnback);
            Controls.Add(dgvbookUser);
            Controls.Add(lbsearch);
            Controls.Add(tbSearch);
            Controls.Add(dtppublishdate);
            Controls.Add(lbpublishdate);
            Controls.Add(lbgenre);
            Controls.Add(lbauthor);
            Controls.Add(lbtitle);
            Controls.Add(lbbookID);
            Controls.Add(tbquantity);
            Controls.Add(tbgenre);
            Controls.Add(tbauthor);
            Controls.Add(tbtitle);
            Controls.Add(tbbookID);
            Name = "BookUser";
            Text = "BookUser";
            Load += BookUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbookUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtppublishdate;
        private Label lbpublishdate;
        private Label lbgenre;
        private Label lbauthor;
        private Label lbtitle;
        private Label lbbookID;
        private TextBox tbquantity;
        private TextBox tbgenre;
        private TextBox tbauthor;
        private TextBox tbtitle;
        private TextBox tbbookID;
        private Label lbsearch;
        private TextBox tbSearch;
        private DataGridView dgvbookUser;
        private Button btnback;
        private Button btnexit;
        private Label lbquantity;
    }
}