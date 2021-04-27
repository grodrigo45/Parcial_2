using System;
using System.Diagnostics;
using System.IO;

namespace Principal.CLS
{
    public class TerminalConnection
    {
        public void ExecuteCommand()
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            Process cmd = new Process();

            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Arguments = @"mysqldump --user=Desarrollo2 --password=admin biblioteca > C:\prueba.sql";
            cmd.StartInfo = ps;
            cmd.Start();
        }
    }
}