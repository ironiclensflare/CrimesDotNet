using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CrimesDotNet
{
    public class CrimeDataset
    {
        [JsonProperty("date")]
        public string Date { get; set; }
    }
}
