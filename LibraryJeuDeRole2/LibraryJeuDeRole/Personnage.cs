using System;

namespace LibraryJeuDeRole
{
    public class Personnage
    {
        #region // --attributs prives --
        private string nom;
        private int pointsDeVie;
        private int positionX, positionY;
        private Arme arme;
        private static int nbPointsDeVieBase = 100;
        #endregion
        #region // -- CONSTRUCTEUR --
        /// <summary>
        /// Constructeur de la classe "personnage"
        /// </summary>
        /// <param name="p_nom">Nom du perso</param>
        /// <param name="p_arme">Arme du perso</param>
        public Personnage(string p_nom, Arme p_arme) 
        {
            this.positionX = 0;
            this.positionY = 0;
            this.pointsDeVie = Personnage.NbPointsDeVieBase;
            //argument
            this.nom = p_nom;
            this.arme = p_arme;
        }
        #endregion
        #region // -- Proprietes publiques
        public string Nom { get => nom; set => nom = value; }
        public Arme Arme { get => arme; }
        public int PointsDeVie { get => pointsDeVie; }
        public int PositionX { get => positionX; }
        public int PositionY { get => positionY; }
        public static int NbPointsDeVieBase { get => nbPointsDeVieBase; }
        #endregion
        #region // -- METHODES --
        public void AttaquerUnAdversaire(Personnage victime, int des)
        {
            victime.RecevoirDesDegats(des * arme.Degats);
        }

        public bool EnVie()
        {
            bool isVie;
            if (this.pointsDeVie <= 0)
            {
                isVie = false;
            }
            else
            {
                isVie = true;
            }
            return isVie;
        }

        public void RecevoirDesDegats(int nombre)
        {
            this.pointsDeVie -= nombre;
            Console.WriteLine(this.nom+" a perdu " + nombre + " points de vie.");
            Console.WriteLine(this.nom + " a maintenant " + pointsDeVie + " points de vie.");
        }

        public void SeDeplacer() 
        {
            this.positionX = 0;
            this.positionY = 0;
            Console.WriteLine("Je me suis déplacé de ");
        }

        public void SePresenter()
        {
            Console.WriteLine("Moi c'est " + this.nom + ", je possède " + arme.Nom);
        } 
        #endregion
    }
}
