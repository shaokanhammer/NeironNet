using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeironNet
{
    public partial class Form1 : Form
    {
        Bitmap input = new Bitmap(Image.FromFile("res/white.bmp"));
        List<Neiron> leterWeb = new List<Neiron>();
        Neiron currentNeiron;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Chars = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            foreach (Char ch in Chars) 
            {
                NeironSelector.Items.Add(ch);
                leterWeb.Add(new Neiron(ch));
                leterWeb[leterWeb.Count - 1].Init();
            }
        }

        private void NeironSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Neiron n in leterWeb)
            {
                char temp = NeironSelector.GetItemText(NeironSelector.SelectedItem)[0];
                if (temp == n.name)
                {
                    currentNeiron = n;
                    MemoryDisplay.Image = Tools.ScaleImage(Tools.RefreshImage(n.weight), 180, 180);
                }
            }
        }

        private void TeachNewImage_Click(object sender, EventArgs e)
        {
            TeachImageSelect.ShowDialog();
            TeacherDisplay.Image = Tools.ScaleImage(Image.FromFile(TeachImageSelect.FileName), 180, 180);
        }

        private void GetResult_Click(object sender, EventArgs e)
        {
            currentNeiron.Input(Image.FromFile(TeachImageSelect.FileName));
            currentNeiron.sum = 0;
            for (int i = 0; i < 30; i++)
                for (int j = 0; j < 30; j++)
                    currentNeiron.sum += currentNeiron.weight[i, j] * currentNeiron.input[i, j];
            LabelResult.Text = "Result: match=MM% recocnized=RES".Replace("MM", currentNeiron.sum + "");
        }

        private void ButtonTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                currentNeiron.Input(Image.FromFile(TeachImageSelect.FileName));
                Image im = Image.FromFile(TeachImageSelect.FileName);
                im = Tools.ScaleImage(im, 30, 30);
                if (im == null)
                    return;
                Bitmap inp = new Bitmap(im);
                for (int i = 0; i < 30; i++)
                    for (int j = 0; j < 30; j++)
                    {
                        if (currentNeiron.input[i, j] == 1 && currentNeiron.weight[i, j] < 250)
                            currentNeiron.weight[i, j] += 1;
                        if (currentNeiron.input[i, j] == 0 && currentNeiron.weight[i, j] > -250)
                            currentNeiron.weight[i, j] -= 1;
                    }
                MemoryDisplay.Image = Tools.ScaleImage(Tools.RefreshImage(currentNeiron.weight), 180, 180);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Картинка для распознания не определена", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);               
            }
        }
    }
}
