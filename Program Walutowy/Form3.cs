using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Web;

namespace Program_Walutowy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form Parent;

        private void RejestAcc_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                String CONNSTRING = "Server=remotemysql.com; Database=fXFbJYw3Cb; Uid=fXFbJYw3Cb; Password=tjV0Oa4Jhr; port=3306;";
                MySqlConnection mySqlConnection = new MySqlConnection(CONNSTRING);
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand($"insert into uzytkownicy (login,email,haslo,data_rejestracji,data_ostatniego_log)values('{LoginIn.Text}','{EmailIn.Text}','{PasswdIn.Text}',STR_TO_DATE('01-01-2019','%d-%m-%Y'),STR_TO_DATE('01-01-2019','%d-%m-%Y'))", mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            Parent.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }
    }
}
