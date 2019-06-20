using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using MySql.Data.MySqlClient;

namespace Program_Walutowy
{
    public partial class Form2 : Form
    {
        public class waluty
        {
            public string nazwa_waluty = "";
            public float przelicznik;
            public string kod_waluty = "";
            public float kurs_kupna;
            public float kurs_sprzedazy;
        }
        waluty[] wwaluty = new waluty[0];
        public class LUZER
        {
            public string id;
            public string email;
            public string login;
            public string haslo;
            public int pln;
            public DateTime data_rejestracji;
            public DateTime data_ostatniego_log;
        }

        public LUZER JA;
        public Form Parent;

        public Form2()
        {
            InitializeComponent();
            JA = new LUZER();
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
            for (int i = 1; i < wwaluty.Length - 1; i++)
            {
                Currency.Items.Add(
                    wwaluty[i].nazwa_waluty.ToString() + "  |  " +
                    wwaluty[i].przelicznik.ToString() + "  |  " +
                    wwaluty[i].kod_waluty.ToString() + "  |  " +
                    wwaluty[i].kurs_kupna.ToString() + "  |  " +
                    wwaluty[i].kurs_sprzedazy.ToString()
                    );
            }
            //Stan konta

            try
            {

                string UserId = "";
                foreach (var item in Application.OpenForms.OfType<MenuLogRej>())
                {
                    UserId = item.LooserId;
                }

                String CONNSTRING = "Server=remotemysql.com; Database=fXFbJYw3Cb; Uid=fXFbJYw3Cb; Password=tjV0Oa4Jhr; port=3306;";
                MySqlConnection mySqlConnection = new MySqlConnection(CONNSTRING);
                MySqlCommand mySqlCommand = new MySqlCommand("select waluta, ilosc from pieniadze where id='"+ UserId + "'", mySqlConnection);
                MySqlDataReader mySqlDataReader;
                mySqlConnection.Open();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    if (!mySqlDataReader.IsDBNull(0))
                    {
                        Balance.Items.Add(
                        mySqlDataReader.GetString(0) + "  |  " + mySqlDataReader.GetUInt32(1)
                    );
                    }
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetChildren(XmlNode node, string element, string par)
        {
            if (node.LocalName == element)
            {
                foreach (string atrybut1 in node.InnerXml.Split(new string[1] { "<" + par + ">" }, StringSplitOptions.None))
                {
                    string atrybut2 = atrybut1.Split(new string[1] { "</" + par + ">" }, StringSplitOptions.None)[0];
                    if (atrybut2 != null && atrybut2 != "" && atrybut2.Length > 0)
                    {
                        return atrybut2;
                    }
                }
            }
            return "";
        }

        private void DoTransaction_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ShowHistory_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        public void wyswietl()
        {
            LoginS.Text = JA.login;
            EmailS.Text = JA.email;
            MoneyS.Text = JA.pln + "";
        }

        private void LogOut_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            foreach (var item in Application.OpenForms.OfType<MenuLogRej>())
            {
                item.Wyloguj();
            }
            Parent.Show();
        }
    }
}