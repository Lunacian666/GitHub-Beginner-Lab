namespace StudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            string searchID = txtID.Text.Trim();
            string searchName = txtName.Text.Trim();

            if (searchID == "101" || searchName.Equals("Jeremy", StringComparison.OrdinalIgnoreCase))
            {
                lblResult.Text = "Student Found: ID #101 - Jeremy";
            }
            else if (string.IsNullOrEmpty(searchID) && string.IsNullOrEmpty(searchName))
            {
                lblResult.Text = "Please enter an ID or Name to search.";
            }
            else
            {
                lblResult.Text = "No student found.";
            }
        }
    }
}