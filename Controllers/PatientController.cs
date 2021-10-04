using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SMH_Project.Interfaces;
using SMH_Project.Models;
using SMH_Project.ViewModel;
using SMH_Project.ViewModel.Patients;

namespace SMH_Project.Controllers
{
    public class PatientController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPatientRepository _patientRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public PatientController(ILogger<HomeController> logger, IPatientRepository patientRepository,
                                 IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _patientRepository = patientRepository;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var Patients = await _patientRepository.GetAllPatientAsync();
            return View(Patients);
        }
        [HttpPost]
        public async Task<IActionResult> Index(int id)
        {
            var patient = await _patientRepository.DeletePatientAsync(id);
            return RedirectToAction("Index", "Patient");
        }
       
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddPatientVM model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    uniqueFileName=Guid.NewGuid().ToString()+"_"+ model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }



                AddPatientVM patient = new AddPatientVM
                {
                    PatientName = model.PatientName,
                    DOB = model.DOB,
                    Age = model.Age,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    Gender = model.Gender,
                    Address = model.Address,

                    

                };
                await _patientRepository.AddPatientAsync(patient);

                return RedirectToAction(nameof(Index));
            }
            return View();

        }


        public async Task<IActionResult> Details(int id)
        {


            var patient = await _patientRepository.GetPatientByIdAsync(id);



            return View(patient);
        }

        
        public async Task<IActionResult> Edit(int id)
        {
            var patient = await _patientRepository.GetPatientByIdAsync(id);
            if (patient is null)
            {
                return NotFound();
            }
            var response = new UpdateVM
            {
                PatientName = patient.PatientName,
                Age = patient.Age,
                PatientId = patient.PatientId,
                PhoneNumber = patient.PhoneNumber,
                Email=patient.Email,
                Address = patient.Address,
                Gender=patient.Gender,
                DOB = patient.DOB,
               
            };

            return View(response);
        }



        [HttpPost]
        public async Task<IActionResult> Edit (UpdateVM model)
        {
           

            if (!ModelState.IsValid)
            {
                return View(model);


            }
            await _patientRepository.UpdatePatientAsync(model);
               
            return RedirectToAction("Index" , "Patient", new { updated = "yes"});


        }
    }
}