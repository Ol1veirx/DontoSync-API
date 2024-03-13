using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontoSync.Core.Entities
{
    public class Consultation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<string> Procedures { get; set; }
        public string Diagnosis { get; set; }
        public string Description { get; set; }
        public string FollowUpInstructions { get; set; }

        public int DentistId { get; set; }
        public Dentist? Dentist { get; set; }

        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}
