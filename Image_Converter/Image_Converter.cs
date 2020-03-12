using System;
using System.Drawing;
using System.IO;

namespace Image_Converter
{
    class Image_Converter
    {
        static void Main(string[] args)
        {



            string icon_input = Path.Combine(Environment.CurrentDirectory, @"..\..\..\media\", "test.png");
            string icon_output = Path.Combine(Environment.CurrentDirectory, @"..\..\..\media\", "test.ico");



            using (FileStream stream = System.IO.File.OpenWrite(icon_output))
            {
                Bitmap bitmap = (Bitmap)Image.FromFile(icon_input);
                Icon.FromHandle(bitmap.GetHicon()).Save(stream);
                Console.WriteLine("Erfolg!");
            }

            // Built-In Bitmap Converter --- Low Quality!

            //Bitmap Cbitmap = null;
            //{
            //    Cbitmap = new Bitmap(icon_input); //(32, 32, PixelFormat.Format64bppPArgb);

            //    Cbitmap.MakeTransparent(Color.White);
            //    System.IntPtr icH = Cbitmap.GetHicon();
            //    Icon ico = Icon.FromHandle(icH);
            //    Cbitmap.Dispose();
            //    FileStream f = new FileStream(icon_output, System.IO.FileMode.OpenOrCreate);
            //    ico.Save(f);


            //}
        }
    }
}
