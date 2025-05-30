using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MDI
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        public Bitmap bitCom;
        public string fileName;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form1 childForm = new Form1();
            childForm.MdiParent = this;
            childForm.Text = "Окно " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e) // Открыть
        {
            Form1 curForm = (Form1)this.ActiveMdiChild;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.jpg)|*.jpg|Файлы изображений (*.jpeg)|*.jpeg|Файлы изображений (*.bmp)|*.bmp|Файлы изображений (*.gif)|*.gif|Файлы изображений (*.png)|*.png|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                if (this.ActiveMdiChild == null)
                {
                    fileName = openFileDialog.FileName;
                    Form1 childForm = new Form1();
                    childForm.MdiParent = this;
                    childForm.pictureBox1.Image = Image.FromFile(fileName);
                    childForm.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    childForm.bitmap = new Bitmap(childForm.pictureBox1.Image);
                    childForm.pictureBox1.Image = (Image)childForm.bitmap;
                    childForm.graphics1 = childForm.pictureBox1.CreateGraphics();
                    childForm.graphics2 = Graphics.FromImage(childForm.pictureBox1.Image);
                    childForm.Text = openFileDialog.FileName;
                    childForm.Show();
                    childForm.checkBox2.CheckState = CheckState.Unchecked;
                }
                else
                {
                    fileName = openFileDialog.FileName;
                    curForm.pictureBox1.Image = Image.FromFile(fileName);
                    curForm.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    curForm.bitmap = new Bitmap(curForm.pictureBox1.Image);
                    curForm.pictureBox1.Image = (Image)curForm.bitmap;
                    curForm.graphics1 = curForm.pictureBox1.CreateGraphics();
                    curForm.graphics2 = Graphics.FromImage(curForm.pictureBox1.Image);
                    curForm.Text = fileName;
                    curForm.checkBox2.CheckState = CheckState.Unchecked;
                }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) // Сохранить Как
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы изображений (*.jpg)|*.jpg|Файлы изображений (*.jpeg)|*.jpeg|Файлы изображений (*.bmp)|*.bmp|Файлы изображений (*.gif)|*.gif|Файлы изображений (*.png)|*.png|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                Form1 curForm = (Form1)this.ActiveMdiChild;
                curForm.bitmap = new Bitmap(curForm.pictureBox1.Image);
                curForm.bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                curForm.Text = fileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) // Сохранить
        {
            try
            {
                Form1 curForm = (Form1)this.ActiveMdiChild;
                fileName = curForm.Text;
                if (fileName.Contains("Окно"))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Файлы изображений (*.jpg)|*.jpg|Файлы изображений (*.jpeg)|*.jpeg|Файлы изображений (*.bmp)|*.bmp|Файлы изображений (*.gif)|*.gif|Файлы изображений (*.png)|*.png|Все файлы (*.*)|*.*";
                    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;
                        curForm.bitmap = new Bitmap(curForm.pictureBox1.Image);
                        curForm.bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        curForm.Text = fileName;
                    }
                }
                curForm.bitmap = new Bitmap(curForm.pictureBox1.Image);
                curForm.bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
            catch
            {
                MessageBox.Show("Внесите изменения.");
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e) // Сохранить
        {
            try
            {
                Form1 curForm = (Form1)this.ActiveMdiChild;
                fileName = curForm.Text;
                if(fileName.Contains("Окно"))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Файлы изображений (*.jpg)|*.jpg|Файлы изображений (*.jpeg)|*.jpeg|Файлы изображений (*.bmp)|*.bmp|Файлы изображений (*.gif)|*.gif|Файлы изображений (*.png)|*.png|Все файлы (*.*)|*.*";
                    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;
                        curForm.bitmap = new Bitmap(curForm.pictureBox1.Image);
                        curForm.bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        curForm.Text = fileName;
                    }
                }
                curForm.textBox1.Text = fileName;
                curForm.bitmap = new Bitmap(curForm.pictureBox1.Image);
                curForm.bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
            catch
            {
                MessageBox.Show("Внесите изменения.");
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выделитьToolStripMenuItem_Click(object sender, EventArgs e) // Выделить
        {
            Form1 curForm = (Form1)this.ActiveMdiChild;
            curForm.tl = 2;
            curForm.pen.Width = 1;
            curForm.penCut = true;
        }
        
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) // Выделить Все
        {
            Form1 curForm = (Form1)this.ActiveMdiChild;
            curForm.x = 1;
            curForm.y = 1;
            curForm.a = curForm.pictureBox1.Width - 2;
            curForm.b = curForm.pictureBox1.Height - 2;
            curForm.penCut = true;
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) //Вырезать
        {
            Form1 curForm = (Form1)this.ActiveMdiChild;
            try
            {
                if ((curForm.a != 0) | (curForm.b != 0) | (curForm.x != 0) | (curForm.y != 0))
                {
                    int i, j;
                    bitCom = new Bitmap(curForm.a, curForm.b);
                    for (i = curForm.x + 1; i < curForm.x + curForm.a - 1; i++)
                    {
                        for (j = curForm.y + 1; j < curForm.y + curForm.b - 1; j++)
                        {
                            Color color1 = curForm.bitmap.GetPixel(i, j);
                            bitCom.SetPixel(i - curForm.x, j - curForm.y, color1);
                        }
                    }

                    int k, l;
                    for (k = curForm.x - 1; k < curForm.x + curForm.a + 1; k++)
                        for (l = curForm.y - 1; l < curForm.y + curForm.b + 1; l++)
                        {
                            curForm.bitmap.SetPixel(k, l, Color.FromArgb(255, 255, 255, 255));
                        }
                }
            }
            catch
            {
                MessageBox.Show("Выделите область.");
            }
            Refresh();
            curForm.penCut = false;
            curForm.a = 0; curForm.b = 0; curForm.x = 0; curForm.y = 0;
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) //Копировать
        {
            Form1 curForm = (Form1)this.ActiveMdiChild;
            try
            {
                if ((curForm.a != 0) | (curForm.b != 0) | (curForm.x != 0) | (curForm.y != 0))
                {
                    int i, j;
                    bitCom = new Bitmap(curForm.a, curForm.b);
                    for (i = curForm.x + 1; i < curForm.x + curForm.a - 1; i++)
                    {
                        for (j = curForm.y + 1; j < curForm.y + curForm.b - 1; j++)
                        {
                            Color color1 = curForm.bitmap.GetPixel(i, j);
                            bitCom.SetPixel(i - curForm.x, j - curForm.y, color1);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Выделите область.");
            }
            curForm.penCut = false;
            curForm.a = 0; curForm.b = 0; curForm.x = 0; curForm.y = 0;
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) // Вставить
        {
            Form1 curForm = (Form1)this.ActiveMdiChild;
            if ((bitCom != null) && curForm.checkBox2.Checked)
                curForm.graphics2.DrawImage(bitCom, curForm.x, curForm.y);
            curForm.pictureBox1.Refresh();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) // О программе
        {
            MessageBox.Show("Технологии программирования\nКурсовая работа\nВыполнил студент группы ДЦИС-27\nКонторин П.Л.");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) // Очистить
        {
            Form1 curForm = (Form1)this.ActiveMdiChild;
            curForm.Polotno();
            curForm.checkBox2.CheckState = CheckState.Unchecked;
        }

    }
}
