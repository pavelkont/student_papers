using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MDI
{
    public partial class Form1 : Form
    {
        public Pen pen;
        public Bitmap bitmap, bitmap1;
        public Font textFont;
        public int tl = 0;
        public int x, y;
        public int a, b;
        public bool penCut = false;
        double k, l;
        public Graphics graphics1, graphics2;
        SolidBrush brush, brushtext, brushcur, brrez;
        public Form1()
        {
            InitializeComponent();
            Polotno();
        }

        public void Polotno() // Полотно
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int i, j;
            for (i = 0; i < pictureBox1.Width; i++)
                for (j = 0; j < pictureBox1.Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
                }
            pictureBox1.Image = (Image)bitmap;
            graphics1 = pictureBox1.CreateGraphics();
            graphics2 = Graphics.FromImage(pictureBox1.Image);
            pen = new Pen(Color.Black);
            pen.Width = Convert.ToInt16(numericUpDown1.Text);
            brush = new SolidBrush(Color.Black);
            brushtext = new SolidBrush(Color.Black);
            brushcur = new SolidBrush(Color.Black);
            brrez = new SolidBrush(Color.White);
            textFont = new Font("Segoe UI", 9);
            tl = 0;
            x = 0;
            y = 0;
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            textBox1.Text = "Введите текст";
            textBox1.ForeColor = Color.Black;
            textBox1.Font = new Font("Segoe UI", 9);
            цветЛинииToolStripMenuItem.BackColor = Color.White;
            цветЗаливкиToolStripMenuItem.BackColor = Color.White;
            цветТекстаToolStripMenuItem.BackColor = Color.White;
        }

        
        private void checkBox2_Click(object sender, EventArgs e) // Редактировать
        {
            if (checkBox2.Checked)
            {
                k = Convert.ToDouble(bitmap.Width) / Convert.ToDouble(pictureBox1.Width);
                l = Convert.ToDouble(bitmap.Height) / Convert.ToDouble(pictureBox1.Height);
                Size size = new Size();
                if (k > l)
                {
                    size.Width = Convert.ToInt16(bitmap.Width / k);
                    size.Height = Convert.ToInt16(bitmap.Height / k);
                }
                else
                {
                    size.Width = Convert.ToInt16(bitmap.Width / l);
                    size.Height = Convert.ToInt16(bitmap.Height / l);
                }
                bitmap = new Bitmap((Image)bitmap, size);
                pictureBox1.Dock = DockStyle.None;
                pictureBox1.Size = size;
                pictureBox1.Image = (Image)bitmap;
                graphics1 = pictureBox1.CreateGraphics();
                graphics2 = Graphics.FromImage(pictureBox1.Image);
            }
            else
            {
                pictureBox1.Dock = DockStyle.Fill;
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e) // Вырезать
        {
            MDIParent1 parForm = (MDIParent1)this.MdiParent;
            try
            {
                if ((a != 0) | (b != 0) | (x != 0) | (y != 0))
                {
                    int i, j;
                    parForm.bitCom = new Bitmap(a, b);
                    for (i = x + 1; i < x + a - 1; i++)
                    {
                        for (j = y + 1; j < y + b - 1; j++)
                        {
                            Color color1 = bitmap.GetPixel(i, j);
                            parForm.bitCom.SetPixel(i - x, j - y, color1);
                        }
                    }
                }
                int k, l;
                for (k = x - 1; k < x + a + 1; k++)
                    for (l = y - 1; l < y + b + 1; l++)
                    {
                        bitmap.SetPixel(k, l, Color.FromArgb(255, 255, 255, 255));
                    }
            }
            catch
            {
                MessageBox.Show("Выделите область.");
            }
            Refresh();
            penCut = false;
            a = 0; b = 0; x = 0; y = 0;
        }

        private void корироватьToolStripMenuItem_Click(object sender, EventArgs e) // Копировать
        {
            MDIParent1 parForm = (MDIParent1)this.MdiParent;
            try
            {
                if ((a != 0) | (b != 0) | (x != 0) | (y != 0))
                {
                    int i, j;
                    parForm.bitCom = new Bitmap(a, b);
                    for (i = x + 1; i < x + a - 1; i++)
                    {
                        for (j = y + 1; j < y + b - 1; j++)
                        {
                            Color color1 = bitmap.GetPixel(i, j);
                            parForm.bitCom.SetPixel(i - x, j - y, color1);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Выделите область.");
            }
            penCut = false;
            a = 0; b = 0; x = 0; y = 0;
        }

        private void вставитьToolStripMenuItem_Click_1(object sender, EventArgs e) // Вставить
        {
            MDIParent1 parForm = (MDIParent1)this.MdiParent;
            if ((parForm.bitCom != null) && checkBox2.Checked)
                graphics2.DrawImage(parForm.bitCom, x, y);
            pictureBox1.Refresh();
        }


        private void цветЛинииToolStripMenuItem_Click(object sender, EventArgs e) // Цвет Линии
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                brushcur.Color = colorDialog1.Color;
                цветЛинииToolStripMenuItem.BackColor = colorDialog1.Color;
            }
        }

        private void цветЗаливкиToolStripMenuItem_Click(object sender, EventArgs e) //Цвет заливки
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                brush.Color = colorDialog1.Color;
                this.цветЗаливкиToolStripMenuItem.BackColor = colorDialog1.Color;
            }
        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e) // Цвет Текста
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                brushtext.Color = colorDialog1.Color;
                this.цветТекстаToolStripMenuItem.BackColor = colorDialog1.Color;
            }
        }

        private void форматТекстаToolStripMenuItem_Click(object sender, EventArgs e) // Формат Текста
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textFont = fontDialog1.Font;
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
        }

        private void линияToolStripMenuItem_Click(object sender, EventArgs e) // Линия
        {
            tl = 0;
        }

        private void криваяToolStripMenuItem_Click(object sender, EventArgs e) // Кривая
        {
            tl = 1;
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e) // Прямоугольник
        {
            tl = 2;
        }

        private void элипсToolStripMenuItem_Click(object sender, EventArgs e) // Эллипс
        {
            tl = 3;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ластикToolStripMenuItem_Click(object sender, EventArgs e) // Ластик
        {
            tl = 4;
        }

        private void текстToolStripMenuItem_Click(object sender, EventArgs e) // Текст
        {
            tl = 5;
        }

        private void треугольникToolStripMenuItem_Click(object sender, EventArgs e) // Треугольник
        {
            tl = 6;
        }

        private void изображениеToolStripMenuItem_Click(object sender, EventArgs e) // Изображение
        {
            tl = 7;
        }

        private void шестиугольникToolStripMenuItem_Click(object sender, EventArgs e) // Шестиугольник
        {
            tl = 8;
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e) // Мышь Вниз
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            if ((e.Button == MouseButtons.Right) && (penCut == false))
            {
                x = e.X;
                y = e.Y;
            }
            if (penCut == true) pen.Width = 1;
            else pen.Width = Convert.ToInt16(numericUpDown1.Text);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) // Мышь Двигать
        {
            if ((e.Button == MouseButtons.Left) && checkBox2.Checked)
                if (e.Button == MouseButtons.Left)

                {
                int x1 = e.X, y1 = e.Y; switch (tl)
                {
                    case 0: graphics1.DrawLine(pen, x, y, x1, y1); break;
                    case 1: graphics2.FillRectangle(brushcur, x1, y1, Convert.ToInt16(numericUpDown1.Text), Convert.ToInt16(numericUpDown1.Text)); break;
                    case 2: graphics1.DrawRectangle(pen, x, y, x1 - x, y1 - y); break;
                    case 3: graphics1.DrawEllipse(pen, x, y, x1 - x, y1 - y); break;
                    case 4: graphics2.FillEllipse(brrez, x1, y1, 30, 30); break;
                    case 5: break;
                    case 6:
                        {
                            PointF point1 = new PointF(x, y1);
                            PointF point2 = new PointF((x + x1) / 2, y);
                            PointF point3 = new PointF(x1, y1);
                            PointF[] curvePoints = { point1, point2, point3 };
                            graphics1.DrawPolygon(pen, curvePoints);
                        }
                        break;
                    case 7: break;
                    case 8:
                        {
                                try
                                {
                                    int a = Convert.ToUInt16((x1 - x) * 0.9375);
                                    int a1 = Convert.ToUInt16((x1 - x) * 0.0625);
                                    int b = Convert.ToUInt16((y1 - y) * 0.25);
                                    int b1 = Convert.ToUInt16((y1 - y) * 0.75);
                                    PointF point1 = new Point((x + x1) / 2, y);
                                    PointF point2 = new Point((x + a), (y + b));
                                    PointF point3 = new Point((x + a), (y + b1));
                                    PointF point4 = new Point((x + x1) / 2, y1);
                                    PointF point5 = new Point((x + a1), (y + b1));
                                    PointF point6 = new Point((x + a1), (y + b));
                                    PointF[] curvePoints = { point1, point2, point3, point4, point5, point6 };
                                    graphics1.DrawPolygon(pen, curvePoints);
                                }
                                catch
                                {
                                    MessageBox.Show("Измените значение.");
                                }
                        }
                        break;
                    default: graphics1.DrawLine(pen, x, y, x1, y1); break;
                }
            }
            pictureBox1.Refresh();
        }

           private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e) // Мышь вверх
        {
            if ((e.Button == MouseButtons.Left)&&(checkBox2.Checked))
            {
                int x1 = e.X, y1 = e.Y;
                switch (tl)
                {
                    case 0: graphics2.DrawLine(pen, x, y, x1, y1); break;
                    case 1: break;
                    case 2:
                        {
                            if (checkBox1.Checked)
                            {
                                graphics2.DrawRectangle(pen, x, y, x1 - x, y1 - y);
                                graphics2.FillRectangle(brush, x, y, x1 - x, y1 - y);
                            }
                            else
                            {
                                graphics2.DrawRectangle(pen, x, y, x1 - x, y1 - y);
                                a = x1 - x;
                                b = y1 - y;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (checkBox1.Checked)
                            {
                                graphics2.DrawEllipse(pen, x, y, x1 - x, y1 - y);
                                graphics2.FillEllipse(brush, x, y, x1 - x, y1 - y);
                            }
                            else
                                graphics2.DrawEllipse(pen, x, y, x1 - x, y1 - y);
                        }
                        break;

                    case 4: break;
                    case 5: graphics2.DrawString(textBox1.Text, textFont, brushtext, x, y); break;
                    case 6:
                        {
                            if (checkBox1.Checked)
                            {
                                PointF point1 = new PointF(x, y1);
                                PointF point2 = new PointF((x + x1) / 2, y);
                                PointF point3 = new PointF(x1, y1);
                                PointF[] curvePoints = { point1, point2, point3 };
                                graphics2.DrawPolygon(pen, curvePoints);
                                graphics2.FillPolygon(brush, curvePoints);
                            }
                            else
                            {
                                PointF point1 = new PointF(x, y1);
                                PointF point2 = new PointF((x + x1) / 2, y);
                                PointF point3 = new PointF(x1, y1);
                                PointF[] curvePoints = { point1, point2, point3 };
                                graphics2.DrawPolygon(pen, curvePoints);
                            }
                        }
                        break;
                    case 7:
                        {
                            Image image = Image.FromFile(Directory.GetCurrentDirectory() + "/images/image.jpg");
                            graphics2.DrawImage(image, x, y);
                        }
                        break;
                    case 8:
                        {
                            if (checkBox1.Checked)
                            {
                                int a = Convert.ToUInt16((x1 - x) * 0.9375);
                                int a1 = Convert.ToUInt16((x1 - x) * 0.0625);
                                int b = Convert.ToUInt16((y1 - y) * 0.25);
                                int b1 = Convert.ToUInt16((y1 - y) * 0.75);
                                PointF point1 = new Point((x + x1) / 2, y);
                                PointF point2 = new Point((x + a), (y + b));
                                PointF point3 = new Point((x + a), (y + b1));
                                PointF point4 = new Point((x + x1) / 2, y1);
                                PointF point5 = new Point((x + a1), (y + b1));
                                PointF point6 = new Point((x + a1), (y + b));
                                PointF[] curvePoints = { point1, point2, point3, point4, point5, point6 };
                                graphics2.DrawPolygon(pen, curvePoints);
                                graphics2.FillPolygon(brush, curvePoints);
                            }
                            else
                            {
                                int a = Convert.ToUInt16((x1 - x) * 0.9375);
                                int a1 = Convert.ToUInt16((x1 - x) * 0.0625);
                                int b = Convert.ToUInt16((y1 - y) * 0.25);
                                int b1 = Convert.ToUInt16((y1 - y) * 0.75);
                                PointF point1 = new Point((x + x1) / 2, y);
                                PointF point2 = new Point((x + a), (y + b));
                                PointF point3 = new Point((x + a), (y + b1));
                                PointF point4 = new Point((x + x1) / 2, y1);
                                PointF point5 = new Point((x + a1), (y + b1));
                                PointF point6 = new Point((x + a1), (y + b));
                                PointF[] curvePoints = { point1, point2, point3, point4, point5, point6 };
                                graphics2.DrawPolygon(pen, curvePoints);
                            }
                        }
                        break;
                    default: graphics2.DrawLine(pen, x, y, x1, y1); break;
                }
                if (penCut == true) tl = 0;
                pictureBox1.Refresh();
            }
        }
    }
}
