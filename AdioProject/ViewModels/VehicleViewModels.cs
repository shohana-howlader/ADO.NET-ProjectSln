using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdioProject.ViewModels
{
    public class VehicleViewModels
    {
        public int VehicleId { get; set; }
        public string VehicleCode { get; set; }
        public string VehicleName { get; set; }
        public DateTime LaunchDate { get; set; }
        public string EngineType { get; set; }
        public bool IsAvailable { get; set; }
        public int TotalModelWithPrice { get; set; }
        public string CategoryTitle { get; set; }
        public string ImagePath { get; set; }
    }
   
}
