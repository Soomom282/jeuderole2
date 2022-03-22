using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryJeuDeRole
{
    public class Arme
    {
        #region -- Attributs privés --
        private int degats;
        private string nom;
        private static int degatsDeBase;
        #endregion
        #region // -- CONSTRUCTEUR --
        /// <summary>
        /// Constructeur de la classe Arme
        /// </summary>
        /// <param name="nom">Nom de l'arme</param>
        public Arme(string nom)
        {
            this.nom = nom;
            this.degats = degatsDeBase;
        }
        #endregion
        #region // -- ATTRIBUTS PUBLIQUES --
        public int Degats { get => degats; }
        public string Nom { get => nom; }
        public static int DegatsDeBase { get => degatsDeBase; set => degatsDeBase = value; }
        #endregion
    }
}
