using ExamUI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExamUI.Common
{
    public class HttpHelper
    {
        public static string HttpPostAsync(string url,object entity)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.PostAsync(url,
                new JsonContent(entity)).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            return result;
        }

        public static string HttpGetAsync(string url)
        {
            var httpClient = new HttpClient();
            var response =  httpClient.GetAsync(url).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            return result;
        }
    }
}
