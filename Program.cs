using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekti3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formSliderRGB());
        }

      //  static void Main(string[] args)
      //  {
        //    string filePath = @"C:\Käyttäjät\s3koan04\source\repos\ColorPaletteTool\UserData.txt";

            //List<string> lines = File.ReadAllLines(filePath).ToList();
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //lines.Add("Sue,Storm,www.stormy.com");
            //File.WriteAllLines(filePath, lines);

           // List<Person> people = new List<Person>();
            //List<string> lines = File.ReadLines(filePath);
           // Console.ReadLine();
       // }
    }
}
