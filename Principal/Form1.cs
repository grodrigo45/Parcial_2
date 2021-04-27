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

        private void backUpBtn_Click(object sender, EventArgs e)
        {
            // Obtenemos los datos de los input
            string userName = userTxt.Text;
            string psw = pswTxt.Text;
            string db = dbTxt.Text;

            // Creamos la conexion a la base de datos
            DataManager.CLS.Conexion dataBase = new Conexion(userName, psw, db);

            TerminalConnection terminal = new TerminalConnection();
            terminal.ExecuteCommand(userName, psw, db);
            MessageBox.Show("Respaldo Completado con exito", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = userTxt.Text;
            string psw = pswTxt.Text;
            string db = dbTxt.Text;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Seleccione el respaldo sql | *.sql;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                var restore = new TerminalConnection();
                restore.RestoreDb(userName, psw, db, path);
            }
        }
    }
}