namespace Zeichenprogramm
{
    public partial class Form1 : Form
    {
        Circle[] circleList = new Circle[10];
        int circleListIndex = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateCircle_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txbX.Text);
            double y = Convert.ToDouble(txbY.Text);
            double radius = Convert.ToDouble(txbRadius.Text);

            Circle circle = new Circle(x, y, radius);
            //evtl. Prüfung, ob Kreis mit gleichen Daten schon vorhanden
            circleList[circleListIndex] = circle;
            circleListIndex++;
            //evtl. Prüfung, ob Index >= Length

            Graphics panelGraphics = panelAusgabe.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            Rectangle rectangle = circle.GetWinFormRectangle();

            panelGraphics.DrawEllipse(pen, rectangle);

            for (int i = 0; i < circleListIndex; i++)
            {
                System.Diagnostics.Debug.WriteLine(circleList[i].GetInfo());
            }
        }
    }
}