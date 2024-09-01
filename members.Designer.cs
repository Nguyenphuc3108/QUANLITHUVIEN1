namespace QUANLITHUVIENSQL1
{
    partial class members
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
            lbmemberid = new Label();
            lbname = new Label();
            lbemail = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbMemberId = new TextBox();
            tbName = new TextBox();
            tbEmail = new TextBox();
            tbAddress = new TextBox();
            tbPhone = new TextBox();
            tbRoleId = new TextBox();
            tbSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvMember = new DataGridView();
            btnback = new Button();
            btnnext = new Button();
            tbpassword = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // lbmemberid
            // 
            lbmemberid.AutoSize = true;
            lbmemberid.Location = new Point(56, 105);
            lbmemberid.Name = "lbmemberid";
            lbmemberid.Size = new Size(82, 20);
            lbmemberid.TabIndex = 0;
            lbmemberid.Text = "Member Id";
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Location = new Point(56, 165);
            lbname.Name = "lbname";
            lbname.Size = new Size(49, 20);
            lbname.TabIndex = 1;
            lbname.Text = "Name";
            // 
            // lbemail
            // 
            lbemail.AutoSize = true;
            lbemail.Location = new Point(56, 231);
            lbemail.Name = "lbemail";
            lbemail.Size = new Size(46, 20);
            lbemail.TabIndex = 2;
            lbemail.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 105);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(365, 169);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 231);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 5;
            label6.Text = "Role Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(150, 309);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 6;
            label7.Text = "Search";
            // 
            // tbMemberId
            // 
            tbMemberId.Location = new Point(167, 98);
            tbMemberId.Name = "tbMemberId";
            tbMemberId.Size = new Size(125, 27);
            tbMemberId.TabIndex = 7;
            // 
            // tbName
            // 
            tbName.Location = new Point(167, 162);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(167, 222);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 9;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(483, 105);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(125, 27);
            tbAddress.TabIndex = 10;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(483, 158);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(125, 27);
            tbPhone.TabIndex = 11;
            // 
            // tbRoleId
            // 
            tbRoleId.Location = new Point(483, 221);
            tbRoleId.Name = "tbRoleId";
            tbRoleId.Size = new Size(125, 27);
            tbRoleId.TabIndex = 12;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(277, 305);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(299, 27);
            tbSearch.TabIndex = 13;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(667, 268);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(831, 268);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(984, 268);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(-4, 394);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.Size = new Size(1140, 188);
            dgvMember.TabIndex = 17;
            dgvMember.CellClick += dgvMember_CellClick;
            // 
            // btnback
            // 
            btnback.Location = new Point(72, 34);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 18;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(984, 25);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(94, 29);
            btnnext.TabIndex = 19;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(788, 105);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(125, 27);
            tbpassword.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(670, 105);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 20;
            label1.Text = "password";
            // 
            // members
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 578);
            Controls.Add(tbpassword);
            Controls.Add(label1);
            Controls.Add(btnnext);
            Controls.Add(btnback);
            Controls.Add(dgvMember);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(tbSearch);
            Controls.Add(tbRoleId);
            Controls.Add(tbPhone);
            Controls.Add(tbAddress);
            Controls.Add(tbEmail);
            Controls.Add(tbName);
            Controls.Add(tbMemberId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbemail);
            Controls.Add(lbname);
            Controls.Add(lbmemberid);
            Name = "members";
            Text = "members";
            Load += members_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbmemberid;
        private Label lbname;
        private Label lbemail;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbMemberId;
        private TextBox tbName;
        private TextBox tbEmail;
        private TextBox tbAddress;
        private TextBox tbPhone;
        private TextBox tbRoleId;
        private TextBox tbSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvMember;
        private Button btnback;
        private Button btnnext;
        private TextBox tbpassword;
        private Label label1;
    }
}