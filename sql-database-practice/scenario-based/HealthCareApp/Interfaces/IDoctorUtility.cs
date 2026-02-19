using HealthCareApp.Models;

namespace HealthCareApp.Interfaces;

public interface IDoctorUtility
{
    void AddDoctor(Doctor doctor);
    void UpdateDoctor(Doctor doctor);
    void DeactivateDoctor(int id);
    Doctor GetDoctorById(int id);
    List<Doctor> GetAllDoctors();
}
