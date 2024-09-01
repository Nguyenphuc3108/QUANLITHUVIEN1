namespace QUANLITHUVIENSQL1
{
    partial class Borrow
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
            lbborrowid = new Label();
            lbbookid = new Label();
            memberid = new Label();
            label4 = new Label();
            label5 = new Label();
            tbborrowid = new TextBox();
            tbbookid = new TextBox();
            tbmemberid = new TextBox();
            dgvBorrow = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            tbsearch = new TextBox();
            dtpborrowdate = new DateTimePicker();
            dtpreturndate = new DateTimePicker();
            label2 = new Label();
            tbstatus = new TextBox();
            btnBack = new Button();
            btnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).BeginInit();
            SuspendLayout();
            // 
            // lbborrowid
            // 
            lbborrowid.AutoSize = true;
            lbborrowid.Location = new Point(126, 107);
            lbborrowid.Name = "lbborrowid";
            lbborrowid.Size = new Size(74, 20);
            lbborrowid.TabIndex = 0;
            lbborrowid.Text = "Borrow Id";
            // 
            // lbbookid
            // 
            lbbookid.AutoSize = true;
            lbbookid.Location = new Point(126, 180);
            lbbookid.Name = "lbbookid";
            lbbookid.Size = new Size(60, 20);
            lbbookid.TabIndex = 1;
            lbbookid.Text = "Book Id";
            // 
            // memberid
            // 
            memberid.AutoSize = true;
            memberid.Location = new Point(126, 241);
            memberid.Name = "memberid";
            memberid.Size = new Size(82, 20);
            memberid.TabIndex = 2;
            memberid.Text = "Member Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 108);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 3;
            label4.Text = "Borrow Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 180);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "Return Date";
            // 
            // tbborrowid
            // 
            tbborrowid.Location = new Point(232, 100);
            tbborrowid.Name = "tbborrowid";
            tbborrowid.Size = new Size(125, 27);
            tbborrowid.TabIndex = 5;
            // 
            // tbbookid
            // 
            tbbookid.Location = new Point(232, 177);
            tbbookid.Name = "tbbookid";
            tbbookid.Size = new Size(125, 27);
            tbbookid.TabIndex = 8;
            // 
            // tbmemberid
            // 
            tbmemberid.Location = new Point(232, 241);
            tbmemberid.Name = "tbmemberid";
            tbmemberid.Size = new Size(125, 27);
            tbmemberid.TabIndex = 9;
            // 
            // dgvBorrow
            // 
            dgvBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrow.Location = new Point(1, 368);
            dgvBorrow.Name = "dgvBorrow";
            dgvBorrow.RowHeadersWidth = 51;
            dgvBorrow.Size = new Size(1128, 188);
            dgvBorrow.TabIndex = 10;
            dgvBorrow.CellClick += dgvBorrow_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(682, 306);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(836, 306);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(981, 306);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 315);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 14;
            label1.Text = "Search";
            // 
            // tbsearch
            // 
            tbsearch.Location = new Point(310, 314);
            tbsearch.Name = "tbsearch";
            tbsearch.Size = new Size(278, 27);
            tbsearch.TabIndex = 15;
            tbsearch.TextChanged += tbsearch_TextChanged;
            // 
            // dtpborrowdate
            // 
            dtpborrowdate.Location = new Point(544, 103);
            dtpborrowdate.Name = "dtpborrowdate";
            dtpborrowdate.Size = new Size(250, 27);
            dtpborrowdate.TabIndex = 16;
            // 
            // dtpreturndate
            // 
            dtpreturndate.Location = new Point(544, 175);
            dtpreturndate.Name = "dtpreturndate";
            dtpreturndate.Size = new Size(250, 27);
            dtpreturndate.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 244);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 18;
            label2.Text = "Status";
            // 
            // tbstatus
            // 
            tbstatus.Location = new Point(542, 236);
            tbstatus.Name = "tbstatus";
            tbstatus.Size = new Size(125, 27);
            tbstatus.TabIndex = 19;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(50, 23);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(1014, 28);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 21;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Borrow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 550);
            Controls.Add(btnexit);
            Controls.Add(btnBack);
            Controls.Add(tbstatus);
            Controls.Add(label2);
            Controls.Add(dtpreturndate);
            Controls.Add(dtpborrowdate);
            Controls.Add(tbsearch);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvBorrow);
            Controls.Add(tbmemberid);
            Controls.Add(tbbookid);
            Controls.Add(tbborrowid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(memberid);
            Controls.Add(lbbookid);
            Controls.Add(lbborrowid);
            Name = "Borrow";
            Text = "Borrow";
            Load += Borrow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbborrowid;
        private Label lbbookid;
        private Label memberid;
        private Label label4;
        private Label label5;
        private TextBox tbborrowid;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox tbbookid;
        private TextBox tbmemberid;
        private DataGridView dgvBorrow;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private TextBox tbsearch;
        private DateTimePicker dtpborrowdate;
        private DateTimePicker dtpreturndate;
        private Label label2;
        private TextBox tbstatus;
        private Button btnBack;
        private Button btnexit;
    }
}