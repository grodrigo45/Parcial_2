using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Principal.CLS
{
    public class TerminalConnection
    {
        public void ExecuteCommand(string username, string pass, string db, string path)
        {
            try
            {
                ProcessStartInfo ps = new ProcessStartInfo();
                Process cmd = new Process();
                ps.FileName = "cmd.exe";
                ps.WindowStyle = ProcessWindowStyle.Hidden;
                ps.Arguments = $"/c mysqldump -u{username} -p{pass} {db}> {path}\\{db}{DateTime.Now:yyyy-MM-dd_HH-mm}.sql";
                ps.Verb = "runas";
                cmd.StartInfo = ps;
                cmd.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(@"Error al ejecutar el comando", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                throw;
            }
        }

        public void RestoreDb(string username, string pass, string db, string path)
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(@"Error al ejecutar el comando", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                throw;
            }
        }
    }
}