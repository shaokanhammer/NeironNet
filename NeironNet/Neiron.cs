using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeironNet
{
    public class Neiron
    {
        public char name;
        public int[,] weight;
        public int[,] input;
        public int sum; 

        public Neiron(char _ch)
        {
            name = _ch;
            weight = new int[30, 30];
            input = new int[30, 30];
            sum = 0;
        }

        public void Init()
        {
            StreamReader ff = new StreamReader(Directory.GetCurrentDirectory() + "/res");
            for (int i = 0; i < 30; i++)
            {
                string[] ss = ff.ReadLine().Split(' ');
                for (int j = 0; j < 30; j++)
                {
                    weight[i, j] = int.Parse(ss[j]);
                }
            }
            ff.Close();
            sum = 0;
        }

        public void Input(Image im) 
        {
            im = Tools.ScaleImage(im, 30, 30);
            Bitmap inp = new Bitmap(im, 30, 30);
            for (byte i = 0; i < 30; i++)
                for (byte j = 0; j < 30; j++)
                {
                    int mx = Math.Max(inp.GetPixel(i,j).B, inp.GetPixel(i,j).R);
                    mx = Math.Max(mx, inp.GetPixel(i,j).G);
                    //mx = Math.Max((int)mx, 0 + inp.GetPixel(i, j).A);
                    if (mx < 190)
                        input[i, j] = 0;
                    else
                        input[i, j] = 1;
                }
        }
    }
}
