using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using AppStudent.Model; 

namespace AppStudent.Business
{
    class MainWindowBusiness
    {     
        public string TitlOfMainWindow { get; set; }
        // La liste est crée à partir de la liste Etudiant
        // Maintenant, en va faire un pont vers le ManWord de l'interface. 
        public List<Model.Etudiant> litOfStudent { get; set; }


        // Constructeur: 
        public MainWindowBusiness()
        {
            TitlOfMainWindow = "Hello from other side";
            litOfStudent = new List<Etudiant>();// instanciation de la liste avant de la remplir
            for (int i=0; i<4; i++)
            {
                Etudiant etudiant = new Etudiant(); 
                etudiant.CIN = "1234";
                etudiant.CNE = "93823";
                etudiant.Nom = "lamine" + i.ToString();
                etudiant.Prenom = "Prenom" + i.ToString();

                litOfStudent.Add(etudiant); // Remplir la liste 

                Etudiant etudiant2 = new Etudiant();
                etudiant2.CIN = "1234";
                etudiant2.CNE = "93823";
                etudiant2.Nom = "Hocine" + i.ToString();
                etudiant2.Prenom = "Megri" + i.ToString();

                litOfStudent.Add(etudiant2); // Remplir la liste 



            }
        }


    }
}
