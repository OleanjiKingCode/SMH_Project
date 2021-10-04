using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SMH_Project.DbContexts;
using SMH_Project.Interfaces;
using SMH_Project.Models;
using SMH_Project.ViewModel;
using SMH_Project.ViewModel.Patients;

namespace SMH_Project.Repository
{
    public class PatientRepository :IPatientRepository
    {
        private readonly ApplicationDbContext _context;

        public PatientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddPatientAsync(AddPatientVM addPatientVM)
        {

            var patient = new Patient
            {
                PatientName = addPatientVM.PatientName,
                DOB = addPatientVM.DOB,
                Age = addPatientVM.Age,
                PhoneNumber= addPatientVM.PhoneNumber,
                Email= addPatientVM.Email,
                Gender= addPatientVM.Gender,
                Address= addPatientVM.Address,

                CreatedOn = DateTime.Now,
                CreatedBy = "Basit",

            };
            await _context.Patients.AddAsync(patient);
            var result = await _context.SaveChangesAsync();
            return result > 0 ? true : false;
        }

        public async Task<List<PatientVM>> GetAllPatientAsync()
        {
            var patients = await _context.Patients
                .Where(c => c.IsDeleted == false)
                .Select(c => new PatientVM
                {
                    PatientName = c.PatientName,
                    Age = c.Age,
                    PatientId = c.PatientId,
                    PhoneNumber = c.PhoneNumber,
                    CreatedBy = c.CreatedBy,
                    CreatedOn = c.CreatedOn,
                   
                    UpdateBy = c.UpdateBy,
                    UpdateOn = c.UpdateOn


                }).ToListAsync();
            return patients;
        }

        public async Task<PatientVM> GetPatientByIdAsync(int pateintId)
        {
            var patient = await _context.Patients.FirstOrDefaultAsync(c => c.PatientId == pateintId);
            if (patient == null)
            {
                return null;
            }
            return new PatientVM
            {
                PatientName = patient.PatientName,
                Age = patient.Age,
                PatientId = patient.PatientId,
                PhoneNumber = patient.PhoneNumber,
                Email=patient.Email,
                Address = patient.Address,
                Gender=patient.Gender,
                DOB = patient.DOB,
                CreatedBy = patient.CreatedBy,
                CreatedOn = patient.CreatedOn,
               
                UpdateBy = patient.UpdateBy,
                UpdateOn = patient.UpdateOn
            };
        }
        public async Task<bool> DeletePatientAsync(int patientId)
        {
            var patient = await _context.Patients.FirstOrDefaultAsync(p => p.PatientId == patientId);
            if (patient == null)
            {
                return false;
            }
            patient.IsDeleted = true;
            patient.DeletedBy = "Basit";
            patient.DeletedOn = DateTime.Now;
            _context.Patients.Update(patient);
            var result = await _context.SaveChangesAsync();
            return result > 0 ? true : false;
        }


        public async Task<bool> UpdatePatientAsync(UpdateVM update)
        {
            var patient = await _context.Patients
                                .FirstOrDefaultAsync(c => c.PatientId == update.PatientId);
            var isExist = await _context.Patients.AnyAsync(c => c.PatientName == update.PatientName && c.IsDeleted == false
            && c.PatientId != update.PatientId);
            if (isExist)
            {
                return false;
            }
            patient.PatientName = update.PatientName;
            patient.Age = update.Age;
            
            patient.PhoneNumber = update.PhoneNumber;
            patient.Email = update.Email;
            patient.Address = update.Address;
            patient.Gender = update.Gender;
            patient.DOB = update.DOB;
            patient.UpdateOn = DateTime.Now;
            patient.UpdateBy = "Basit";

            _context.Patients.Update(patient);
            var result = await _context.SaveChangesAsync();
            return result > 0 ? true : false;


        }
    }
}
