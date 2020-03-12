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
            string icon_input_path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\media\", "smm.jpg");
            string icon_output_path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\media\", "test.ico");
            string converter_path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\media\", "convert.exe");
           // string arguments = string.Format(@"-define jpeg:size=200x200 " + icon_input + " -thumbnail  \"256x256>\" -debug \"All\" -background transparent -gravity center -extent 256x256 " + icon_output);
            string arguments = string.Format(@"-define jpeg:size=200x200 " + icon_input_path + " -thumbnail  \"256x256>\" -background transparent -gravity center -extent 256x256 " + icon_output_path);


            var myProcess = new Process();
            myProcess.StartInfo.FileName = converter_path;
            myProcess.StartInfo.Arguments = arguments;
         // myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
         // myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();
         // myProcess.WaitForExit();
         // Console.Read();

            // old method
            // Process.Start(convert, "-define jpeg:size=200x200 " + icon_input + " -thumbnail  \"256x256>\" -debug \"All\" -background transparent -gravity center -extent 256x256 " + icon_output);


        }
    }
}
