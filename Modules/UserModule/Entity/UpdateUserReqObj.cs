﻿
namespace Application.Entity
{
    public class UpdateUserReqObj
    {
        public int UserId { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}