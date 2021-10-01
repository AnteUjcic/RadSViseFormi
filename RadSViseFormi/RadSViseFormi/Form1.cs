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
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta f = new FormUnosNovogStudenta(); 
            f.Show();
            FormUnosNovogStudenta frm = new FormUnosNovogStudenta();

            DialogResult rez = frm.ShowDialog();


            if (rez == System.Windows.Forms.DialogResult.OK)

                listBoxStudenti.Items.Add(frm.student1.ToString());
        }                        

        private void listBoxStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
            

            if (!(listBoxStudenti.SelectedIndex < 0))

                listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);
        }
    }
}
