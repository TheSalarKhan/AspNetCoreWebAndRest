
namespace Application.Entity
{
    public class ChangePassword : UserRequest
    {
        public string password { get; set; }
		public string newPassword { get; set; }
    }
}