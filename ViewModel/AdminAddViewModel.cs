using GarageProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageProject.ViewModel
{
    public class AdminAddViewModel
    {
        public IEnumerable<CarServicesDb> AddServiceTypes { get; set; }
        public IEnumerable<CarStyleDb> AddCarStyle { get; set; }
        public IEnumerable<CarBrandDb> AddCarBrand { get; set; }
    }
}