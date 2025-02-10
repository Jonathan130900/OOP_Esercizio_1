using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Esercizio_1
{
    public class Vehicle
    {
        public string ModelName { get; set; }
        public string MovieName { get; set; }
        public string ProductionCompany { get; set; }
        public int StartProductionYear { get; set; }
        public int EndProductionYear { get; set; }
        public string Designer { get; set; }

        public Vehicle(string modelname, string moviename, string productioncompany, int startproductionyear, int endproductionyear, string designer)
        {
            this.ModelName = modelname;
            this.MovieName = moviename;
            this.ProductionCompany = productioncompany;
            this.StartProductionYear = startproductionyear;
            this.EndProductionYear = endproductionyear;
            this.Designer = designer;
        }

        public void showVehicleData()
        {
            Console.WriteLine("The " + ModelName + " was a car famously known for the movie trilogy " + MovieName + " created by the " + ProductionCompany + " between " + StartProductionYear + " & " + EndProductionYear + " and designed by the amazing " + Designer);
        }
    }
}
