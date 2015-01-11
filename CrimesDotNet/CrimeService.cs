using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CrimesDotNet
{
    public class CrimeService : ICrimeService
    {
        private CrimeWebCalls web = new CrimeWebCalls();

        public const string ENDPOINT = "http://data.police.uk/api";

        public List<CrimeDataset> GetAvailableDatasets()
        {
            string url = ENDPOINT + "/crimes-street-dates";
            string json = web.MakeHttpGetRequest(url);
            List<CrimeDataset> output = JsonConvert.DeserializeObject<List<CrimeDataset>>(json);
            return output;
        }

        public List<Crime> GetCrimes(double lat, double lng)
        {
            string url = String.Format(ENDPOINT + "/crimes-street/all-crime?lat={0}&lng={1}", lat, lng);
            List<Crime> output = web.RetrieveCrimes(url);
            return output;
        }

        public List<Crime> GetCrimes(double lat, double lng, string date)
        {
            string url = String.Format(ENDPOINT + "/crimes-street/all-crime?lat={0}&lng={1}&date={2}", lat, lng, date);
            List<Crime> output = web.RetrieveCrimes(url);
            return output;
        }

        public List<Crime> GetCrimes(double lat, double lng, CrimeDataset date)
        {
            List<Crime> output = GetCrimes(lat, lng, date.Date);
            return output;
        }

        public List<Crime> GetCrimes(Poly poly)
        {
            string url = String.Format(ENDPOINT + "/crimes-street/all-crime?poly={0}", poly.ToString());
            List<Crime> output = web.RetrieveCrimes(url);
            return output;
        }

        public List<Crime> GetCrimes(Poly poly, string date)
        {
            string url = String.Format(ENDPOINT + "/crimes-street/all-crime?poly={0}&date={1}", poly.ToString(), date);
            List<Crime> output = web.RetrieveCrimes(url);
            return output;
        }

        public List<Crime> GetCrimes(Poly poly, CrimeDataset date)
        {
            List<Crime> output = GetCrimes(poly, date.Date);
            return output;
        }
    }
}
