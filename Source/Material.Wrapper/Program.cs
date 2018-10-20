using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace Material_Cobalt_Wrapper
{
    internal class Program
    {
        private static void Main(string[] args)
        => new Program().StartWrapper().GetAwaiter().GetResult();

        private string cd = System.IO.Directory.GetCurrentDirectory();

        public async Task StartWrapper()

        {
            try
            {
                Console.WriteLine("Starting the Wrapper...");
                try
                {
                    Process.Start(cd + "\\Common\\Material Design Desktop Concept.exe");
                    Environment.Exit(0);
                }
                catch (Exception err)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nERROR:: " + err);
                    if (!Directory.Exists(cd + "\\Logs"))
                    {
                        Directory.CreateDirectory(cd + "\\Logs");
                    }
                    File.WriteAllText(cd + "\\Logs\\_wrapper_log_" + DateTime.Now.ToString("M_d_yyyy_HH_mm_ss",
                                             CultureInfo.InvariantCulture) + ".log", err.Message + "\r\n" + err.StackTrace);
                    await Task.Delay(-1);
                }
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\nERROR:: " + err);
                if (!Directory.Exists(cd + "\\Logs"))
                {
                    Directory.CreateDirectory(cd + "\\Logs");
                }
                File.WriteAllText(cd + "\\Logs\\_wrapper_log_" + DateTime.Now.ToString("M_d_yyyy_HH_mm_ss",
                                         CultureInfo.InvariantCulture) + ".log", err.Message + "\r\n" + err.StackTrace);
                await Task.Delay(-1);
            }
        }
    }
}