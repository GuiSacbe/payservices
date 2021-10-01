using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace payservices.Util
{
    public class ArcusClient<T> where T : class
    {
        private string baseURL = "http://192.168.0.104:5213/";

        public async Task<T> GetAsync(string endPoint)
        {
            try
            {
                string json = "";
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(baseURL);
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await httpClient.GetAsync(endPoint);
                if (res.IsSuccessStatusCode)
                {
                    json = res.Content.ReadAsStringAsync().Result;
                }

                T taskModels = JsonConvert.DeserializeObject<T>(json);
                return taskModels;
            }
            catch
            {
                throw;
            }
        }
        public async Task<T> PostAsync(Object t, string endPoint)
        {
            try
            {
                string json = JsonConvert.SerializeObject(t);
                string result = "";
                T objResult = null;
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(baseURL);
                httpClient.DefaultRequestHeaders.Clear();
                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage res = await httpClient.PostAsync(endPoint, httpContent);
                result = res.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrEmpty(result))
                {
                    objResult = JsonConvert.DeserializeObject<T>(result);
                }
                return objResult;
            }
            catch
            {
                throw;
            }
        }
    }
}
