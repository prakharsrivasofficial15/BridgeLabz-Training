using HealthCareApp.Models;

namespace HealthCareApp.Interfaces;

public interface IVisitUtility
{
    void AddVisit(Visit visit);
    void UpdateVisit(Visit visit);
    Visit GetVisitById(int id);
    List<Visit> GetVisitsByPatient(int patientId);
}
