using System;
namespace payservices.response
{
    public class ProviderResponse
    {
        public decimal commisionAmount { get; set; }
        public string currency { get; set; }
        public string mask { get; set; }
        public string maxLenTypeData { get; set; }
        public string minLenTypeData { get; set; }
        public string name { get; set; }
        public int providerId { get; set; }
        public string providerType { get; set; }
        public string typeData { get; set; }
        public string validAmounts { get; set; }
    }
}
