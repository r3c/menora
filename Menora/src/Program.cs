using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Mono.Options;

namespace Menora
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var config = "TempConfig.json";
            var help = false;
            var minimize = false;
            var optionSet = new OptionSet();

            optionSet
                .Add("c=|config=", "Change configuration file path", (v) => config = v)
                .Add("m|minimize", "Start minimized", (v) => minimize = true)
                .Add("h|help", "Display help and exit", (v) => help = true)
                .Parse(args);

            if (help)
            {
                using (var writer = new StringWriter())
                {
                    writer.WriteLine(Application.ProductName);
                    writer.WriteLine();

                    optionSet.WriteOptionDescriptions(writer);

                    MessageBox.Show(writer.ToString(), Application.ProductName);
                }

                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(config, minimize));
        }
    }
}
