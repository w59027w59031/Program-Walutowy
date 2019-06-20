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
                bool jestJuz = false;
                string userId = "";
                String CONNSTRING = "Server=remotemysql.com; Database=fXFbJYw3Cb; Uid=fXFbJYw3Cb; Password=tjV0Oa4Jhr; port=3306;";
                MySqlConnection mySqlConnection = new MySqlConnection(CONNSTRING);
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("select 1 from uzytkownicy where login='" + LoginIn.Text + "' or email='" + EmailIn.Text + "'", mySqlConnection);
                MySqlDataReader mySqlDataReader;
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    if (!mySqlDataReader.IsDBNull(0))
                    {
                        jestJuz = true;
                    }
                }
                mySqlConnection.Close();
                if (!jestJuz)
                {
                    if (PasswdIn.Text == PasswdagIn.Text)
                    {
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand($"insert into uzytkownicy (login,email,haslo,data_rejestracji,data_ostatniego_log)values('{LoginIn.Text}','{EmailIn.Text}','{PasswdIn.Text}',STR_TO_DATE('01-01-2019','%d-%m-%Y'),STR_TO_DATE('01-01-2019','%d-%m-%Y'))", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlCommand = new MySqlCommand("select id from uzytkownicy where login='" + LoginIn.Text + "' and haslo='" + PasswdIn.Text + "'and email='" + EmailIn.Text + "'", mySqlConnection);
                        mySqlDataReader = mySqlCommand.ExecuteReader();
                        while (mySqlDataReader.Read())
                        {
                            if (!mySqlDataReader.IsDBNull(0))
                            {
                                userId = mySqlDataReader.GetString(0);
                            }
                        }
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','USD','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','AUD','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','CAD','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','EUR','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','HUF','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','CHF','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','GBP','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','JPY','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','CZK','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','DKK','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','NOK','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','SEK','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        mySqlConnection.Open();
                        mySqlCommand = new MySqlCommand(@"insert into pieniadze (id, waluta, ilosc)values('" + userId + "','XDR','100')", mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                    }else
                    {
                        MessageBox.Show("Hasła się nie zgadzają!");
                    }    
                    }
                else
                {
                    MessageBox.Show("Użytkownik już istnieje!");
                }
                
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
