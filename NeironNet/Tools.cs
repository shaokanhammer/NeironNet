using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace NeironNet
{
    public class Tools
    {
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            try
            {
                var ratioX = (double)maxWidth / image.Width;
                var ratioY = (double)maxHeight / image.Height;
                var ratio = Math.Min(ratioX, ratioY);

                var newWidth = (int)(image.Width * ratio);
                var newHeight = (int)(image.Height * ratio);

                var newImage = new Bitmap(newWidth, newHeight);
                Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
                return newImage;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Картинка для распознания не определена", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
        }

        public static void RefreshMemory(Neiron n)
        {
            int[,] mm = n.input;
            for (int i = 0; i < 30; i++)
                for (int j = 0; j < 30; j++)
                    if (n.weight[i, j] < 50 && n.weight[i, j] > -50)
                        if (n.input[i, j] == 0)
                            n.weight[i, j] -= 1;
                        else
                            n.weight[i, j] += 1;
        }

        public static Image RefreshImage(int[,] inp)
        {
            Bitmap m = new Bitmap(30, 30);
            for (int i = 0; i < 30; i++)
                for (int j = 0; j < 30; j++)
                    if (inp[i, j] >= 0)
                        m.SetPixel(i, j, Color.FromArgb(255, 0, inp[i, j], 0));
                    else
                        m.SetPixel(i, j, Color.FromArgb(255, inp[i, j] * (-1), 0, 0));
            return (Image)m;
        }

    }
}
