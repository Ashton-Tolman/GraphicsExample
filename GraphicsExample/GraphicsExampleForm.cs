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

        //rectangle
        void DrawRectangle()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();//Constructor to create the surface that houses the image
            //create a pen to draw with
            Pen thePen = new Pen(Color.Red);

            g.DrawRectangle(thePen, 100,100, 200, 200);
            

            //Free the resources
            g.Dispose();
            thePen.Dispose();
        }

        //pie

        void DrawPie()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();//Constructor to create the surface that houses the image
            //create a pen to draw with
            Pen thePen = new Pen(Color.Blue);
            SolidBrush theBrush = new SolidBrush(Color.Violet);
            Rectangle bounds = new Rectangle(100, 100, 200, 200);

            //g.DrawPie(thePen, bounds, 0, 45);
            g.FillPie(theBrush, bounds, 0,120);
            theBrush.Color = Color.Blue;
            g.FillPie(theBrush, bounds, 120, 120);
            theBrush.Color= Color.Yellow;
            g.FillPie(theBrush, bounds, 240, 120);

            //Free the resources
            g.Dispose();
            thePen.Dispose();
            theBrush.Dispose();
        }

        //text

        void DrawString()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();//Constructor to create the surface that houses the image
            //create a pen to draw with
            Pen thePen = new Pen(Color.Red);
            Font theFont = new Font("Arial", 24);
            SolidBrush theBrush = new SolidBrush(Color.Violet);
            Rectangle bounds = new Rectangle(100, 100, 200, 200);


            //g.DrawString("Hello", theFont, theBrush, DisplayPictureBox.Width /2, 200);
            g.DrawString("Hello", theFont, theBrush, bounds);

            //Free the resources
            g.Dispose();
            thePen.Dispose();
            theBrush.Dispose();
            theFont.Dispose();
        }


        //image

        void DrawImage()
        {
            int scaleFactor = 1;
            Graphics g = DisplayPictureBox.CreateGraphics();//Constructor to create the surface that houses the image
            //create a pen to draw with
            Image theImage = Image.FromFile("..\\..\\..\\Cruelhorizon.png");
            Rectangle bounds = new Rectangle(800, 1, theImage.Width /scaleFactor, theImage.Height /scaleFactor);

            g.DrawImage(theImage, bounds); //fills rectangle with the image


            //Free the resources
            g.Dispose();
            theImage.Dispose();
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
            DrawRectangle();
            DrawPie();
            DrawString();
            DrawImage();
        }
    }
}
