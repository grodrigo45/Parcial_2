using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager.CLS;
using MySql.Data.MySqlClient;
using Principal.CLS;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Getter Setter
        public TextBox UserTxt
        {
            get => userTxt;
            set => userTxt = value;
        }

        public TextBox PswTxt
        {
            get => pswTxt;
            set => pswTxt = value;
        }

        public TextBox DbTxt
        {
            get => dbTxt;
            set => dbTxt = value;
        }

        //Metodos
        private void backUpBtn_Click(object sender, EventArgs e)
        {
            // Creamos la conexion a la base de datos
            Conexion dataBase = new Conexion(UserTxt.Text, PswTxt.Text, DbTxt.Text);

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowser.SelectedPath;
                TerminalConnection terminal = new TerminalConnection();
                terminal.ExecuteCommand(UserTxt.Text, PswTxt.Text, DbTxt.Text, path);
                MessageBox.Show(@"La base de datos ha sido respaldada exitosamente");
                //Crear XML cada vez que hagamos un backup
                XmlCrud.CreateXml($"mysqldump -u{UserTxt.Text} -p{PswTxt.Text} {dbTxt.Text}> {path}\\{dbTxt.Text}{DateTime.Now:yyyy-MM-dd_HH-mm}.sql");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Seleccione el respaldo sql | *.sql;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                var restore = new TerminalConnection();
                restore.RestoreDb(UserTxt.Text, PswTxt.Text, DbTxt.Text, path);
                MessageBox.Show(@"La base de datos ha sido restaurada exitosamente");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}