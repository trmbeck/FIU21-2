namespace Passwortabfrage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //user:  einUser
            //admin: ad2013min
            if (txbPasswort.Text == "ad2013min")
            {
                txbAusgabe.Text = "Sie sind als Administrator angemeldet";
            }
            else
            {
                if (txbPasswort.Text == "einUser")
                {
                    txbAusgabe.Text = "Sie haben sich als User angemeldet";
                }
                else
                { 
                    txbAusgabe.Text = "Sie sind nur als Gast angemeldet"; 
                }
            }
        }
    }
}