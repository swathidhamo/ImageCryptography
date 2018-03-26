using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingInit
{
    class Processing
    {
        public Processing()
        {

        }
        public static string ConvertToHex(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
        public static string ConvertToHexInt(int c)
        {
            return "#" + c.ToString("X2");
        }


        public static bool ConvertImageToHex(Bitmap b)
        {
            string str;
            StreamWriter sw = new StreamWriter("names.txt");
            for (int i = 0; i < b.Width; i++)

                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    str = Processing.ConvertToHex(c1);
                    sw.WriteLine(str);
                }
            return true;
        }


        public static bool ConvertToGrayScale(Bitmap b)
        {
            string str;
            StreamWriter sw = new StreamWriter("gray2.txt");
            for (int i = 0; i < b.Width; i++)
            
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = gray;
                    b1 = gray;
                    g1 = gray;
                    
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                    str = Processing.ConvertToHexInt(gray);
                    byte[] bytes = Encoding.ASCII.GetBytes(str);
                    foreach(byte element in bytes)
                    {
                        sw.WriteLine(element);
                    }
                }
       
            return true;
            }

        }
      
    }
