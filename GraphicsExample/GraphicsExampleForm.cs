using System.Drawing;
namespace GraphicsExample
{
    public partial class GraphicsExampleForm : Form
    {
        public GraphicsExampleForm()
        {
            InitializeComponent();

            //map event handlers 
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseStuff;
            //DisplayPictureBox.MouseDown += DisplayPictureBox_MouseDown;
            DisplayPictureBox.MouseDown += DisplayPictureBox_MouseStuff;//now the mouse down event is never called
            PenContextMenuItem.Click += PenColor_Click;
            BackGroundContextMenuItem.Click += BackGroundContextMenuItem_Click;
            PenSizeComboBox.SelectedIndexChanged += PenSizeComboBox_SelectedIndexChanged;
            //Populate pen size combo box
            PenSizeComboBox.Items.Add(1);
            PenSizeComboBox.Items.Add(2);
            PenSizeComboBox.Items.Add(3);
            PenSizeComboBox.Items.Add(5);
            PenSizeComboBox.Items.Add(10);
            PenSizeComboBox.SelectedIndex = 0;

        }



        private Color PenColor = Color.Black;
        private Color backGroundColor = Color.White;
        private int penSize = 1;
        private int oldX, oldY;


        void DrawLineSegment(int newX, int newY)
        {
            Graphics g = DisplayPictureBox.CreateGraphics();//Constructor to create the surface that houses the image
            //create a pen to draw with
            Pen thePen = new Pen(this.PenColor);
            thePen.Width = this.penSize;

            //draw line here
            g.DrawLine(thePen, oldX, oldY, newX, newY);



            //Free the resources
            g.Dispose();
            thePen.Dispose();
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

            g.DrawRectangle(thePen, 100, 100, 200, 200);


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
            g.FillPie(theBrush, bounds, 0, 120);
            theBrush.Color = Color.Blue;
            g.FillPie(theBrush, bounds, 120, 120);
            theBrush.Color = Color.Yellow;
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
            int scaleFactor = 4;
            Graphics g = DisplayPictureBox.CreateGraphics();//Constructor to create the surface that houses the image
            //create a pen to draw with
            Image theImage = Image.FromFile("..\\..\\..\\Cruelhorizon.png");
            Rectangle bounds = new Rectangle(800, 1, theImage.Width / scaleFactor, theImage.Height / scaleFactor);

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

        void UpdatePenColor()
        {
            PenColorDialog.ShowDialog();
            this.PenColor = PenColorDialog.Color;
        }

        void UpdateBackGroundColor()
        {
            PenColorDialog.ShowDialog();
            this.backGroundColor = PenColorDialog.Color;
            DisplayPictureBox.BackColor = this.backGroundColor;
        }

        void UpdatePenSize()
        {
            this.penSize = int.Parse(PenSizeComboBox.SelectedItem.ToString());
        }

        void DrawSineWave()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();//Constructor to create the surface that houses the image
            //create a pen to draw with
            Pen thePen = new Pen(Color.Lime);
            thePen.Width = 2;
            int lastX = 0, lastY = 0, currentY = 0;
            float scaleX = DisplayPictureBox.Width / 360F;
            float scaleY = (DisplayPictureBox.Height / 200F) * -1;

            g.TranslateTransform(0, DisplayPictureBox.Height / 2);

            g.ScaleTransform(scaleX, scaleY);

            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Sin((Math.PI / 180) * currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;


            }



            //Free the resources
            g.Dispose();
            thePen.Dispose();
        }

        void DrawGrid()
        {
            DisplayPictureBox.Refresh();
            Color oldColor = this.PenColor;
            this.PenColor = Color.Gray;
            int oldPenSize = this.penSize;
            this.penSize = 1;
            int xDiv = DisplayPictureBox.Width / 10;
            int yDiv = DisplayPictureBox.Height / 8;

            this.oldX = 0;
            this.oldY = 0;

            for (int x = 0; x < DisplayPictureBox.Width; x += xDiv)
            {
                oldX = x;
                DrawLineSegment(x, DisplayPictureBox.Height);
            }

            this.oldX = 0;
            this.oldY = 0;

            for (int y = 0; y < DisplayPictureBox.Height; y += yDiv)
            {
                oldY = y;
                DrawLineSegment(DisplayPictureBox.Width, y);
            }

            this.PenColor = oldColor;
            this.penSize = oldPenSize;
        }


        //Event handlers-------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawGrid();
            //DrawLine();
            //DrawEllipse();
            //DrawRectangle();
            //DrawPie();
            //DrawString();
            //DrawImage();
            DrawSineWave();
        }

        private void DisplayPictureBox_MouseStuff(object? sender, MouseEventArgs e)
        {
            DrawingStatusLabel.Text = $"({e.X.ToString().PadLeft(4)},{e.Y.ToString().PadLeft(4)}) | {e.Button} | {this.penSize} | {this.PenColor.Name}";
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawLineSegment(e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    //Keep for context boxes 
                    break;
                case MouseButtons.Middle:
                    UpdatePenColor();
                    break;
                case MouseButtons.None:
                    break;
                default:
                    MessageBox.Show($"{e.Button}");
                    break;
            }
            oldX = e.X;
            oldY = e.Y;
        }
        private void DisplayPictureBox_MouseDown(object? sender, MouseEventArgs e)
        {
            this.Text += $"{e.Button}";

            PenColorDialog.ShowDialog();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayPictureBox.Refresh();
        }

        private void PenColor_Click(object? sender, EventArgs e)
        {
            UpdatePenColor();
        }

        private void BackGroundContextMenuItem_Click(object? sender, EventArgs e)
        {
            UpdateBackGroundColor();
        }

        private void PenSizeComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdatePenSize();
        }

        private void AboutTopMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm(); //instantiate the about form
            aboutForm.FormClosed += AboutForm_FormClosed;// map the formclosed event to a handler
            aboutForm.Show(); //Opens the about form
            this.Hide(); // Hides the graphics form
        }

        private void AboutForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();// shows the graphics form when about form is closed
        }
    }
}
