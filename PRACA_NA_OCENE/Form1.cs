using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACA_NA_OCENE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        public void SetMyCustomFormat()
        {
            DateTime time = DateTime.Now;
            DateTime day = DateTime.Today;
            data.Format = DateTimePickerFormat.Custom;
            data.CustomFormat = "HH:mm";
            data.Value = time;
            data.Value = day;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        struct Dane
        {
            public string Imie;
            public string badanie;
            public DateTime data;
        }

        Dane = new Dane();
        private void zatwierdz_Click(object sender, EventArgs e)
        {

        }

        private void przycisk_z_Click(object sender, EventArgs e)
        {

        }
    }
}
