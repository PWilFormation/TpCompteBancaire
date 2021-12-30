using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaire.Classes
{
    internal class Operation
    {
        private string date;
        private string heure;
        private double montant;

        public Operation()
        {

        }

        public Operation(string date, string heure, double montant)
        {
            Date = date;
            Heure = heure;
            Montant = montant;
        }

        public string Date { get => date; set => date = value; }
        public string Heure { get => heure; set => heure = value; }
        public double Montant { get => montant; set => montant = value; }
    }
}
