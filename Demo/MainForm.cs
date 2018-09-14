using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Demo.Properties;
using System.ComponentModel;


namespace Demo
{
    public partial class MainForm : Form
    {
        private Button button1;
        private CheckedListBox checkedListBox1;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button2;
        private TabPage tabPage3;
        private ImageList imageList1;
        private System.ComponentModel.IContainer components;
        private PictureBox pictureBox1;
        private Panel panel1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(95, 64);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 84);
            this.checkedListBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(233, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&&这是标题";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 25);
            this.tabControl1.Location = new System.Drawing.Point(450, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(193, 335);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Enabled = false;
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(160, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(160, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(160, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "My New Tab2";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "5.png");
            this.imageList1.Images.SetKeyName(1, "3.jpg");
            this.imageList1.Images.SetKeyName(2, "8.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PictureBox1_LoadCompleted);
            this.pictureBox1.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.pictureBox1_LoadProgressChanged);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(834, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox1_LoadProgressChanged(object sender,
    ProgressChangedEventArgs e)
        {
            Console.WriteLine("图片进度：" + e.ProgressPercentage);
        }

        private void PictureBox1_LoadCompleted(Object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Load Completed 执行完毕");
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();
            Pen redp = new Pen(Color.Red, 3.0f);
            Pen bluep = new Pen(Color.Blue, 1.0f);
            Pen purplep = new Pen(Color.Purple, 2.0f);
            Pen greenp = new Pen(Color.Green, 1.5f);
            SolidBrush sb = new SolidBrush(Color.LightBlue);



            // Create a matrix and rotate it 45 degrees.
            Matrix myMatrix = new Matrix(2.0f,1.0f,0.0f,1.0f,0.0f,0.0f);
            Matrix myMatrix2 = new Matrix(0.0f, 1.0f, -1.0f, 0.0f, 0.0f, 0.0f);
            Matrix myMatrix3 = new Matrix(1.0f, 0.0f, 0.0f, 1.0f, 250.0f, 50.0f);

            myMatrix.Multiply(myMatrix2);

            for (int i = 0; i < 6; i++) {
                Console.WriteLine("m1xm2: Elements[" + i + "] = " + myMatrix.Elements[i]);
            }

            myMatrix.Multiply(myMatrix3, MatrixOrder.Prepend);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("m1xm2xm3: Elements[" + i + "] = " + myMatrix.Elements[i]);
            }

            g.DrawRectangle(bluep, 0.0f,0.0f,420.0f,286.0f);
            

            Matrix m = new Matrix();
            //m.Scale(2, 2, MatrixOrder.Append);
            m.Translate(100, 100);

            Point[] myArray =
             {
                 new Point(20, 20),
                 new Point(120, 20),
                 new Point(120, 120),
                 new Point(20, 120)
                 ,new Point(20,20)
             };

            g.DrawLines(redp, myArray);

            m.TransformPoints(myArray);

            g.DrawLines(bluep, myArray);

            m.Reset();
            m.TransformPoints(myArray);

            g.DrawLines(purplep, myArray);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
