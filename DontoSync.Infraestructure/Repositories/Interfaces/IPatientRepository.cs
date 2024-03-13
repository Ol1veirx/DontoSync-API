using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontoSync.Core.Entities;

namespace DontoSync.Infraestructure.Repositories.Interfaces
{
    public interface IPatientRepository
    {
        Task<ICollection<Patient>> GetAllAsync();
        Task<Patient> GetByNameAsync(string patientName);
        Task<Patient> CreatePatientAsync(Patient patient);
        Task<Patient> UpdatePatientAsync(Patient patient);
        Task<bool> DeletePatientAsync(int patientId);
    }
}
