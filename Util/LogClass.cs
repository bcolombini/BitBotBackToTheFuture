using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBotBackToTheFuture
{
    class LogClass
    {
        internal static void log(string value, ConsoleColor color = ConsoleColor.White)
        {
            try
            {

                value = "[" + DateTime.Now.ToString() + "] - " + value;
                Console.ForegroundColor = color;
                Console.WriteLine(value);
                Console.ForegroundColor = ConsoleColor.White;

                System.IO.StreamWriter w = new StreamWriter(MainClass.location + DateTime.Now.ToString("yyyyMMdd") + "_log.txt", true);
                w.WriteLine(value);
                w.Close();
                w.Dispose();

            }
            catch { }
        }
    }
}
