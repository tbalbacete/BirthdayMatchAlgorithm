using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMatchAlgorithm
{
    public class PersonModel
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }

        public PersonModel(int id, DateTime birthDate)
        {
            Id = id;
            BirthDate = birthDate;
        }
    }
}
