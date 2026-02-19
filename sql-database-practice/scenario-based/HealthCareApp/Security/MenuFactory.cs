using HealthCareApp.Exceptions;
using HealthCareApp.Interfaces;
using HealthCareApp.Menus;

namespace HealthCareApp.Security;

public static class MenuFactory
{
    public static IMenu GetMenu(UserRole role)
    {
        return role switch
        {
            UserRole.ADMIN => new AdminMenu(),
            UserRole.DOCTOR => new DoctorMenu(),
            UserRole.RECEPTIONIST => new ReceptionistMenu(),
            _ => throw new UnauthorizedAppException("Access denied.")
        };
    }
}
