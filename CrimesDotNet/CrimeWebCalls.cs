using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace CrimesDotNet
{
    internal class CrimeWebCalls
    {
        public string MakeHttpGetRequest(string url)
        {
            string output;

            using (WebClient client = new WebClient())
            {
                output = client.DownloadString(url);
            }

            return output;
        }

        public List<Crime> RetrieveCrimes(string url)
        {
            string json = MakeHttpGetRequest(url);
            List<Crime> output = JsonConvert.DeserializeObject<List<Crime>>(json);
            return output;
        }
    }
}
