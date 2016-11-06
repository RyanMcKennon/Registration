using EfRegistration;
using RegistrationDataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDataClient.Mappers
{
    public class ProfessorMapper
    {
        public static ProfessorDAO MapToProfessorDAO(Professor professor)
        {
            var prof = new ProfessorDAO();
            prof.Id = professor.ProfessorID;
            prof.name = professor.Name;
            return prof;
        }

        public static Professor MapToProfessorDAO(ProfessorDAO professor)
        {
            var prof = new Professor();
            prof.ProfessorID = professor.Id;
            prof.Name = professor.name;
            return prof;
        }
    }
}
