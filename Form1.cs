namespace mydrawingapp
{
    public partial class Form1 : Form
    {
        Graphics graph;
        Boolean cursor = false;
        Pen pen;
        int x = -1;
        int y = -1;
        
        
        public Form1()
        {
            InitializeComponent();
            graph = canvas.CreateGraphics();
            pen = new Pen(Color.RosyBrown, 7);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        public void rosybrown_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            pen.Color = color.BackColor;
        }

        public void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            cursor = true;
            x = e.X;
            y = e.Y;

            
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            cursor = false;
            x = -1;
            y = -1;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(x != -1 && y != -1 && cursor == true) 
            {
                graph.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.PeachPuff, 7);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {  
                if(e.KeyCode == Keys.Enter)
                {
                    eraser.Focus();
                    eraser.PerformClick();
                }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                }
            }
        }
    }
}