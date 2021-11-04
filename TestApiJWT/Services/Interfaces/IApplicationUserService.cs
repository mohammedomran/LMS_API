using System;
using System.Collections.Generic;
using TestApiJWT.Models;

namespace TestApiJWT.Services
{
    public interface IApplicationUserService
    {
        IEnumerable<ApplicationUser> GetApplicationUsers();
        IEnumerable<ApplicationUser> GetApplicationUsersByType(string type);
        ApplicationUser GetApplicationUser(int id);
        ApplicationUser UpdatelicationUser(ApplicationUser applicationUser);
        ApplicationUser AddApplicationUser(ApplicationUser applicationUser);
        ApplicationUser DeleteApplicationUser(string id);
        IEnumerable<ApplicationUser> SearchForUsers(string data);
        string GetCurrentUser();
    }
}
