using System;
namespace TpListCompeBancaire
{
    public class Compte
    {
        string Nom;
        string Prenom;
        double NumTelephone;
        double Solde;
        double Code;
        public Compte()
        {
            

        }
        public Compte(string nom, string prenom, double numTelephone, double solde,double code)
        {
            Nom = nom;
            Prenom = prenom;
            NumTelephone = numTelephone;
            Solde = solde;
            Code = code;

        }
        public string nom { get => Nom; set => Nom = value; }
        public string prenom { get => Prenom; set => Prenom = value; }
        public double numTelephone { get => NumTelephone; set => NumTelephone = value; }
        public double solde { get => Solde; set => Solde = value; }
        public double code { get => Code; set => Code = value; }

        public void CreationDeCompte(double solde, double code)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Compte bien crée, voici le numéro de compte : {code}");
            Console.WriteLine($"Votre compte à un solde de {solde}.");
            Console.ResetColor();
        }

        public void Information(string Nom, string Prenom, double NumTelephone, double solde, double retrait)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Nom : {Nom}, Prénom : {Prenom}, Téléphone : {NumTelephone}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Solde : {solde}Euro");
            Console.ResetColor();
        }

    }

    public class Operation : Compte
    {
        double Solde;
        double Retrait;
        public Operation()
        {

        }
       
        public double DepotDeLargent(double code)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"***** Déposer de l'argent *****\n");
            Operation Test = new Operation();
            bool bol = Test.VerifierLeCode(code);
            if (bol == true)
            {
                Console.Write("Merci de saisir le montant du depot : ");
                if (double.TryParse(Console.ReadLine(), out Solde))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Dépot reussi");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Erreur de saisie, Merci de saisir un nombre");
                    solde = Convert.ToDouble(Console.ReadLine());
                    Console.ResetColor();

                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Erreur de saisie, Merci de saisir le code");
                double Testcode = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();

            }

            return Solde;
        }

        public double RetraitDeLargent(double code, double solde)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***** Retirer de l'argent *****\n ");
            Operation Test = new Operation();
            bool bol = Test.VerifierLeCode(code);
            if (bol == true)
            {
                Console.Write("Merci de saisir le montant du Retrait : ");
                if (double.TryParse(Console.ReadLine(), out Retrait))
                {
                    if (Retrait <= solde)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Retrait reussi");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Votre solde de {solde}Euro est insuffisant pour effectuer cette opération.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tErreur de saisie, Merci de saisir un nombre");
                    Retrait = Convert.ToDouble(Console.ReadLine());
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\tErreur de saisie, Merci de saisir Le Code : ");
                code = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();
            }
            
            return Retrait;
            
        }

        public bool VerifierLeCode(double code)
        {
            bool bol;
            Console.Write("Merci de saisir le numero de compte : ");
            if (double.TryParse(Console.ReadLine(), out double Testcode))
            {
                if (Testcode == code)
                {
                    bol = true;
                }
                else
                {
                    bol = false;
                }
            }
            else
            {
                bol = false;
            }

            return bol;
        }
        public void AffichageDuCompte(string nom, string prenom, double numDeTelephone, double solde, double code, double retrait)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n***** Afficher un compte *****\n ");
            Operation Test = new Operation();
            bool bol = Test.VerifierLeCode(code);
            if (bol ==true)
            {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Liste Opérations : ");
                    Compte cmp = new Compte();
                    cmp.Information(nom, prenom, numDeTelephone, solde,retrait);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\tErreur de saisie, Merci de saisir le Code");
                double TestCode = Convert.ToDouble(Console.ReadLine());
            }
        }
        public class Utilisateur : Compte
        {
            
            double NumDeTelephone;
            double Solde;
            public Utilisateur()
            {
               

            }
            public Utilisateur(string Nom, string Prenom, double NumTelephone, double solde)
            {
                nom = Nom;
                prenom = Prenom;
                NumDeTelephone = numTelephone;
                Solde = solde;

            }

            
        }

    }
}



