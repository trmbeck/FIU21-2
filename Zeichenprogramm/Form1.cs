namespace Zeichenprogramm
{
    public partial class Form1 : Form
    {
        Circle[] circleList = new Circle[10];
        Rectangle[] rectangleList = new Rectangle[10];
        object[] objectList = new object[10];

        int rectangleListIndex = 0;
        int circleListIndex = 0;
        int objectListIndex = 0;

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
            objectList[objectListIndex] = circle;
            objectListIndex++;

            //evtl. Prüfung, ob Kreis mit gleichen Daten schon vorhanden
            //circleList[circleListIndex] = circle;
            //circleListIndex++;
            //evtl. Prüfung, ob Index >= Length

            //Graphics panelGraphics = panelAusgabe.CreateGraphics();
            //Pen pen = new Pen(Color.Black);

            //System.Drawing.Rectangle rectangle = circle.GetWinFormRectangle();

            //panelGraphics.DrawEllipse(pen, rectangle);

            DrawCirclesAndRectangles();

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
            objectList[objectListIndex] = rectangle;
            objectListIndex++;

            //rectangleList[rectangleListIndex] = rectangle;
            //rectangleListIndex++;

            //Graphics panelGraphics = panelAusgabe.CreateGraphics();

            //panelGraphics.DrawRectangle(new Pen(Color.Black), rectangle.GetWinFormsRectangle());
            DrawCirclesAndRectangles();
        }

        private void DrawCirclesAndRectangles()
        {
            Graphics panelGraphics = panelAusgabe.CreateGraphics();
            panelGraphics.Clear(SystemColors.Control);

            //for (int i = 0; i < circleListIndex; i++)
            //{
            //    panelGraphics.DrawEllipse(new Pen(Color.Black), circleList[i].GetWinFormRectangle());
            //}
            //for (int i = 0; i < rectangleListIndex; i++)
            //{
            //    panelGraphics.DrawRectangle(new Pen(Color.Red), rectangleList[i].GetWinFormsRectangle());
            //}

            for (int i = 0; i < objectListIndex; i++)
            {
                if (objectList[i] is Circle)
                {
                    panelGraphics.DrawEllipse(new Pen(Color.Black), (objectList[i] as Circle).GetWinFormRectangle());
                }
                else
                {
                    if (objectList[i] is Rectangle)
                    {
                        panelGraphics.DrawRectangle(new Pen(Color.Red), (objectList[i] as Rectangle).GetWinFormsRectangle());
                    }
                }
            }
        }
    }
}