namespace TierSimulation
{
    public partial class Form1 : Form
    {
        Loewe loewe;
        Storch storch;
        Hai hai;
        Frosch frosch;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loewe l = new Loewe(100, 20, "braun", true);
            loewe = l;
            
            lb_Tiere.Items.Add("Löwe");

            storch = new Storch();
            lb_Tiere.Items.Add("Storch");
            
            hai = new Hai();
            lb_Tiere.Items.Add("Hai");

            frosch = new Frosch();
            lb_Tiere.Items.Add("Frosch");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lb_Tiere.SelectedIndex != -1)
            {
                if (lb_Tiere.SelectedItem.ToString() == "Frosch")
                {
                    bool istErfolgreich = loewe.Jagen(frosch);
                    MessageBox.Show("War erfolgreich: " + istErfolgreich);
                }
                else
                {
                    if (lb_Tiere.SelectedItem.ToString() == "Hai")
                    {
                        bool istErfolgreich = loewe.Jagen(hai);
                        MessageBox.Show("War erfolgreich: " + istErfolgreich);
                    }
                    else
                    {
                        if (lb_Tiere.SelectedItem.ToString() == "Storch")
                        {
                            bool istErfolgreich = loewe.Jagen(storch);
                            MessageBox.Show("War erfolgreich: " + istErfolgreich);
                        }
                    }
                }
            }
        }

        private void btnNestBauen_Click(object sender, EventArgs e)
        {
            storch.NestBauen("Schornstein", new string[] { "Ast", "Zweig", "Blatt", "Gras", "Zweig", "Blatt" });
        }
    }
}