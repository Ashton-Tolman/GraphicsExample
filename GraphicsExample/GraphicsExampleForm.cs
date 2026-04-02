namespace GraphicsExample
{
    public partial class GraphicsExampleForm : Form
    {
        public GraphicsExampleForm()
        {
            InitializeComponent();
        }

        void DrawLine()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();//Constructor to create the surface that houses the image
            //create a pen to draw with
            Pen thePen = new Pen(Color.Black);
            thePen.Color = Color.Black;
            thePen.Width = 10;
            //draw line here
            g.DrawLine(thePen, 0, 0, DisplayPictureBox.Width, DisplayPictureBox.Height);


            //Free the resources
            g.Dispose();
            thePen.Dispose();
        }

        void DrawEllipse()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();//Constructor to create the surface that houses the image
            //create a pen to draw with
            Pen thePen = new Pen(Color.Black);
            thePen.Color = Color.Lime;
            thePen.Width = 5;
            //draw ellipse here
            g.DrawEllipse(thePen, 0, 0, 100, 100);

            //Free the resources
            g.Dispose();
            thePen.Dispose();
        }
        //Event handlers-------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawLine();
            DrawEllipse();
        }
    }
}
