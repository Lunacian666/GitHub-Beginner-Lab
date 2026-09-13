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
            SuspendLayout();
            // 
            // lblstudentProfile
            // 
            lblstudentProfile.AutoSize = true;
            lblstudentProfile.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblstudentProfile.Location = new Point(231, 27);
            lblstudentProfile.Name = "lblstudentProfile";
            lblstudentProfile.Size = new Size(307, 25);
            lblstudentProfile.TabIndex = 0;
            lblstudentProfile.Text = "Student Profile - Jeremy Kobi Butor";
            lblstudentProfile.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 164);
            Controls.Add(lblstudentProfile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstudentProfile;
    }
}
