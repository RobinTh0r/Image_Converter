using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace Image_Converter
{
    class Image_Converter
    {
        static void Main(string[] args)
        {
            string icon_input_path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\media\", "test.png");
            string icon_output_path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\media\", "test.ico");
            string converter_path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\media\", "convert.exe");
            string arguments = string.Format(@"-define jpeg:size=200x200 " + icon_input_path + " -thumbnail  \"256x256>\" -background transparent -gravity center -extent 256x256 " + icon_output_path);

            var convert = new Process();
            convert.StartInfo.FileName = converter_path;
            convert.StartInfo.Arguments = arguments;
            convert.Start();
        }
    }
}
