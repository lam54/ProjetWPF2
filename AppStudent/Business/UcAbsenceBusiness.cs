using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppStudent.Model; 

namespace AppStudent.Business
{
    class UcAbsenceBusiness
    {
        public List<Absences> ListOfAbsences { get; set; }

        public UcAbsenceBusiness()
        {
            ListOfAbsences = new List<Absences>();
            for (int i = 0; i <= 4; i++)
            {
                Absences absences = new Absences(1);
                ListOfAbsences.Add(absences);
            }
                

        }
    }
}
