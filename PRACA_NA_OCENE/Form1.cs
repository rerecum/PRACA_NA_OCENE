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
    public struct Dane
    {
        public string Imie;
        public string badanie;
        public DateTime data;
    }

    public partial class Form1 : Form
    {
        int start = 0;
        string end = "";
        int mass = 0;
        string[] queue = new string[5];

        void delete()
        {
            if(mass < 1)
            {
                System.Windows.Forms.MessageBox.Show("Brak danych do usunięcia");
                return;
            }

            for (int i = 1; i < mass; i++)
            {
                queue[i - 1] = queue[i];
            }
            mass--;
        }

        void show_elements()
        {
            if(mass < 1)
            {
                return;
            }

            string r_value = queue[0];

            for (int i = 1; i < mass; i++)
            {
                queue[i - 1] = queue[i];
            }
            mass--;

            zatwierdz.Text = r_value;
        }

        public Form1()
        {
            InitializeComponent();
            SetMyCustomFormat();
            numbers.Enqueue(osoba);
        }
        public void SetMyCustomFormat()
        {
            DateTime time = DateTime.Now;
            DateTime day = DateTime.Today;
            data.Format = DateTimePickerFormat.Custom;
            data.CustomFormat = "dd:MM:yyyy";
            data.Value = time;
            data.Value = day;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            realod.Start();
        }

       // private void zatwierdz_Click(object sender, EventArgs e)
       // {
         //   osoba.Imie = imie.Text;
         //   osoba.badanie = badanie_textbox.Text;
         //   osoba.data = data_badania.Value;
          //  ia_person = imie + " " + badanie_textbox + " " + data;

          //  if(mass > 3)
         //   {
         //       System.Windows.Forms.MessageBox.Show("Nie ma aktualnie miejsc");
         //       return;
         //   }

         //   queue[mass] = ia_person;
        //    mass++;
       //     start++;
       //     end = queue[0];
       // }

        Queue<Dane> numbers = new Queue<Dane>();

        Dane osoba = new Dane();
        int queue_z = 0;
        string ia_person = "";
        private void przycisk_z_Click(object sender, EventArgs e)
        {
            osoba.Imie = imie.Text;
            osoba.badanie = badanie_textbox.Text;
            osoba.data = data_badania.Value;
            ia_person = imie + " " + badanie_textbox + " " + data;

            if (mass > 3)
            {
                System.Windows.Forms.MessageBox.Show("Nie ma aktualnie miejsc");
                return;
            }

            queue[mass] = ia_person;
            mass++;
            start++;
            end = queue[0];
        }
    }
}