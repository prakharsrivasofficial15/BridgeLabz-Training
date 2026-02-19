using HealthCareApp.Models;

namespace HealthCareApp.Interfaces;

public interface IPatientUtility
{
    void AddPatient(Patient patient);
    void UpdatePatient(Patient patient);
    void DeletePatient(int id);
    Patient GetPatientById(int id);
    List<Patient> GetAllPatients();
}
