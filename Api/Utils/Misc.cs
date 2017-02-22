namespace Application {
    public class Misc {

        public const int RESPONSE_OK = 200;
        public const int RESPONSE_BAD_REQUEST = 400;

        public const string NULL_REQUEST = "The request is empty.";
        public static Application.Entity.BaseResponse getResponse(int responseCode, string responseMessage) {
            return new Application.Entity.BaseResponse()
            {
                status=responseCode,
                developerMessage=responseMessage
            };
        }
    }
}
