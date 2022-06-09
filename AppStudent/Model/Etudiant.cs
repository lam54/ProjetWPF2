using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStudent.Model
{
    public class Etudiant
    {
        #region Propriétés 
        /// <summary>
        /// // déclaration des propriétés: prop+ tab tab
        /// </summary>
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CIN { get; set; }
        public string CNE { get; set; }
        public DateTime DateDeNaissance { get; set; }
        #endregion

        #region Constructeur
        /// <summary>
        /// Création du constructeur: ctor + 2tab
        /// </summary>
        public Etudiant() // Ce constructeur va servir dans la classe business
        {

        }

        public Etudiant(string nom, string prenom) // Je vais créer un objet Etudiant avec un nom déja spécifié
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }
        public Etudiant(string prenom)
        {
            this.Prenom = prenom;
        }

        #endregion
    }
}

