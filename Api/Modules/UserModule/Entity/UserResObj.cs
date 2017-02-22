
using Application.Models;
using System.Text;

namespace Application.Entity
{
	public class UserResObj
	{
		public int ID { get; set; }
		public string phone { get; set; }
		public string email { get; set; }
        public string name { get; set; }
        public string imageURL { get; set; }
        public int emailVerified { get; set; }
		public string timestamp { get; set; }
		//public int hasCreditCard { get; set; }
		public BaseResponse response { get; set; }

		public UserResObj()
		{
			response = new BaseResponse();
		}

		public void fillObject(Users obj)
		{

			ID = obj.Id;
			emailVerified = (int)obj.EmailVerified;
			phone = obj.Phone;
			email = obj.Email;
			timestamp = obj.CreatedAt.ToString();
            name = obj.Name;
			imageURL = Encoding.UTF8.GetString(obj.ProfileImage);
			

          
		}


	}


}