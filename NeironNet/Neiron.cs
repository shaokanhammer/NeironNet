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
            this.Init();
        }

        public void Init()
        {
            StreamReader memoryFile;
            try
            {
                memoryFile = new StreamReader(Directory.GetCurrentDirectory() + "/res/" + this.name + ".txt");
            }
            catch (FileNotFoundException)
            {
                
                #region Create new memory file
                File.Create(Directory.GetCurrentDirectory() + "/res/" + this.name + ".txt");
                StreamWriter ww = new StreamWriter(Directory.GetCurrentDirectory() + "/res/" + this.name + ".txt");                          
                for (int i = 0; i < 30; i++)
                {
                    ww.WriteLine("0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0");
                }
                ww.Close();
                #endregion
                memoryFile = new StreamReader(Directory.GetCurrentDirectory() + "/res/" + this.name + ".txt"); // REinit
            }

            for (int i = 0; i < 30; i++)
            {
                string[] ss = memoryFile.ReadLine().Split(' ');
                for (int j = 0; j < 30; j++)
                {
                    weight[i, j] = int.Parse(ss[j]);
                }
            }
            memoryFile.Close();
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
                    if (mx < 190)
                        input[i, j] = 0;
                    else
                        input[i, j] = 1;
                }
        }
    }
}
