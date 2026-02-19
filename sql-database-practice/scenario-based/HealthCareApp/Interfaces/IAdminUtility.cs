using HealthCareApp.Models;

namespace HealthCareApp.Interfaces;

public interface IAdminUtility
{
    void AddSpecialty(Specialty specialty);
    List<Specialty> GetAllSpecialties();
    List<AuditLog> GetAuditLogs();
    decimal GetRevenueByDateRange(DateTime start, DateTime end);
}
