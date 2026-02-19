using HealthCareApp.Models;

namespace HealthCareApp.Interfaces;

public interface IAppointmentUtility
{
    void BookAppointment(Appointment appointment);
    void UpdateAppointment(Appointment appointment);
    void CancelAppointment(int id);
    List<Appointment> GetAppointmentsByDate(DateTime date);
}
