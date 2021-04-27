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
            // DateTime dateTime = DateTime.Now.Date;
            // string dateTxt = dateTime.ToString("MM/dd/yyyy HH:mm:ss");
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Arguments = $"/c mysqldump -u{username} -p{pass} {db}> c:\\{db}{DateTime.Now:yyyy-MM-dd_HH-mm}.sql";
            ps.Verb = "runas";
            cmd.StartInfo = ps;
            cmd.Start();
        }

        public void RestoreDb(string username, string pass, string db, string path)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            Process cmd = new Process();

            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Arguments = $"/c mysql -u {username} -p{pass} {db} < {path}";
            ps.Verb = "runas";
            cmd.StartInfo = ps;
            cmd.Start();
        }
    }
}