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
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        struct Dane
        {
            string Imie;
            string badanie;
            DateTime Data;
        }
        public void WypiszWartosci()
        {
            Console.WriteLine("Imie: {0}");
            Console.WriteLine("badanie: {0}");
            Console.WriteLine("Data: {0}");
        }
    }
}
