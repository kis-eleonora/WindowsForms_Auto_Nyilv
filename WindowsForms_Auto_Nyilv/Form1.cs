using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms_Auto_Nyilv
{
    public partial class Form1 : Form
    {
        string adatfajl = "autok.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Rendszam.Text) || comboBox_Gyartmany.SelectedIndex < 0 || comboBox_Tipus.SelectedIndex < 0 || comboBox_Szin.SelectedIndex < 0)
            {
                MessageBox.Show("Minden mező kitöltése kötelező!");
                textBox_Rendszam.Focus();
                return;
            }
            
            try
            {
                using (StreamWriter sw = new StreamWriter(adatfajl))
                {
                    sw.WriteLine(String.Join(";",
                        textBox_Rendszam.Text,
                        comboBox_Gyartmany.SelectedItem,
                        comboBox_Tipus.SelectedItem,
                        dateTimePicker_Uz_Datum.Value.ToString("yyyy-MM-dd"),
                        comboBox_Szin.SelectedItem,
                        (checkBox_Muszaki.Checked? "true" : "false")));
                }
                MessageBox.Show("Az adatok kiírása megtörtént!");
                textBox_Rendszam.Text = "";
                comboBox_Gyartmany.SelectedIndex = -1;
                comboBox_Tipus.SelectedIndex = -1;
                comboBox_Szin.SelectedIndex = -1;          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void button_vosszatolt_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(adatfajl))
                {
                    string[] adat = sr.ReadLine().Split(';');
                    textBox_Rendszam.Text = adat[0];
                    comboBox_Gyartmany.SelectedItem = adat[1];
                    comboBox_Tipus.SelectedItem = adat[2];
                    dateTimePicker_Uz_Datum.Value = DateTime.Parse(adat[3]);
                    comboBox_Szin.SelectedItem = adat[4];
                    checkBox_Muszaki.Checked = Boolean.Parse(adat[5]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
