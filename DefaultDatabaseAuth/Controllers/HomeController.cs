using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth1.Controllers {
  public class HomeController : Controller {
    [Authorize]
    public IActionResult Index() {
      return Content(User.Identity.Name);
    }
  }
}
