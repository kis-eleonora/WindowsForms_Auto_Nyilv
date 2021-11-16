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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Rendszam.Text))
            {
                MessageBox.Show("Nem adta meg a rendszámot!");
                return;
            }
            String mentes = "Rendszám: " + textBox_Rendszam.Text + Environment.NewLine;
            if (comboBox_Gyartmany.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon gyártmányt!");
                return;
            }
            mentes += "Gyártmány: " + comboBox_Gyartmany.SelectedItem + Environment.NewLine;
            if (comboBox_Tipus.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon típust!");
                return;
            }
            mentes += "Típus: " + comboBox_Tipus.SelectedItem + Environment.NewLine;
            mentes += "Üzembehelyezés dátuma: " + dateTimePicker_Uz_Datum.Value.ToString("yyyy-MM-dd") + Environment.NewLine;
            if (comboBox_Szin.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon színt!");
                return;
            }
            mentes += "Szín: " + comboBox_Szin.SelectedItem + Environment.NewLine;
            
            if (checkBox_Muszaki.Checked)
            {
                mentes += "Érvényes műszakival rendelkezik." + Environment.NewLine;
            }
            else
            {
                mentes += "Nem rendelkezik érvényes műszakival." + Environment.NewLine;
            }
            mentes += Environment.NewLine;
            mentes += Environment.NewLine;

            TextWriter txt = new StreamWriter("C:\\Users\\HP.LAPTOP-DLPGP7O3\\Dokumentumok\\autok.txt", true);
            txt.Write(mentes);
            txt.Close();
        }
    }
}
