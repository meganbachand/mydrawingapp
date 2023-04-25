namespace mydrawingapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dark = new System.Windows.Forms.PictureBox();
            this.tan = new System.Windows.Forms.PictureBox();
            this.pink = new System.Windows.Forms.PictureBox();
            this.seagreen = new System.Windows.Forms.PictureBox();
            this.aqua = new System.Windows.Forms.PictureBox();
            this.coral = new System.Windows.Forms.PictureBox();
            this.sienna = new System.Windows.Forms.PictureBox();
            this.rosybrown = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.undo = new System.Windows.Forms.Button();
            this.canvas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seagreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sienna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosybrown)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.PeachPuff;
            this.canvas.Controls.Add(this.textBox1);
            this.canvas.Controls.Add(this.panel2);
            this.canvas.Controls.Add(this.panel1);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 450);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox1.Font = new System.Drawing.Font("Vladimir Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "MY DRAWING APP <3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.undo);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.eraser);
            this.panel2.Location = new System.Drawing.Point(690, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 231);
            this.panel2.TabIndex = 2;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Salmon;
            this.save.Location = new System.Drawing.Point(13, 91);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(58, 45);
            this.save.TabIndex = 1;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.Color.Salmon;
            this.eraser.Location = new System.Drawing.Point(13, 21);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(58, 48);
            this.eraser.TabIndex = 0;
            this.eraser.Text = "erase";
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.dark);
            this.panel1.Controls.Add(this.tan);
            this.panel1.Controls.Add(this.pink);
            this.panel1.Controls.Add(this.seagreen);
            this.panel1.Controls.Add(this.aqua);
            this.panel1.Controls.Add(this.coral);
            this.panel1.Controls.Add(this.sienna);
            this.panel1.Controls.Add(this.rosybrown);
            this.panel1.Location = new System.Drawing.Point(573, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 115);
            this.panel1.TabIndex = 0;
            // 
            // dark
            // 
            this.dark.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dark.Location = new System.Drawing.Point(58, 64);
            this.dark.Name = "dark";
            this.dark.Size = new System.Drawing.Size(30, 32);
            this.dark.TabIndex = 7;
            this.dark.TabStop = false;
            this.dark.Click += new System.EventHandler(this.rosybrown_Click);
            // 
            // tan
            // 
            this.tan.BackColor = System.Drawing.Color.Tan;
            this.tan.Location = new System.Drawing.Point(107, 64);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(30, 32);
            this.tan.TabIndex = 6;
            this.tan.TabStop = false;
            this.tan.Click += new System.EventHandler(this.rosybrown_Click);
            // 
            // pink
            // 
            this.pink.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pink.Location = new System.Drawing.Point(158, 64);
            this.pink.Name = "pink";
            this.pink.Size = new System.Drawing.Size(30, 32);
            this.pink.TabIndex = 5;
            this.pink.TabStop = false;
            this.pink.Click += new System.EventHandler(this.rosybrown_Click);
            // 
            // seagreen
            // 
            this.seagreen.BackColor = System.Drawing.Color.SeaGreen;
            this.seagreen.Location = new System.Drawing.Point(56, 15);
            this.seagreen.Name = "seagreen";
            this.seagreen.Size = new System.Drawing.Size(30, 32);
            this.seagreen.TabIndex = 4;
            this.seagreen.TabStop = false;
            this.seagreen.Click += new System.EventHandler(this.rosybrown_Click);
            // 
            // aqua
            // 
            this.aqua.BackColor = System.Drawing.Color.MediumAquamarine;
            this.aqua.Location = new System.Drawing.Point(107, 15);
            this.aqua.Name = "aqua";
            this.aqua.Size = new System.Drawing.Size(30, 32);
            this.aqua.TabIndex = 3;
            this.aqua.TabStop = false;
            this.aqua.Click += new System.EventHandler(this.rosybrown_Click);
            // 
            // coral
            // 
            this.coral.BackColor = System.Drawing.Color.Coral;
            this.coral.Location = new System.Drawing.Point(158, 15);
            this.coral.Name = "coral";
            this.coral.Size = new System.Drawing.Size(30, 32);
            this.coral.TabIndex = 2;
            this.coral.TabStop = false;
            this.coral.Click += new System.EventHandler(this.rosybrown_Click);
            // 
            // sienna
            // 
            this.sienna.BackColor = System.Drawing.Color.Sienna;
            this.sienna.Location = new System.Drawing.Point(12, 64);
            this.sienna.Name = "sienna";
            this.sienna.Size = new System.Drawing.Size(30, 32);
            this.sienna.TabIndex = 1;
            this.sienna.TabStop = false;
            this.sienna.Click += new System.EventHandler(this.rosybrown_Click);
            // 
            // rosybrown
            // 
            this.rosybrown.BackColor = System.Drawing.Color.RosyBrown;
            this.rosybrown.Location = new System.Drawing.Point(12, 15);
            this.rosybrown.Name = "rosybrown";
            this.rosybrown.Size = new System.Drawing.Size(30, 32);
            this.rosybrown.TabIndex = 0;
            this.rosybrown.TabStop = false;
            this.rosybrown.Click += new System.EventHandler(this.rosybrown_Click);
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.Salmon;
            this.undo.Location = new System.Drawing.Point(13, 160);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(58, 48);
            this.undo.TabIndex = 2;
            this.undo.Text = "undo";
            this.undo.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.canvas.ResumeLayout(false);
            this.canvas.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seagreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sienna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosybrown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel canvas;
        private Panel panel1;
        private PictureBox dark;
        private PictureBox tan;
        private PictureBox pink;
        private PictureBox seagreen;
        private PictureBox aqua;
        private PictureBox coral;
        private PictureBox sienna;
        private PictureBox rosybrown;
        private Panel panel2;
        private Button eraser;
        private TextBox textBox1;
        private Button save;
        private SaveFileDialog saveFileDialog1;
        private Button undo;
    }
}