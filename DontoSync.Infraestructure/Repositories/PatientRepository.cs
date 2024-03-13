using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DontoSync.Core.Entities;
using DontoSync.Infraestructure.Persistence;
using DontoSync.Infraestructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DontoSync.Infraestructure.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApiDbContext _context;
        public PatientRepository(ApiDbContext context)
        {
            _context = context;
        }
        public async Task<ICollection<Patient>> GetAllAsync()
        {
            var patients = await _context.Patients.ToListAsync();

            return patients;
        }

        public async Task<Patient> GetByNameAsync(string patientName)
        {
            var patient = await _context.Patients.FirstOrDefaultAsync(p => p.Name == patientName);

            if (patient == null) return null;

            return patient;
        }

        public async Task<Patient> CreatePatientAsync(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();

            return patient;
        }

        public async Task<Patient> UpdatePatientAsync(Patient patient)
        {
            var updatePatient = await _context.Patients.FindAsync(patient.Id);

            if (updatePatient == null) return null;

            updatePatient.Name = patient.Name;
            updatePatient.PhoneNumber = patient.PhoneNumber;
            updatePatient.DateOfBirthd = patient.DateOfBirthd;
            updatePatient.Address = patient.Address;
            await _context.SaveChangesAsync();

            return updatePatient;
        }

        public async Task<bool> DeletePatientAsync(int patientId)
        {
            var result = await _context.Patients.FindAsync(patientId);

            if(result == null) return false;

            _context.Patients.Remove(result);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
