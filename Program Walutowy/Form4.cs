using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Program_Walutowy
{
    public partial class Form4 : Form
    {
        public string[] KodyWalut;
        public Form4()
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
                MySqlCommand mySqlCommand = new MySqlCommand("select waluta from pieniadze", mySqlConnection);
                MySqlDataReader mySqlDataReader;
                mySqlConnection.Open();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    if (!mySqlDataReader.IsDBNull(0))
                    {
                        if (KodyWalut != null)
                        {
                            string[] KodyWalut_TMP = new string[KodyWalut.Length];
                            KodyWalut_TMP = KodyWalut;
                            KodyWalut = new string[KodyWalut_TMP.Length + 1];
                            for (int i = 0; i < KodyWalut_TMP.Length; i++)
                            {
                                KodyWalut[i] = KodyWalut_TMP[i];
                            }
                        }
                        else
                        {
                            KodyWalut = new string[1];
                        }
                        KodyWalut[KodyWalut.Length - 1] = mySqlDataReader.GetString(0);
                    }
                }
                mySqlConnection.Close();

                foreach (string item in KodyWalut)
                {
                    CurrencyIn.Items.Add(item);
                }
                foreach (string item in KodyWalut)
                {
                    CurrencyOut.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Form Parent;
        public class waluty
        {
            public string nazwa_waluty = "";
            public float przelicznik;
            public string kod_waluty = "";
            public float kurs_kupna;
            public float kurs_sprzedazy;
        }
        public waluty[] wwaluty = new waluty[0];
        private void CancelEx_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        private void Exchange_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (CzyJestLiczba(MoneyBEx.Text))
                {
                    if (float.Parse(MoneyBEx.Text) > float.Parse(MoneyIn.Text))
                    {
                        MessageBox.Show("Nie wystarczające środki.");

                        if (float.Parse(MoneyBEx.Text) < 0)
                        {
                            MessageBox.Show("Wartość ujemna!");

                            string UserId = "";
                            foreach (var item in Application.OpenForms.OfType<MenuLogRej>())
                            {
                                UserId = item.LooserId;
                            }

                            String CONNSTRING = "Server=remotemysql.com; Database=fXFbJYw3Cb; Uid=fXFbJYw3Cb; Password=tjV0Oa4Jhr; port=3306;";
                            MySqlConnection mySqlConnection = new MySqlConnection(CONNSTRING);
                            MySqlCommand mySqlCommand = new MySqlCommand("select ilosc from pieniadze where id='" + UserId + "' and waluta ='" + CurrencyIn.SelectedItem + "'", mySqlConnection);
                            MySqlDataReader mySqlDataReader;
                            mySqlConnection.Open();
                            mySqlCommand.CommandText = "update pieniadze set ilosc=ilosc-" + MoneyBEx.Text.Replace(',', '.') + " where id='" + UserId + "' and waluta ='" + CurrencyIn.SelectedItem + "'";
                            mySqlCommand.ExecuteNonQuery();
                            mySqlCommand.CommandText = "update pieniadze set ilosc=ilosc+" + MoneyAEx.Text.Replace(',', '.') + " where id='" + UserId + "' and waluta ='" + CurrencyOut.SelectedItem + "'";
                            mySqlCommand.ExecuteNonQuery();

                            mySqlCommand = new MySqlCommand($"insert into historia (waluta_z,ilosc_z,waluta_do,ilosc_do,uzytkownik_id)values('{CurrencyIn.SelectedItem}','{MoneyBEx.Text.Replace(',', '.')}','{CurrencyOut.SelectedItem}','{MoneyAEx.Text.Replace(',', '.')}','{UserId}')", mySqlConnection);
                            mySqlCommand.ExecuteNonQuery();
                            mySqlConnection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Podana wartość nie jest liczbą!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CurrencyIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Po zmianie wybranej waluty
            try
            {

                string UserId = "";
                foreach (var item in Application.OpenForms.OfType<MenuLogRej>())
                {
                    UserId = item.LooserId;
                }

                String CONNSTRING = "Server=remotemysql.com; Database=fXFbJYw3Cb; Uid=fXFbJYw3Cb; Password=tjV0Oa4Jhr; port=3306;";
                MySqlConnection mySqlConnection = new MySqlConnection(CONNSTRING);
                MySqlCommand mySqlCommand = new MySqlCommand("select ilosc from pieniadze where id='" + UserId + "' and waluta ='" + CurrencyIn.SelectedItem + "'", mySqlConnection);
                MySqlDataReader mySqlDataReader;
                mySqlConnection.Open();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    if (!mySqlDataReader.IsDBNull(0))
                    {
                        MoneyIn.Text = mySqlDataReader.GetString(0);
                    }
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CurrencyOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Po zmianie wybranej waluty
            try
            {

                string UserId = "";
                foreach (var item in Application.OpenForms.OfType<MenuLogRej>())
                {
                    UserId = item.LooserId;
                }

                String CONNSTRING = "Server=remotemysql.com; Database=fXFbJYw3Cb; Uid=fXFbJYw3Cb; Password=tjV0Oa4Jhr; port=3306;";
                MySqlConnection mySqlConnection = new MySqlConnection(CONNSTRING);
                MySqlCommand mySqlCommand = new MySqlCommand("select ilosc from pieniadze where id='" + UserId + "' and waluta ='" + CurrencyOut.SelectedItem + "'", mySqlConnection);
                MySqlDataReader mySqlDataReader;
                mySqlConnection.Open();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    if (!mySqlDataReader.IsDBNull(0))
                    {
                        MoneyOut.Text = mySqlDataReader.GetString(0);
                    }
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool CzyJestLiczba(string str)
        {
            int licznik = 0;
            foreach (char c in str)
            {
                if (c == ',' && str.Length < 3)
                {
                    return false;
                }
                if (c == ',' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                {
                    licznik++;
                }
            }
            if (licznik == str.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void MoneyBEx_TextChanged(object sender, EventArgs e)
        {
            if (CzyJestLiczba(MoneyBEx.Text))
            {
                if (MoneyBEx.Text != null && MoneyBEx.Text != "" && MoneyBEx.Text.Length > 0)
                {
                    string url = "https://www.nbp.pl/kursy/xml/c114z190613.xml";
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(url);
                    string XMLStr = "";
                    using (var wc = new WebClient())
                    {
                        XMLStr = wc.DownloadString(url);
                    }
                    int licznik_pozycji = 0;
                    int licznik_p_poz = 0;
                    foreach (string str2 in XMLStr.Split(new string[2] { "<pozycja>", "</pozycja>" }, StringSplitOptions.None))
                    {
                        if (str2.Contains("<"))
                        {
                            waluty[] wwaluty_tmp = new waluty[wwaluty.Length];
                            wwaluty_tmp = wwaluty;
                            wwaluty = new waluty[wwaluty_tmp.Length + 1];
                            for (int i = 0; i < wwaluty.Length - 1; i++)
                            {
                                wwaluty[i] = new waluty();
                                wwaluty[i].kod_waluty = "";
                                wwaluty[i].kurs_kupna = 0;
                                wwaluty[i].kurs_sprzedazy = 0;
                                wwaluty[i].nazwa_waluty = "";
                                wwaluty[i].przelicznik = 0;
                                wwaluty[i] = wwaluty_tmp[i];
                            }
                            wwaluty[wwaluty.Length - 1] = new waluty();
                            if (licznik_pozycji > 0)
                            {
                                foreach (string pstr1 in str2.Split(new string[1] { "<nazwa_waluty>" }, StringSplitOptions.None))
                                {
                                    if (licznik_p_poz > 0)
                                    {
                                        wwaluty[wwaluty.Length - 1].nazwa_waluty = pstr1.Split(new string[1] { "</nazwa_waluty>" }, StringSplitOptions.None)[0];
                                    }
                                    licznik_p_poz++;
                                }
                                licznik_p_poz = 0;
                                foreach (string pstr1 in str2.Split(new string[1] { "<przelicznik>" }, StringSplitOptions.None))
                                {
                                    if (licznik_p_poz > 0)
                                    {
                                        wwaluty[wwaluty.Length - 1].przelicznik = float.Parse(pstr1.Split(new string[1] { "</przelicznik>" }, StringSplitOptions.None)[0]);
                                    }
                                    licznik_p_poz++;
                                }
                                licznik_p_poz = 0;
                                foreach (string pstr1 in str2.Split(new string[1] { "<kod_waluty>" }, StringSplitOptions.None))
                                {
                                    if (licznik_p_poz > 0)
                                    {
                                        wwaluty[wwaluty.Length - 1].kod_waluty = pstr1.Split(new string[1] { "</kod_waluty>" }, StringSplitOptions.None)[0];
                                    }
                                    licznik_p_poz++;
                                }
                                licznik_p_poz = 0;
                                foreach (string pstr1 in str2.Split(new string[1] { "<kurs_kupna>" }, StringSplitOptions.None))
                                {
                                    if (licznik_p_poz > 0)
                                    {
                                        wwaluty[wwaluty.Length - 1].kurs_kupna = float.Parse(pstr1.Split(new string[1] { "</kurs_kupna>" }, StringSplitOptions.None)[0]);
                                    }
                                    licznik_p_poz++;
                                }
                                licznik_p_poz = 0;
                                foreach (string pstr1 in str2.Split(new string[1] { "<kurs_sprzedazy>" }, StringSplitOptions.None))
                                {
                                    if (licznik_p_poz > 0)
                                    {
                                        wwaluty[wwaluty.Length - 1].kurs_sprzedazy = float.Parse(pstr1.Split(new string[1] { "</kurs_sprzedazy>" }, StringSplitOptions.None)[0]);
                                    }
                                    licznik_p_poz++;
                                }
                            }
                            licznik_pozycji++;
                        }
                    }
                    if (CzyJestLiczba(MoneyBEx.Text))
                    {
                        float odejmujemy = 0;
                        float dodajemy = 0;
                        foreach (waluty wal in wwaluty)
                        {
                            if (CurrencyIn.SelectedItem.ToString().ToUpper() == wal.kod_waluty.ToString().ToUpper())
                            {
                                odejmujemy = float.Parse(MoneyBEx.Text) / wal.kurs_kupna / wal.przelicznik;
                            }
                            if (CurrencyOut.SelectedItem.ToString().ToUpper() == wal.kod_waluty.ToString().ToUpper())
                            {
                                dodajemy = odejmujemy * wal.kurs_kupna * wal.przelicznik;
                            }
                            MoneyAEx.Text = dodajemy.ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nie podano ilości do przeliczenia!");
                }
            }
            else
            {
                MessageBox.Show("Podana wartość nie jest liczbą!");
            }
        }
    }
}
