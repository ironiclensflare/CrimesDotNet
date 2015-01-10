using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimesDotNet
{
    interface ICrimeService
    {
        List<CrimeDataset> GetAvailableDatasets();
        List<Crime> GetCrimes(double lat, double lng);
        List<Crime> GetCrimes(double lat, double lng, string date);
        List<Crime> GetCrimes(double lat, double lng, CrimeDataset date);
        List<Crime> GetCrimes(Poly poly);
        List<Crime> GetCrimes(Poly poly, string date);
        List<Crime> GetCrimes(Poly poly, CrimeDataset date);
    }
}
