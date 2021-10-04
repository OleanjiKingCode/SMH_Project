using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMH_Project.ViewModel;
using SMH_Project.ViewModel.Patients;

namespace SMH_Project.Interfaces
{
    public  interface IPatientRepository
    {
        Task<bool> AddPatientAsync(AddPatientVM addPatientVM);
        Task<bool> UpdatePatientAsync(UpdateVM update);
        Task<bool> DeletePatientAsync(int patientId);
        Task<List<PatientVM>> GetAllPatientAsync();
        Task<PatientVM> GetPatientByIdAsync(int pateintId);

    }
}
