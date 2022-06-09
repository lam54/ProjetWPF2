using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppStudent.Model; 

namespace AppStudent.Business
{
    class UcEtudiantBusiness
    {
        public List<Etudiant> ListOfStudent { get; set; }

        public UcEtudiantBusiness()
        {
            ListOfStudent = new List<Etudiant>();
            for (int i=0; i<4; i++ )
            {
                Etudiant etudiant = new Etudiant();
                etudiant.Nom = "karim :" + i.ToString();
                etudiant.Prenom = "benzema" + i.ToString();
                etudiant.CIN = "12345";
                etudiant.CNE= "4058638" + i.ToString();
                ListOfStudent.Add(etudiant); 
            }
        }
    }
}
