using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpListCompeBancaire
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            double retrait = 0;
            double solde = 0;
            string nom="";
            string prenom="";
            double numDeTelephone=0;
            
            int choix;

            Compte cmp = new Compte();
            Random test = new Random();
            Operation cmm = new Operation();
            int code = test.Next(9999, 99999);

            do
            {
                
                Console.WriteLine("\n****** Banque Peu Populaire ******");
                Console.WriteLine("1-Créer un compte bancaire");
                Console.WriteLine("2-Déposer de l'argent");
                Console.WriteLine("3-Retirer de l'argent ");
                Console.WriteLine("4-Afficher un compte bancaire ");
                Console.Write("Entrer votre choix : ");
                if (int.TryParse(Console.ReadLine(), out choix))
                {

                    switch (choix)
                    {
                        case int tmp when (tmp == 1):
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"\n***** Création d'un nouveau compte *****\n");
                            Console.Write("Le nom du client : ");
                            nom = Convert.ToString(Console.ReadLine());
                            Console.Write("\nLe prénom du client : ");
                            prenom = Convert.ToString(Console.ReadLine());
                            Console.Write("\nLe téléphone du client : ");
                            numDeTelephone = Convert.ToDouble(Console.ReadLine());
                            Compte comp = new Compte();
                            Console.Clear();
                            comp.CreationDeCompte(solde, code);
                            
                            break;
                        case int tmp when (tmp == 2):
                            solde = cmm.DepotDeLargent(code);
                            break;
                        case int tmp when (tmp == 3):
                            retrait = cmm.RetraitDeLargent(code, solde);
                            solde = solde - retrait;
                            break;
                        case int tmp when (tmp == 4):
                            cmm.AffichageDuCompte(nom, prenom, numDeTelephone, solde, code, retrait);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Erreure de saisie.\n ");
                            break;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tErreur de saisie, Merci de saisir un chiffre entre 0 et 4!");
                    choix = Convert.ToInt32(Console.ReadLine());
                    continue;

                }


            } while (choix != 0);
        }
    }
}
