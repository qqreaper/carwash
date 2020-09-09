using System;
using System.Collections.Generic;
using System.Windows;
using System.Text;
using System.Threading.Tasks;

namespace CarWash_Application.model
{
    class Debug
    {
        private static List<string> logs = new List<string>();

        public static string GetAllLogs()
        {
            string temp = null;
            foreach (var log in logs)
            {
                temp += log + Environment.NewLine;
            }

            return temp;
        }

        public static string Log(string log)
        {
            logs.Add(log);
            MessageBox.Show(log);
            return log;
        }
    }
}
