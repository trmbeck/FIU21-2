namespace WinFormsÜbungPolymorphie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasis_Click(object sender, EventArgs e)
        {
            Sub sub = new Sub();
            Basis basis = sub;
            label1.Text = basis.Test();
        }

        private void btnTestInt_Click(object sender, EventArgs e)
        {
            Sub sub = new Sub();
            Basis basis = sub;
            label1.Text = basis.Test(10);
        }

        private void btnTestString_Click(object sender, EventArgs e)
        {
            Sub sub = new Sub();
            Basis basis = sub;
            label1.Text = basis.Test("Hallo");
        }
    }
}