using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaire.Classes
{
    internal class IHM
    {
        public static int AfficherMenu()
        {
            Console.WriteLine("****** Banque Peu Populaire ******");
            Console.WriteLine("1-Créer un compte bancaire");
            Console.WriteLine("2-Déposer de l'argent");
            Console.WriteLine("3-Retirer de l'argent");
            Console.WriteLine("4-Afficher un compte bancaire");
            Console.Write("Entrez votre choix : ");
            int choix = int.Parse(Console.ReadLine());
            return choix;
        }

        public static void AfficherCreationCompte(string nom, string prenom, string tel)
        {
            Console.WriteLine("***** Création d'un nouveau compte *****");
            Console.Write($"Le nom du client : {nom}");
            Console.Write($"Le prénom du client : {prenom}");
            Console.Write($"Le téléphone du client : {tel}");
        }
    }
}
