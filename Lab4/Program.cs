using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Plane
    {
        public string Type { get; set; }
        public int Carring { get; set; }
        public int Distance { get; set; }
        public int Wingspan { get; set; }
        public int RunLenght { get; set; }
        public string CompanyCode { get; set; }
    }

    class Helicopter
    {
        public string Type { get; set; }
        public int Carring { get; set; }
        public int MaximumHeight { get; set; }
        public int FlightRange { get; set; }
        public string CompanyCode { get; set; }
    }

    class Airline
    {
        public string Name { get; set; }
        public string OfficeLocation { get; set; }
        public string DateOfCreation { get; set; }
        public string CompanyCode { get; set; }
    }
}
