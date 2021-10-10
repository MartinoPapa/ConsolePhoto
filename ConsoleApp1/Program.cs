using System;

namespace ConsolePhotos
{
    class Program
    {
        //mettere dimensione carattere console a 5
        static void Main(string[] args)
        {
            string foto = Console.ReadLine();
            string filePath = System.IO.Directory.GetCurrentDirectory() + @"\"+foto;
            Immagine i = new Immagine(filePath);
            i.ToCharMatrix();
            Console.ReadLine();
        }

    }
}
