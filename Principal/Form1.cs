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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void backUpBtn_Click(object sender, EventArgs e)
        {
            // Obtenemos los datos de los input
            // var userName = userTxt.Text;
            // var psw = pswTxt.Text;
            // var db = dbTxt.Text;
            //
            // // Este es el string en donde se guarda el backUp
            // string file = @"c:\backUp.sql";
            //
            // // Creamos la conexion a la base de datos
            // DataManager.CLS.Conexion dataBase = new Conexion(userName, psw, db);

            TerminalConnection terminal = new TerminalConnection();
            terminal.ExecuteCommand();
        }
    }
}