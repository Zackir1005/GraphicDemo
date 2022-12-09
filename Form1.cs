using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicDemo
{
    public partial class Form1 : Form
    {
        private int x = 15;
        Font Hello_font = new Font("Verdana", 14, FontStyle.Italic);
        RichTextBox refFontFormRTB;
        Form refCBForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Paint += Hello_World;
        }
        private void Hello_World(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            Graphics g = e.Graphics;
            //refFontFormRTB.

            Pen pn = new Pen(Brushes.BlueViolet, 20);
            var pn2 = new Pen(Brushes.DarkOrange, 4);
            pn.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.DrawEllipse(pn, x, 10, 300, 140);

            Point lt = new Point(x, 10);
            Point rb = new Point(x + 300, 150);

            Rectangle rect = new Rectangle(x, 10, 200, 150);
            var myBrush = new LinearGradientBrush(lt, rb, Color.Yellow, Color.Blue);
            g.FillEllipse(myBrush, rect);

            string s = "Hello World!";
            //var _font = new Font("Verdana", 14, FontStyle.Italic);
            var _font = Hello_font;
            g.DrawString(s, _font, Brushes.DarkOrange, x + 50, 70);
            g.DrawLine(pn2, x + 45, 55, x + 45, 115);
            g.DrawLine(pn2, x + 45, 115, x + 245, 85);
            g.DrawLine(pn2, x + 45, 55, x + 245, 85);


        }



        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var _timer = new Timer();
            _timer.Enabled = true;
            _timer.Interval = 30;
            bool move_right = true;
            _timer.Tick += (object sender02, EventArgs e02) =>
            {
                int xStep = 2;

                if ((x < 350) & (move_right))
                {
                    x += xStep;
                    this.Refresh();
                    this.Paint -= Hello_World;
                    this.Paint += Hello_World;
                }
                else
                {
                    Text = $"{x}";
                    move_right = false;
                }
                if ((x > 10) & (!move_right))
                {
                    x -= xStep;
                    this.Refresh();
                    this.Paint -= Hello_World;
                    this.Paint += Hello_World;
                }
                else
                {
                    Text = $"{x}";
                    move_right = true;
                }
            };
            _timer.Start();
        }

        private void buttonChangeFont_MouseClick(object sender, MouseEventArgs e)
        {
            InstalledFontCollection fontCollection = new InstalledFontCollection();
            var FontForm = new Form();
            var textBoxFont = new RichTextBox();
            refFontFormRTB = textBoxFont;
            var listBoxFont = new ListBox();
            var _locationTB = new Point(10, 10);
            var _locationLB = new Point(130, 10);
            var _size = new Size(120, 450);
            textBoxFont.Size = _size;
            textBoxFont.Location = _locationTB;
            listBoxFont.Location = _locationLB;
            listBoxFont.SelectedValueChanged += (object sender01, EventArgs e01) =>
            {
                Font _font = new Font(listBoxFont.SelectedItem.ToString(), 14, FontStyle.Italic);
                Hello_font = _font;
            };
            foreach (var item in fontCollection.Families)
            {
                textBoxFont.Text += $" {item.Name.ToString()}\n";
                listBoxFont.Items.Add(item.Name);
            }
            FontForm.Controls.Add(textBoxFont);
            FontForm.Controls.Add(listBoxFont);
            //Region region = new Region();
            FontForm.Show();
        }

        private void buttonClearRTB_MouseClick(object sender, MouseEventArgs e)
        {
            refFontFormRTB.Dispose();
        }

        private void ChessBoardPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rectHoriz = new Rectangle(30, 0, 60 * 8, 30);
            Rectangle rectVert = new Rectangle(0, 30, 30, 60 * 8);
            g.FillRectangle(Brushes.Gray, rectHoriz);
            g.FillRectangle(Brushes.Gray, rectVert);
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i <= 7; i++)
                {
                    if (i % 2 == 0)
                    {
                        Rectangle rectCell = new Rectangle(30 + 60 * i, 30 + 120 * j, 60, 60);
                        g.FillRectangle(Brushes.White, rectCell);
                    }
                    else
                    {
                        Rectangle rectCell = new Rectangle(30 + 60 * i, 30 + 120 * j, 60, 60);
                        g.FillRectangle(Brushes.Black, rectCell);
                    }
                    if (i % 2 == 0)
                    {
                        Rectangle rectCell = new Rectangle(30 + 60 * i, 90 + 120 * j, 60, 60);
                        g.FillRectangle(Brushes.Black, rectCell);
                    }
                    else
                    {
                        Rectangle rectCell = new Rectangle(30 + 60 * i, 90 + 120 * j, 60, 60);
                        g.FillRectangle(Brushes.White, rectCell);
                    }

                }
            }
            for (int i = (int)'A'; i <= (int)'H'; i++)
            {
                string s = ((char)i).ToString();
                g.DrawString(s, Hello_font, Brushes.DarkOrange, 45 + (i - (int)'A') * 60, 5);
                for (int j = (int)'1'; j <= (int)'8'; j++)
                {
                    string S = ((char)j).ToString();
                    g.DrawString(S, Hello_font, Brushes.Orange, 5, 45 + (j - (int)'1') * 60);
                }
            }

        }
        private void buttonShowBoard_MouseClick(object sender, MouseEventArgs e)
        {
            var ChessBoardForm = new Form();
            refCBForm = ChessBoardForm;
            ChessBoardForm.Paint += ChessBoardPaint;
            ChessBoardForm.Text = "Chesboard";
            int boardCellMetric = 60;
            int boardServiceField = 30;
            int x = 2 * boardServiceField + 8 * boardCellMetric;
            int y = 2 * boardServiceField + 8 * boardCellMetric;
            var CBSize = new Size(x, y);
            ChessBoardForm.MinimumSize =
                ChessBoardForm.MaximumSize =
                ChessBoardForm.Size = CBSize;

            ChessBoardForm.Show();
        }
    }
}
