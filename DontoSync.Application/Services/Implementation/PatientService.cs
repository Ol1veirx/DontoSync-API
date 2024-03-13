using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DontoSync.Application.Services.Interfaces;
using DontoSync.Core.Entities;
using DontoSync.Infraestructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace DontoSync.Application.Services.Implementation
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repository;
        public PatientService(IPatientRepository repository)
        {
            _repository = repository;
        }

        public async Task<ICollection<Patient>> GetAllAsync()
        {
            try
            {
                return await _repository.GetAllAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                return new List<Patient>();
            }
        }

        public async Task<Patient> GetByNameAsync(string patientName)
        {
            return await _repository.GetByNameAsync(patientName);
        }

        public async Task<Patient> CreatePatientAsync(Patient patient)
        {
            return await _repository.CreatePatientAsync(patient);
        }

        public async Task<Patient> UpdatePatientAsync(Patient patient)
        {
            return await _repository.UpdatePatientAsync(patient);
        }

        public async Task<bool> DeletePatientAsync(int patientId)
        {
            return await _repository.DeletePatientAsync(patientId);
        }
    }
}
