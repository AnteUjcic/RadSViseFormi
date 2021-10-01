using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSViseFormi
{
    public partial class FormUnosNovogStudenta : Form
    {
        public student student1

        {

            get

            {

                return student1;

            }

            set

            {

                student1 = value;

            }

        }
        public FormUnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBrojIndeksa_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSmjer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {


            student1 = new student();

           

            student1.Ime = textBoxIme.Text;

            student1.Prezime = textBoxPrezime.Text;

            student1.BrojIndeksa = textBoxBrojIndeksa.Text;

            student1.Smjer = comboBoxSmjer.SelectedItem.ToString();

            student1.DatumRodjenja =
            dateTimePickerDatumRodjenja.Value;

            DialogResult = DialogResult.OK;
        }

        private void buttonOtkaz_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
