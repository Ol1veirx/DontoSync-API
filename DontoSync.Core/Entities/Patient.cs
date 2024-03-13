using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontoSync.Core.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirthd { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MedicalHistory { get; set; }

        public int DentistId { get; set; }
        public Dentist Dentist { get; set; }
    }
}
