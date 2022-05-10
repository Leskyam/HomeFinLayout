using Microsoft.AspNetCore.Mvc;

namespace HomeFin3WAPI.Controllers
{
    public class UserController : Controller
    {
        public HomeFinCommonTypes.User Get()
        {
            return new HomeFinCommonTypes.User() { FirstName = "Osnielky", LastName = "Roque Paz", MiddleName = String.Empty };
        }
    }
}
