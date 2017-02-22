using Braintree;
using System;
using System.Text;
using System.Net.Mail;

namespace Application
{
    public class Utils
    {
        static BraintreeGateway paymentGateway;

        public static BraintreeGateway getPaymentGateway()
        {

            if (paymentGateway == null)
            {

                paymentGateway = new BraintreeGateway
                {
                    Environment = Braintree.Environment.SANDBOX,
                    MerchantId = Constant.BT_MERCHANT_ID,
                    PublicKey = Constant.BT_PUBLIC_KEY,
                    PrivateKey = Constant.BT_PRIVATE_KEY
                };
            }
            return paymentGateway;
        }

        public static bool sendEmail(string subject, string body, string email) {

            try {
                var myMessage = new SendGrid.SendGridMessage();
                myMessage.AddTo(email);
                myMessage.From = new MailAddress(Constant.EMAIL_FROM_ADDRESS, Constant.EMAIL_FROM_NAME);
                myMessage.Subject = subject;
                myMessage.Text = body;

                var transportWeb = new SendGrid.Web(Constant.SENDGRID_API_TOKEN);
                transportWeb.DeliverAsync(myMessage).Wait();

            } catch {
                return false;
            }

            return true;

        }

        public static DateTime getDateFromString(string date)
        {
            return DateTime.ParseExact(date, "yyyy-MM-dd",
                                           System.Globalization.CultureInfo.InvariantCulture);
        }

        public static double convertKMtoMile(double km)
        {
            if (km == 0)
                return 0;
            else
                return km / 1.60934;
        }


        public static String calculateTimeDifference(String timestamp)
        {
            DateTime datetime;
            datetime = Convert.ToDateTime(timestamp);
            String date;

            TimeSpan span = DateTime.Now.Subtract(datetime);
            if (span.Days == 0)
            {
                if (span.Hours == 0)
                {
                    date = span.Minutes.ToString() + "m ago";
                }
                else
                {
                    date = span.Hours.ToString() + "hr ago";
                }
            }
            else if (span.Days >= 365)
            {
                date = "Year ago";
            }

            else if (span.Days == 1)
            {
                date = "Yesterday";
            }
            else if (span.Days <= 6 && span.Days > 0)
            {
                date = datetime.DayOfWeek.ToString();
            }
            else
            {
                // Same as datetime.ToShortDateString();
                date = datetime.ToString("d");
            }

            return date;

        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }


    }
}
