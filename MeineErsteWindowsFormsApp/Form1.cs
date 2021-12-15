namespace MeineErsteWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string vorname = textBoxVorname.Text;
            string nachname = textBoxNachname.Text;
            MessageBox.Show($"Hallo {vorname} {nachname}");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBoxVorname.Text = String.Empty;
            textBoxNachname.Text = String.Empty;
            //Close(); //schlieﬂt das Fenster
        }
        
    }
}