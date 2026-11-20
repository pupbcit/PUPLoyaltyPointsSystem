using LoyaltyPointsBusinessLogic;

namespace FormsPUPPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            AuthenticationLogic bl = new AuthenticationLogic();

            if (bl.IsFacultyNumberCorrect(txtFacultyNumber.Text))
            {
                MessageBox.Show("Faculty Number is Correct!");
            }
            else 
            {
                MessageBox.Show("INCORRECT!");
            }

        }
    }
}
