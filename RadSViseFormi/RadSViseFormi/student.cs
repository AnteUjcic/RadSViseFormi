using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadSViseFormi
{
    public class student
    {

        private string ime, smjer, prezime, brojIndeksa;

        private DateTime datumRodjenja;


        public string Ime { get => ime; set => ime = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }

        public student(string ime, string smjer, string prezime, string brojIndeksa, DateTime datumRodjenja)
        {
            this.ime = ime;
            this.smjer = smjer;
            this.prezime = prezime;
            this.brojIndeksa = brojIndeksa;
            this.datumRodjenja = datumRodjenja;
        }

        public student()
        {
        }

        public override string ToString()

        {

            return ime + " " + prezime + " " +
            brojIndeksa + " " +
            datumRodjenja.ToShortDateString() + " " + smjer;

        }

    }
}   
       

 




    

