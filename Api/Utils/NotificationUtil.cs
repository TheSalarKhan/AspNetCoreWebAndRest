using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Application
{
	public static class NotificationUtil
	{

		public static string SendNotification(string message, string deviceId = "All")
		{
			string sResponseFromServer = "";

			try
			{
				var applicationID = Constant.FCM_SERVER_KEY;
				var senderId = Constant.FCM_SENDER_KEY;
				var uri = "https://fcm.googleapis.com/fcm/send";
				
				//WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
				//tRequest.Method = "post";
				//tRequest.ContentType = "application/json";
				var data = new
				{
					to = deviceId,
					priority = "high",
					notification = new
					{
						body = message,
						title = Constant.FCM_TITLE,
						sound= "default"

                    }
				};

				string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(data);

				//var serializer = new JavaScriptSerializer();
				//var json = serializer.Serialize(data);
				//Byte[] byteArray = Encoding.UTF8.GetBytes(json);

				//tRequest.Headers["Authorization"] = string.Format("key={0}", applicationID);
				//tRequest.Headers["Sender"] = string.Format("id={0}", senderId);

				
				//tRequest.ContentLength = byteArray.Length;

				using(var client = new HttpClient()) {
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
					client.DefaultRequestHeaders.Add("Authorization",string.Format("key={0}", applicationID));
					client.DefaultRequestHeaders.Add("Sender",string.Format("id={0}", senderId));

					var response = client.PostAsync(uri,new StringContent(jsonString,Encoding.UTF8,"application/json"));
					response.Start();
					response.Wait();

					var responseMessage = response.Result.Content.ReadAsStringAsync();
					responseMessage.Start();
					responseMessage.Wait();

					sResponseFromServer = responseMessage.Result;

				}


				

				// using (Stream dataStream = tRequest.GetRequestStream())
				// {
				// 	dataStream.Write(byteArray, 0, byteArray.Length);

				// 	using (WebResponse tResponse = tRequest.GetResponse())
				// 	{
				// 		using (Stream dataStreamResponse = tResponse.GetResponseStream())
				// 		{
				// 			using (StreamReader tReader = new StreamReader(dataStreamResponse))
				// 			{
				// 				sResponseFromServer = tReader.ReadToEnd();

				// 			}
				// 		}
				// 	}
				// }
			}

			catch (Exception ex)
			{
				Console.Write(ex.Message);
			}
			return sResponseFromServer;
		}
	}
}
