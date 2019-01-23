
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mójPaint
{
   

    public partial class Paint : Form
    {
        /*zmienne i wartości początkowe*/
        private int mouseStartX = 0;
        private int mouseStartY = 0;
        private int mouseCurrentX = 0;
        private int mouseCurrentY = 0;
        private int recSartPointX = 0;
        private int recSartPointY = 0;
        private int recSizeY = 0;
        private int recSizeX = 0;
        private bool mouseDown = false;
        private Bitmap bm;
        private int WybKsztalt = 0;
        private Color UstawKolor;
        private Color UstawKolorWyp;


        public Paint()
        {
            InitializeComponent();
            bm = new Bitmap(pole.Width, pole.Height);
            UstawKolor = Color.Black;
            UstawKolorWyp = Color.Black;
        }

        /*pole Painta*/

        private void pole_Paint(object sender, PaintEventArgs e)
        {
            Graphics setPaint = e.Graphics;
            if (mouseDown == true)
            {
                /*grubość linii*/
                Pen size = new Pen(UstawKolor, float.Parse(lineSize.Text));
                if (WybKsztalt == 1)
                {
                    /*linia*/
                    setPaint.DrawLine(size, new Point(mouseStartX, mouseStartY), new Point(mouseCurrentX + mouseStartX, mouseCurrentY + mouseStartY));
                }
                else if (WybKsztalt == 2)
                {
                    //elipsa
                    setPaint.DrawEllipse(size, mouseStartX, mouseStartY, mouseCurrentX, mouseCurrentY);
                }
                else if (WybKsztalt == 3)
                {
                    //prostokąt
                    setPaint.DrawRectangle(size, recSartPointX, recSartPointY, recSizeX, recSizeY);
                }
            }
            //Paint do bitmapy
            setPaint.DrawImage(bm, new Point(0, 0));
        }

        //LPM nieaktywny
        private void pole_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //rozmiar linii
                Pen size = new Pen(UstawKolor, float.Parse(lineSize.Text));

                mouseDown = false;
                Graphics setPaint = Graphics.FromImage(bm);

                if (WybKsztalt == 1)
                {
                    //rysuj linię
                    setPaint.DrawLine(size, new Point(mouseStartX, mouseStartY), new Point(mouseCurrentX + mouseStartX, mouseCurrentY + mouseStartY));
                }
                else if (WybKsztalt == 2)
                {
                    //elipsę
                    setPaint.DrawEllipse(size, mouseStartX, mouseStartY, mouseCurrentX, mouseCurrentY);
                    setPaint.FillEllipse(new SolidBrush(UstawKolorWyp), mouseStartX, mouseStartY, mouseCurrentX, mouseCurrentY);
                }
                else if (WybKsztalt == 3)
                {
                    //prostokąt
                    setPaint.DrawRectangle(size, recSartPointX, recSartPointY, recSizeX, recSizeY);
                    setPaint.FillRectangle(new SolidBrush(UstawKolorWyp), recSartPointX, recSartPointY, recSizeX, recSizeY);
                }
            }
        }

        //LPM wciśnięty, w polu
        private void pole_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                mouseStartX = e.X;
                mouseStartY = e.Y;
            }
        }

        //ruch myszy w polu
        private void pole_MouseMove(object sender, MouseEventArgs e)
        {
            //wyświetla pozycję
            textBox1.Text = Convert.ToString(mouseCurrentX);
            textBox2.Text = Convert.ToString(mouseCurrentY);

            if (mouseDown == true)
            {
                mouseCurrentX = e.X - mouseStartX;
                mouseCurrentY = e.Y - mouseStartY;

                pole.Invalidate();
            }
            else
            {
                pole.Invalidate();
            }
            //Kalkulacja gdzie narysować prostokąt
            //X- minimum pomiędzy wartością startową a obecną
            recSartPointX = Math.Min(mouseStartX, e.X);
            
            recSartPointY = Math.Min(mouseStartY, e.Y);
            //Szerokość(X)- maks. między pozycją startową i obecną minus min. między startową a obecną
            recSizeX = Math.Max(mouseStartX, e.X) - Math.Min(mouseStartX, e.X);
            //Wysokość- to samo z wartościami Y
            recSizeY = Math.Max(mouseStartY, e.Y) - Math.Min(mouseStartY, e.Y);
        }

        
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
        }
        //linia
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            WybKsztalt = 1;
        }
        //elipsa
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            WybKsztalt = 2;
        }
        //prostokąt
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            WybKsztalt = 3;
        }
        //Wybór koloru krawędzi kształtu/linii
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            UstawKolor = Color.Black;
        }
        
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            UstawKolor = Color.Blue;
        }
        
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            UstawKolor = Color.Green;
        }
        
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            UstawKolor = Color.Purple;
        }
        
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            UstawKolor = Color.Red;
        }
        
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            UstawKolor = Color.Yellow;
        }

        //czyszczenie #1
        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz wyczyścić?", "Wyczyść", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bm = new Bitmap(pole.Width, pole.Height);
                pole.BackgroundImage = bm;
                Graphics setPaint = Graphics.FromImage(bm);
                setPaint.Clear(pole.BackColor);
                setPaint.Dispose();
            }
        }

        //paketa kolorów #1 (kształty)
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            ColorDialog Paleta = new ColorDialog();
            if (Paleta.ShowDialog() == DialogResult.OK)
            {
                UstawKolor = Paleta.Color;
            }
        }

        //zapis #1

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pole.Width, pole.Height);
            Graphics setPaint = Graphics.FromImage(bm);
            Rectangle rect = pole.RectangleToScreen(pole.ClientRectangle);
            setPaint.CopyFromScreen(rect.Location, Point.Empty, pole.Size);
            pole.Dispose();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "pliki Png| *.png| pliki jpeg| *jpg| bitmapy| *bmp";

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (File.Exists(save.FileName))
                    {
                        File.Delete(save.FileName);
                    }
                    if (save.FileName.Contains(".jpg"))
                    {
                        bm.Save(save.FileName, ImageFormat.Jpeg);
                    }
                    else if (save.FileName.Contains(".png"))
                    {
                        bm.Save(save.FileName, ImageFormat.Png);
                    }
                    else if (save.FileName.Contains(".bmp"))
                    {
                        bm.Save(save.FileName, ImageFormat.Bmp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błą zapisu: " + ex.Message);
                }
            }
        }

        //otwórz...#1
        private void openPaint_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "pliki png| *.png|pliki jpeg| *jpg| bitmapy| *bmp";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Bitmap oldbm = bm;
                    bm = new Bitmap(open.FileName);
                    oldbm.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd wczytania obrazu" + ex.Message);
                }
                
            }
        }

        //zapis#2
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pole.Width, pole.Height);
            Graphics setPaint = Graphics.FromImage(bm);
            Rectangle rect = pole.RectangleToScreen(pole.ClientRectangle);
            setPaint.CopyFromScreen(rect.Location, Point.Empty, pole.Size);
            pole.Dispose();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Png files| *.png| jpeg files| *jpg| bitmaps| *bmp";

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (File.Exists(save.FileName))
                    {
                        File.Delete(save.FileName);
                    }
                    if (save.FileName.Contains(".jpg"))
                    {
                        bm.Save(save.FileName, ImageFormat.Jpeg);
                    }
                    else if (save.FileName.Contains(".png"))
                    {
                        bm.Save(save.FileName, ImageFormat.Png);
                    }
                    else if (save.FileName.Contains(".bmp"))
                    {
                        bm.Save(save.FileName, ImageFormat.Bmp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File save error : " + ex.Message);
                }
            }
        }

    
        //otwórz...#2
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "pliki png| *.png|pliki jpeg| *jpg| bitmapy| *bmp";

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Bitmap oldbm = bm;
                    bm = new Bitmap(open.FileName);
                    oldbm.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd wczytania obrazu" + ex.Message);
                }

            }
        }

        //paleta #2 (wypełnienie)
        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            ColorDialog Paleta2 = new ColorDialog();
            if (Paleta2.ShowDialog() == DialogResult.OK)
            {
                UstawKolorWyp = Paleta2.Color;
            }
        }

        //kolory wypełnień
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            UstawKolorWyp = Color.Black;
        }
        
        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            UstawKolorWyp = Color.Blue;
        }
        
        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            UstawKolorWyp = Color.Green;
        }
        
        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            UstawKolorWyp = Color.Purple;
        }
        
        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            UstawKolorWyp = Color.Red;
        }
        
        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            UstawKolorWyp = Color.Yellow;
        }

        //Nowy...
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcesz wyczyścić i rozpocząć nowy?", "Wyczyść", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bm = new Bitmap(pole.Width, pole.Height);
                pole.BackgroundImage = bm;
                Graphics setPaint = Graphics.FromImage(bm);
                setPaint.Clear(pole.BackColor);
                setPaint.Dispose();
            }
        }
    }
}