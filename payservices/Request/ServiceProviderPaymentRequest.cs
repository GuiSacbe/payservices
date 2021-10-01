using System;
namespace payservices.Request
{
    public class ServiceProviderPaymentRequest
    {
        public int accountId { get; set; }
        public int paymentAmount { get; set; }
        public string paymentCurrency { get; set; }
        public string providerAccount { get; set; }
        public string providerCaptureLine { get; set; }
        public int providerId { get; set; }
    }
}
