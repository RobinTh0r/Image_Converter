using System;
using System.Drawing;
using System.IO;

namespace Image_Converter
{
    class Image_Converter
    {
        static void Main(string[] args)
        {


            string Icon_Input = Path.Combine(Environment.CurrentDirectory, @"media\", "test.png");
            string Icon_Output = Path.Combine(Environment.CurrentDirectory, @"media\", "test.ico");
            using (FileStream stream = System.IO.File.OpenWrite(Icon_Output))
            {
                Bitmap bitmap = (Bitmap)Image.FromFile(Icon_Input);
                Icon.FromHandle(bitmap.GetHicon()).Save(stream);
            }


        }
    }
}
