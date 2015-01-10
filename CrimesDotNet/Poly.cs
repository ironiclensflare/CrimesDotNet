using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimesDotNet
{
    public class Poly
    {
        public Poly(LatLng[] points)
        {
            Points = points;
        }

        public Poly()
        {

        }

        public LatLng[] Points { get; set; }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < Points.Length; i++)
            {
                output += String.Format("{0},{1}", Points[i].Lat, Points[i].Lng);

                if (i < Points.Length - 1)
                {
                    output += ":";
                }
            }

            return output;
        }
    }

    public class LatLng
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}
