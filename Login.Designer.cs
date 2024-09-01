namespace QUANLITHUVIENSQL1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnexit = new Button();
            btnlogin = new Button();
            lbpassword = new Label();
            lbusername = new Label();
            tbpassword = new TextBox();
            tbusername = new TextBox();
            label1 = new Label();
            checkboxshow = new CheckBox();
            SuspendLayout();
            // 
            // btnexit
            // 
            btnexit.Location = new Point(622, 346);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 11;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(437, 346);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 10;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Location = new Point(380, 243);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(72, 20);
            lbpassword.TabIndex = 9;
            lbpassword.Text = "password";
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Location = new Point(380, 179);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(73, 20);
            lbusername.TabIndex = 8;
            lbusername.Text = "username";
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(501, 236);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(268, 27);
            tbpassword.TabIndex = 7;
            tbpassword.TextChanged += tbpassword_TextChanged;
            // 
            // tbusername
            // 
            tbusername.Location = new Point(501, 172);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(268, 27);
            tbusername.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 51);
            label1.Name = "label1";
            label1.Size = new Size(574, 68);
            label1.TabIndex = 12;
            label1.Text = "Library management";
            // 
            // checkboxshow
            // 
            checkboxshow.AutoSize = true;
            checkboxshow.BackColor = SystemColors.ButtonHighlight;
            checkboxshow.Location = new Point(675, 285);
            checkboxshow.Name = "checkboxshow";
            checkboxshow.Size = new Size(98, 24);
            checkboxshow.TabIndex = 13;
            checkboxshow.Text = "show pass";
            checkboxshow.UseVisualStyleBackColor = false;
            checkboxshow.CheckedChanged += checkboxshow_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_the_background_photography_of_the_empty_bookstore_library_image_785536;
            ClientSize = new Size(1148, 546);
            Controls.Add(checkboxshow);
            Controls.Add(label1);
            Controls.Add(btnexit);
            Controls.Add(btnlogin);
            Controls.Add(lbpassword);
            Controls.Add(lbusername);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexit;
        private Button btnlogin;
        private Label lbpassword;
        private Label lbusername;
        private TextBox tbpassword;
        private TextBox tbusername;
        private Label label1;
        private CheckBox checkboxshow;
    }
}
