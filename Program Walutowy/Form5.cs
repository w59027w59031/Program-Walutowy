using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Walutowy
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            try
            {
                string UserId = "";
                foreach (var item in Application.OpenForms.OfType<MenuLogRej>())
                {
                    UserId = item.LooserId;
                }

                String CONNSTRING = "Server=remotemysql.com; Database=fXFbJYw3Cb; Uid=fXFbJYw3Cb; Password=tjV0Oa4Jhr; port=3306;";
                MySqlConnection mySqlConnection = new MySqlConnection(CONNSTRING);
                MySqlCommand mySqlCommand = new MySqlCommand("select id,waluta_z,ilosc_z,waluta_do,ilosc_do,data_operacji,uzytkownik_id from historia where uzytkownik_id='" + UserId + "'", mySqlConnection);
                MySqlDataReader mySqlDataReader;
                mySqlConnection.Open();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    if (!mySqlDataReader.IsDBNull(0))
                    {
                        TransHis.Items.Add(mySqlDataReader.GetString(1) + " (" + mySqlDataReader.GetFloat(2)+")     --->    "+ mySqlDataReader.GetString(3) + " (" + mySqlDataReader.GetFloat(4) + ")   |   "+ mySqlDataReader.GetString(5));
                    }
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Form Parent;
        private void GoBack_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Funkcja ukrywa aktualny formularz i wyświetla poprzedni
            /// </summary>
            this.Hide();
            Parent.Show();
        }
    }
}
