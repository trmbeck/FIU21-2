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

            System.Drawing.Rectangle rectangle = circle.GetWinFormRectangle();

            panelGraphics.DrawEllipse(pen, rectangle);

            for (int i = 0; i < circleListIndex; i++)
            {
                System.Diagnostics.Debug.WriteLine(circleList[i].GetInfo());
            }
        }

        private void btnCreateRectangle_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txbRectangleX.Text);
            double y = Convert.ToDouble(txbRectangleY.Text);
            double a = Convert.ToDouble(txbRectangleA.Text);
            double b = Convert.ToDouble(txbRectangleB.Text);

            Rectangle rectangle = new Rectangle(x, y, a, b);

            Graphics panelGraphics = panelAusgabe.CreateGraphics();

            panelGraphics.DrawRectangle(new Pen(Color.Black), rectangle.GetWinFormsRectangle());

        }
    }
}