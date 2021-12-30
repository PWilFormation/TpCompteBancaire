using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaire.Classes
{
    internal class Compte
    {
        private static int id_compte = 0;
        private double solde = 0;

        public Compte()
        {
            id_compte++;
        }

        public Compte(double solde) : this()
        {
            Solde = solde;
        }


        public double Solde { get => solde; set => solde = value; }
    }
}
