using Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers {

    /**
        This controller is designed to enable ApplicationDbContext injection to
        any controllers that extends it.
    */
    public abstract class BaseController : Controller {
        protected readonly ApplicationDbContext _db;

        public BaseController(ApplicationDbContext context) {
            _db = context;
        }
    }
}
