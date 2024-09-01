namespace QUANLITHUVIENSQL1
{
    partial class Bookmanagement
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
            btndelete = new Button();
            btnupdate = new Button();
            btnadd = new Button();
            lbquantity = new Label();
            lbpublishdate = new Label();
            lbgenre = new Label();
            lbauthor = new Label();
            lbtitle = new Label();
            lbbookID = new Label();
            lbsearch = new Label();
            tbSearch = new TextBox();
            tbquantity = new TextBox();
            tbgenre = new TextBox();
            tbauthor = new TextBox();
            tbtitle = new TextBox();
            tbbookID = new TextBox();
            dgvbook = new DataGridView();
            dtppublishdate = new DateTimePicker();
            btnback = new Button();
            btnnext = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvbook).BeginInit();
            SuspendLayout();
            // 
            // btndelete
            // 
            btndelete.Location = new Point(814, 316);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 35;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(680, 319);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 29);
            btnupdate.TabIndex = 34;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(541, 315);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 33;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // lbquantity
            // 
            lbquantity.AutoSize = true;
            lbquantity.Location = new Point(511, 195);
            lbquantity.Name = "lbquantity";
            lbquantity.Size = new Size(65, 20);
            lbquantity.TabIndex = 32;
            lbquantity.Text = "Quantity";
            // 
            // lbpublishdate
            // 
            lbpublishdate.AutoSize = true;
            lbpublishdate.Location = new Point(511, 128);
            lbpublishdate.Name = "lbpublishdate";
            lbpublishdate.Size = new Size(92, 20);
            lbpublishdate.TabIndex = 31;
            lbpublishdate.Text = "Publish Date";
            // 
            // lbgenre
            // 
            lbgenre.AutoSize = true;
            lbgenre.Location = new Point(511, 73);
            lbgenre.Name = "lbgenre";
            lbgenre.Size = new Size(48, 20);
            lbgenre.TabIndex = 30;
            lbgenre.Text = "Genre";
            // 
            // lbauthor
            // 
            lbauthor.AutoSize = true;
            lbauthor.Location = new Point(114, 192);
            lbauthor.Name = "lbauthor";
            lbauthor.Size = new Size(54, 20);
            lbauthor.TabIndex = 29;
            lbauthor.Text = "Author";
            // 
            // lbtitle
            // 
            lbtitle.AutoSize = true;
            lbtitle.Location = new Point(114, 135);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(38, 20);
            lbtitle.TabIndex = 28;
            lbtitle.Text = "Title";
            // 
            // lbbookID
            // 
            lbbookID.AutoSize = true;
            lbbookID.Location = new Point(114, 73);
            lbbookID.Name = "lbbookID";
            lbbookID.Size = new Size(62, 20);
            lbbookID.TabIndex = 27;
            lbbookID.Text = "Book ID";
            // 
            // lbsearch
            // 
            lbsearch.AutoSize = true;
            lbsearch.Location = new Point(131, 323);
            lbsearch.Name = "lbsearch";
            lbsearch.Size = new Size(57, 20);
            lbsearch.TabIndex = 26;
            lbsearch.Text = "Search ";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(223, 316);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(260, 27);
            tbSearch.TabIndex = 25;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // tbquantity
            // 
            tbquantity.Location = new Point(617, 192);
            tbquantity.Name = "tbquantity";
            tbquantity.Size = new Size(125, 27);
            tbquantity.TabIndex = 24;
            // 
            // tbgenre
            // 
            tbgenre.Location = new Point(617, 66);
            tbgenre.Name = "tbgenre";
            tbgenre.Size = new Size(125, 27);
            tbgenre.TabIndex = 23;
            // 
            // tbauthor
            // 
            tbauthor.Location = new Point(223, 185);
            tbauthor.Name = "tbauthor";
            tbauthor.Size = new Size(125, 27);
            tbauthor.TabIndex = 21;
            // 
            // tbtitle
            // 
            tbtitle.Location = new Point(223, 128);
            tbtitle.Name = "tbtitle";
            tbtitle.Size = new Size(125, 27);
            tbtitle.TabIndex = 20;
            // 
            // tbbookID
            // 
            tbbookID.Location = new Point(223, 66);
            tbbookID.Name = "tbbookID";
            tbbookID.Size = new Size(125, 27);
            tbbookID.TabIndex = 19;
            // 
            // dgvbook
            // 
            dgvbook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbook.Location = new Point(0, 361);
            dgvbook.Name = "dgvbook";
            dgvbook.RowHeadersWidth = 51;
            dgvbook.Size = new Size(1161, 203);
            dgvbook.TabIndex = 18;
            dgvbook.CellClick += dgvbook_CellClick;
            dgvbook.CellContentClick += dgvbook_CellContentClick;
            // 
            // dtppublishdate
            // 
            dtppublishdate.Location = new Point(617, 130);
            dtppublishdate.Name = "dtppublishdate";
            dtppublishdate.Size = new Size(259, 27);
            dtppublishdate.TabIndex = 36;
            // 
            // btnback
            // 
            btnback.Location = new Point(53, 16);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 37;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(972, 36);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(94, 29);
            btnnext.TabIndex = 38;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // Bookmanagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 560);
            Controls.Add(btnnext);
            Controls.Add(btnback);
            Controls.Add(dtppublishdate);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(lbquantity);
            Controls.Add(lbpublishdate);
            Controls.Add(lbgenre);
            Controls.Add(lbauthor);
            Controls.Add(lbtitle);
            Controls.Add(lbbookID);
            Controls.Add(lbsearch);
            Controls.Add(tbSearch);
            Controls.Add(tbquantity);
            Controls.Add(tbgenre);
            Controls.Add(tbauthor);
            Controls.Add(tbtitle);
            Controls.Add(tbbookID);
            Controls.Add(dgvbook);
            Name = "Bookmanagement";
            Text = "Bookmanagement";
            Load += Bookmanagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btndelete;
        private Button btnupdate;
        private Button btnadd;
        private Label lbquantity;
        private Label lbpublishdate;
        private Label lbgenre;
        private Label lbauthor;
        private Label lbtitle;
        private Label lbbookID;
        private Label lbsearch;
        private TextBox tbSearch;
        private TextBox tbquantity;
        private TextBox tbgenre;
        private TextBox tbauthor;
        private TextBox tbtitle;
        private TextBox tbbookID;
        private DataGridView dgvbook;
        private DateTimePicker dtppublishdate;
        private Button btnback;
        private Button btnnext;
    }
}