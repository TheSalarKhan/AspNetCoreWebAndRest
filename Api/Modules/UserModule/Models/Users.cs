using System;
using System.Collections.Generic;

namespace Application.Models
{
    public class Users : BaseModel
    {
        public Users()
        {
            
        }

        public string Phone { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int EmailVerified { get; set; }

        public string TokenActivate { get; set; }
        public string TokenForgetpw { get; set; }
        public string PushId { get; set; }
        
        // virtual is used so that EF converts this data type to
        // varbinary
        public virtual byte[] ProfileImage { get; set; }

        public int UserStatus { get; set; }


    }
}
