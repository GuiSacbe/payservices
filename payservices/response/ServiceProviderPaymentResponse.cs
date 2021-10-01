using System;
namespace payservices.response
{
    public class ServiceProviderPaymentResponse
    {
        public string authorizationNumber { get; set; }
        public string description { get; set; }
        public string responseCode { get; set; }
    }
}
