using System;
using System.Threading;

namespace LibraryJeuDeRole
{
    public class Jeu
    {
        #region -- Attributs privés --
        private Personnage joueur1;
        private Personnage joueur2;
        #endregion
        #region // -- ATTRIBUTS PUBLIQUES --
        public Personnage Joueur1 { get => joueur1; set => joueur1 = value; }
        public Personnage Joueur2 { get => joueur2; set => joueur2 = value; }
        #endregion
        #region // -- METHODES --
        public bool FinDePartie()
        {
            bool isFinDePartie;
            if ((!joueur1.EnVie())||(!joueur2.EnVie()))
            {
                isFinDePartie=true;
            }
            else
            {
                isFinDePartie = false;
            }
            return isFinDePartie;
        }
        public int LancerLeDe()
        {
            Random rd = new Random();
            Thread.Sleep(300);
            return rd.Next(1, 7);
        }
        public void LancerLeJeu()
        {
            int j1ScoreDe, j2ScoreDe, QuiJoue = 0;
            Console.WriteLine("Que la partie commence !");
            do
            {
                j1ScoreDe = LancerLeDe();
                j2ScoreDe = LancerLeDe();
                if (j1ScoreDe > j2ScoreDe)
                {
                    QuiJoue = 0;
                    Console.WriteLine(joueur1.Nom+" commence.");
                }
                if (j1ScoreDe < j2ScoreDe)
                {
                    QuiJoue = 1;
                    Console.WriteLine(joueur2.Nom + " commence.");
                }
            } while (j1ScoreDe == j2ScoreDe);
            while (!FinDePartie())
            {
                if (QuiJoue == 0)
                {
                    Console.WriteLine("-------------------C'est au tour de " + joueur1.Nom + " tapez sur une touche");
                    Console.ReadKey();
                    joueur1.AttaquerUnAdversaire(joueur2, LancerLeDe());
                    QuiJoue = 1;
                }
                else
                {
                    Console.WriteLine("-------------------C'est au tour de " + joueur2.Nom + " tapez sur une touche");
                    Console.ReadKey();
                    joueur2.AttaquerUnAdversaire(joueur1, LancerLeDe());
                    QuiJoue = 0;
                }
            }
            Console.WriteLine("Fin de pratie");
            Console.ReadKey();
        }
        #endregion
        #region // -- CONSTRUCTEUR --
        public Jeu(Personnage p_joueur1,Personnage p_joueur2)
        {
            this.joueur1 = p_joueur1;
            this.joueur2 = p_joueur2;
        }
        #endregion
    }
}
