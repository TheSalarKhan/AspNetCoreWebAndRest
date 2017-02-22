using Application.Models;

namespace Application.Services {

    /**
        This service is designed to enable ApplicationDbContext injection to
        any service that extends it.
    */
    public abstract class BaseService : Injectable {
        public BaseService(ApplicationDbContext context) : base(context) { }
    }
}