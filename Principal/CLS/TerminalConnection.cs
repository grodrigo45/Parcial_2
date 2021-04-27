using System;
using System.Diagnostics;
using System.IO;

namespace Principal.CLS
{
    public class TerminalConnection
    {
        public void ExecuteCommand(string username, string pass, string db)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            Process cmd = new Process();

            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Arguments = $"/c mysqldump -u{username} -p{pass} {db} > c:\\backup.sql";
            ps.Verb = "runas";
            cmd.StartInfo = ps;
            cmd.Start();
        }

        public void RestoreBD(string username, string pass, string db)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            Process cmd = new Process();

            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Arguments = $"/c mysqldump -u{username} -p{pass} {db} < c:\\backup.sql";
            ps.Verb = "runas";
            cmd.StartInfo = ps;
            cmd.Start();
        }
    }
}