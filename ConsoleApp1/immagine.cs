using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsolePhotos
{
    class Immagine
    {
        string _percorsoImmagine;
        Bitmap bitImg;
        public int scala=1;
        public double scalaAltezza = 2.6;
        public Immagine(string pecorsoImmagine)
        {
            _percorsoImmagine = pecorsoImmagine;
            bitImg = new Bitmap(pecorsoImmagine);
        }
        public char[][] ToCharMatrix()
        {
            string caratteri = @"$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\|()1{}[]?-_+~<>i!lI;:,\^`. ";
            Color c;
            int grayScale;
            int posCarattere;
            char[][] Matrix = new char[bitImg.Height][];
            for (int i =70; i < bitImg.Height - (int)(scalaAltezza * scala) + 1; i += (int)(scalaAltezza * scala))
            {
                Matrix[i] = new char[bitImg.Width];
                for (int j = 0; j < bitImg.Width-scala+1; j+=scala)
                {
                    c= bitImg.GetPixel(j, i);
                    grayScale =(int)(c.R+c.G+c.B)/3;
                    posCarattere = ((int)(caratteri.Length * grayScale) / 255);
                    if (posCarattere == 0) posCarattere = 1;
                    posCarattere = caratteri.Length - posCarattere;
                    Matrix[i][j] = caratteri[posCarattere];
                    Console.Write(caratteri[posCarattere]);
                }
                Console.Write("\n");
            }
            return Matrix;
        }
    }
}
