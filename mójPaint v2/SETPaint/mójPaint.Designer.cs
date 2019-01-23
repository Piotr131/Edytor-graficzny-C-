namespace mójPaint
{
    partial class Paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.Erase = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.openPaint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.Sphere = new System.Windows.Forms.ToolStripButton();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Black = new System.Windows.Forms.ToolStripButton();
            this.Blue = new System.Windows.Forms.ToolStripButton();
            this.Green = new System.Windows.Forms.ToolStripButton();
            this.Purple = new System.Windows.Forms.ToolStripButton();
            this.Red = new System.Windows.Forms.ToolStripButton();
            this.Yellow = new System.Windows.Forms.ToolStripButton();
            this.ColorWheel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.Black_Filling = new System.Windows.Forms.ToolStripButton();
            this.Blue_Filling = new System.Windows.Forms.ToolStripButton();
            this.Green_filling = new System.Windows.Forms.ToolStripButton();
            this.Purple_Filling = new System.Windows.Forms.ToolStripButton();
            this.Red_Filling = new System.Windows.Forms.ToolStripButton();
            this.Yellow_Filling = new System.Windows.Forms.ToolStripButton();
            this.Color_Wheel_Filling = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Line_Boarder_Size = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.lineSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pole = new mójPaint.SETPanel();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator9,
            this.Erase,
            this.Save,
            this.openPaint,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.Line,
            this.Sphere,
            this.Rectangle,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripSeparator4,
            this.Black,
            this.Blue,
            this.Green,
            this.Purple,
            this.Red,
            this.Yellow,
            this.ColorWheel,
            this.toolStripSeparator10,
            this.toolStripLabel4,
            this.toolStripSeparator11,
            this.Black_Filling,
            this.Blue_Filling,
            this.Green_filling,
            this.Purple_Filling,
            this.Red_Filling,
            this.Yellow_Filling,
            this.Color_Wheel_Filling,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.toolStripSeparator6,
            this.Line_Boarder_Size,
            this.toolStripSeparator8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(908, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // Erase
            // 
            this.Erase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Erase.Image = ((System.Drawing.Image)(resources.GetObject("Erase.Image")));
            this.Erase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(23, 22);
            this.Erase.Text = "Erase Paint";
            this.Erase.Click += new System.EventHandler(this.toolStripButton13_Click);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Text = "Save File";
            this.Save.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // openPaint
            // 
            this.openPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openPaint.Image = ((System.Drawing.Image)(resources.GetObject("openPaint.Image")));
            this.openPaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openPaint.Name = "openPaint";
            this.openPaint.Size = new System.Drawing.Size(23, 22);
            this.openPaint.Text = "Open File";
            this.openPaint.Click += new System.EventHandler(this.openPaint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel1.Text = "Kształty";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(23, 22);
            this.Line.Text = "Draw Line";
            this.Line.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Sphere
            // 
            this.Sphere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sphere.Image = ((System.Drawing.Image)(resources.GetObject("Sphere.Image")));
            this.Sphere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sphere.Name = "Sphere";
            this.Sphere.Size = new System.Drawing.Size(23, 22);
            this.Sphere.Text = "Draw Sphere";
            this.Sphere.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(23, 22);
            this.Rectangle.Text = "Draw Rectangle";
            this.Rectangle.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel2.Text = "Kolor Linii";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Black
            // 
            this.Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Black.Image = ((System.Drawing.Image)(resources.GetObject("Black.Image")));
            this.Black.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(23, 22);
            this.Black.Text = "colorBlack";
            this.Black.ToolTipText = "Black";
            this.Black.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Blue
            // 
            this.Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Blue.Image = ((System.Drawing.Image)(resources.GetObject("Blue.Image")));
            this.Blue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(23, 22);
            this.Blue.Text = "colorBlue";
            this.Blue.ToolTipText = "Blue";
            this.Blue.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // Green
            // 
            this.Green.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Green.Image = ((System.Drawing.Image)(resources.GetObject("Green.Image")));
            this.Green.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(23, 22);
            this.Green.Text = "colorGreen";
            this.Green.ToolTipText = "Green";
            this.Green.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // Purple
            // 
            this.Purple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Purple.Image = ((System.Drawing.Image)(resources.GetObject("Purple.Image")));
            this.Purple.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(23, 22);
            this.Purple.Text = "colorPurple";
            this.Purple.ToolTipText = "Purple";
            this.Purple.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // Red
            // 
            this.Red.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Red.Image = ((System.Drawing.Image)(resources.GetObject("Red.Image")));
            this.Red.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(23, 22);
            this.Red.Text = "colorRed";
            this.Red.ToolTipText = "Red";
            this.Red.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // Yellow
            // 
            this.Yellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Yellow.Image = ((System.Drawing.Image)(resources.GetObject("Yellow.Image")));
            this.Yellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(23, 22);
            this.Yellow.Text = "colorYellow";
            this.Yellow.ToolTipText = "Yellow";
            this.Yellow.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // ColorWheel
            // 
            this.ColorWheel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorWheel.Image = ((System.Drawing.Image)(resources.GetObject("ColorWheel.Image")));
            this.ColorWheel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorWheel.Name = "ColorWheel";
            this.ColorWheel.Size = new System.Drawing.Size(23, 22);
            this.ColorWheel.Text = "toolStripButton10";
            this.ColorWheel.ToolTipText = "Color Wheel";
            this.ColorWheel.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(101, 22);
            this.toolStripLabel4.Text = "Kolor wypełnienia";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // Black_Filling
            // 
            this.Black_Filling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Black_Filling.Image = ((System.Drawing.Image)(resources.GetObject("Black_Filling.Image")));
            this.Black_Filling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Black_Filling.Name = "Black_Filling";
            this.Black_Filling.Size = new System.Drawing.Size(23, 22);
            this.Black_Filling.Text = "fillBlack";
            this.Black_Filling.ToolTipText = "Black";
            this.Black_Filling.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // Blue_Filling
            // 
            this.Blue_Filling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Blue_Filling.Image = ((System.Drawing.Image)(resources.GetObject("Blue_Filling.Image")));
            this.Blue_Filling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Blue_Filling.Name = "Blue_Filling";
            this.Blue_Filling.Size = new System.Drawing.Size(23, 22);
            this.Blue_Filling.Text = "fillBlue";
            this.Blue_Filling.ToolTipText = "Blue";
            this.Blue_Filling.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // Green_filling
            // 
            this.Green_filling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Green_filling.Image = ((System.Drawing.Image)(resources.GetObject("Green_filling.Image")));
            this.Green_filling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Green_filling.Name = "Green_filling";
            this.Green_filling.Size = new System.Drawing.Size(23, 22);
            this.Green_filling.Text = "fillGreen";
            this.Green_filling.ToolTipText = "Green";
            this.Green_filling.Click += new System.EventHandler(this.toolStripButton15_Click);
            // 
            // Purple_Filling
            // 
            this.Purple_Filling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Purple_Filling.Image = ((System.Drawing.Image)(resources.GetObject("Purple_Filling.Image")));
            this.Purple_Filling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Purple_Filling.Name = "Purple_Filling";
            this.Purple_Filling.Size = new System.Drawing.Size(23, 22);
            this.Purple_Filling.Text = "fillPurple";
            this.Purple_Filling.ToolTipText = "Purple";
            this.Purple_Filling.Click += new System.EventHandler(this.toolStripButton16_Click);
            // 
            // Red_Filling
            // 
            this.Red_Filling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Red_Filling.Image = ((System.Drawing.Image)(resources.GetObject("Red_Filling.Image")));
            this.Red_Filling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Red_Filling.Name = "Red_Filling";
            this.Red_Filling.Size = new System.Drawing.Size(23, 22);
            this.Red_Filling.Text = "fillRed";
            this.Red_Filling.ToolTipText = "Red";
            this.Red_Filling.Click += new System.EventHandler(this.toolStripButton17_Click);
            // 
            // Yellow_Filling
            // 
            this.Yellow_Filling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Yellow_Filling.Image = ((System.Drawing.Image)(resources.GetObject("Yellow_Filling.Image")));
            this.Yellow_Filling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Yellow_Filling.Name = "Yellow_Filling";
            this.Yellow_Filling.Size = new System.Drawing.Size(23, 22);
            this.Yellow_Filling.Text = "fillYellow";
            this.Yellow_Filling.ToolTipText = "Yellow";
            this.Yellow_Filling.Click += new System.EventHandler(this.toolStripButton19_Click);
            // 
            // Color_Wheel_Filling
            // 
            this.Color_Wheel_Filling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Color_Wheel_Filling.Image = ((System.Drawing.Image)(resources.GetObject("Color_Wheel_Filling.Image")));
            this.Color_Wheel_Filling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Color_Wheel_Filling.Name = "Color_Wheel_Filling";
            this.Color_Wheel_Filling.Size = new System.Drawing.Size(23, 22);
            this.Color_Wheel_Filling.Text = "fillColorWheel";
            this.Color_Wheel_Filling.ToolTipText = "Color Wheel";
            this.Color_Wheel_Filling.Click += new System.EventHandler(this.toolStripButton18_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel3.Text = "Szer. linii";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // Line_Boarder_Size
            // 
            this.Line_Boarder_Size.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line_Boarder_Size.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.lineSize});
            this.Line_Boarder_Size.Image = ((System.Drawing.Image)(resources.GetObject("Line_Boarder_Size.Image")));
            this.Line_Boarder_Size.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line_Boarder_Size.Name = "Line_Boarder_Size";
            this.Line_Boarder_Size.Size = new System.Drawing.Size(29, 22);
            this.Line_Boarder_Size.Text = "toolStripDropDownButton1";
            this.Line_Boarder_Size.ToolTipText = "Adjust Line or Boarder Size";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(157, 6);
            // 
            // lineSize
            // 
            this.lineSize.Name = "lineSize";
            this.lineSize.Size = new System.Drawing.Size(100, 23);
            this.lineSize.Text = "1";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 538);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(29, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 536);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 20);
            this.textBox2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.fileToolStripMenuItem.Text = "&Plik...";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "&Nowy";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "&Otwórz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "&Zapisz";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mysz (X)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(111, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mysz (Y)";
            // 
            // pole
            // 
            this.pole.BackColor = System.Drawing.Color.White;
            this.pole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pole.Location = new System.Drawing.Point(12, 52);
            this.pole.Name = "pole";
            this.pole.Size = new System.Drawing.Size(773, 480);
            this.pole.TabIndex = 1;
            this.pole.Paint += new System.Windows.Forms.PaintEventHandler(this.pole_Paint);
            this.pole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pole_MouseDown);
            this.pole.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pole_MouseMove);
            this.pole.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pole_MouseUp);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pole);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Paint";
            this.Text = "mójPaint v2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton Sphere;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Black;
        private System.Windows.Forms.ToolStripButton Blue;
        private System.Windows.Forms.ToolStripButton Green;
        private System.Windows.Forms.ToolStripButton Purple;
        private System.Windows.Forms.ToolStripButton Red;
        private System.Windows.Forms.ToolStripButton Yellow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton Line_Boarder_Size;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton Erase;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton openPaint;
        private System.Windows.Forms.ToolStripButton ColorWheel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripTextBox lineSize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton Black_Filling;
        private System.Windows.Forms.ToolStripButton Blue_Filling;
        private System.Windows.Forms.ToolStripButton Green_filling;
        private System.Windows.Forms.ToolStripButton Purple_Filling;
        private System.Windows.Forms.ToolStripButton Red_Filling;
        private System.Windows.Forms.ToolStripButton Yellow_Filling;
        private System.Windows.Forms.ToolStripButton Color_Wheel_Filling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SETPanel pole;
    }
}

