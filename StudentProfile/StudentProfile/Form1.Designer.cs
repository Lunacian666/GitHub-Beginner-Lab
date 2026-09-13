namespace StudentProfile
{
    partial class Form1
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
            lblstudentProfile = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            lblName = new Label();
            lblID = new Label();
            bttnSearch = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblstudentProfile
            // 
            lblstudentProfile.AutoSize = true;
            lblstudentProfile.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblstudentProfile.Location = new Point(231, 27);
            lblstudentProfile.Name = "lblstudentProfile";
            lblstudentProfile.Size = new Size(335, 25);
            lblstudentProfile.TabIndex = 0;
            lblstudentProfile.Text = "Student Profile - GitHub-Beginner-Lab";
            lblstudentProfile.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(231, 118);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(466, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(466, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Enter a Name";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(231, 100);
            lblID.Name = "lblID";
            lblID.Size = new Size(57, 15);
            lblID.TabIndex = 4;
            lblID.Text = "Enter a ID";
            // 
            // bttnSearch
            // 
            bttnSearch.Location = new Point(364, 136);
            bttnSearch.Name = "bttnSearch";
            bttnSearch.Size = new Size(75, 23);
            bttnSearch.TabIndex = 5;
            bttnSearch.Text = "Search";
            bttnSearch.UseVisualStyleBackColor = true;
            bttnSearch.Click += bttnSearch_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(231, 197);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(69, 30);
            lblResult.TabIndex = 6;
            lblResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 288);
            Controls.Add(lblResult);
            Controls.Add(bttnSearch);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblstudentProfile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstudentProfile;
        private TextBox txtID;
        private TextBox txtName;
        private Label lblName;
        private Label lblID;
        private Button bttnSearch;
        private Label lblResult;
    }
}
