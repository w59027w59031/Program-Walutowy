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
    public partial class MenuLogRej : Form
    {
        public MenuLogRej()
        {
            InitializeComponent();
        }

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Funkcja ukrywa aktualny formularz i uruchamia Form3
            /// </summary>
            this.Hide();
            Form3 form3 = new Form3();
            form3.Parent = this;
            form3.ShowDialog();
        }

        private string _LooserId;
        public string LooserId
        {
            get { return _LooserId; }
        }

        private void Zaloguj_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Funkcja pobiera dane użytkownika na podstawie wprowadzonego loginu i hasła
            /// </summary>
            try
            {
                bool bylo = false;
                string login = LoginInput.Text;
                string haslo = HasloInput.Text;
                String CONNSTRING = "Server=remotemysql.com; Database=fXFbJYw3Cb; Uid=fXFbJYw3Cb; Password=tjV0Oa4Jhr; port=3306;";
                MySqlConnection mySqlConnection = new MySqlConnection(CONNSTRING);
                MySqlCommand mySqlCommand = new MySqlCommand("select id,email,login,haslo,data_rejestracji,data_ostatniego_log from uzytkownicy where login='" + login + "' and haslo='" + haslo + "'", mySqlConnection);
                MySqlDataReader mySqlDataReader;
                mySqlConnection.Open();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    if (!mySqlDataReader.IsDBNull(0))
                    {
                        bylo = true;
                        _LooserId = mySqlDataReader.GetString(0);
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.JA.id = mySqlDataReader.GetString(0);
                        form2.JA.email = mySqlDataReader.GetString(1);
                        form2.JA.login = mySqlDataReader.GetString(2);
                        form2.JA.haslo = mySqlDataReader.GetString(3);
                        form2.JA.data_rejestracji = mySqlDataReader.GetDateTime(4);
                        form2.JA.data_ostatniego_log = mySqlDataReader.GetDateTime(5);
                        form2.Parent = this;

                        form2.wyswietl();
                        form2.Show();

                    }
                }
                mySqlConnection.Close();
                if (!bylo) {
                    MessageBox.Show("Niepoprawne dane logowania!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Wyloguj()
        {
            /// <summary>
            /// Funkcja przypisuje puste ciągi znaków do LoginInput i HasloInput
            /// </summary>
            LoginInput.Text = "";
            HasloInput.Text = "";
        }
    }
}