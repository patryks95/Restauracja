using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Restauracja
{
   


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dane logowanie = new dane();
            SqlConnection sqlConn = new SqlConnection("Data Source=192.168.1.101,1433;Network Library=dbmssocn;Initial Catalog = Northwind; User ID = " + Tekst_Logowanie.Text + ";Password = " + Tekst_Haslo.Text + ";");
            try
            {

                // otwórz połączenie:
                sqlConn.Open();
                logowanie.Ustaw_login(Tekst_Logowanie.ToString());
                logowanie.Ustaw_haslo(Tekst_Haslo.ToString());
                Tekst_Logowanie.Dispose();
                Etykieta_Logowanie.Dispose();
                Tekst_Haslo.Dispose();
                Etykieta_Haslo.Dispose();
                Przycisk_Logowania.Dispose();
                sqlConn.Close();
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                MessageBox.Show(se.Message,se.Source);

            }


        }
        class dane
        {
            string login = "";
            string hasło = "";
            public void Ustaw_login(string l) { login = l; }
            public void Ustaw_haslo(string h) { hasło = h; }
        }
    }
}
