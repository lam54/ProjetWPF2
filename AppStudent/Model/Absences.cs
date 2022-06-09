using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStudent.Model
{
    class Absences
    {
        public int Id { get; set; }


        /// <summary>
        /// Constructeur pour faire l'instanciation
        /// </summary>
        public Absences()
        {

        }
        public Absences(int id)

        {
            this.Id = id; 
        }
      
    }
}
