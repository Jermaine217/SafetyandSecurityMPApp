using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsAPI.Models
{
    public class CarDetail
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Model { get; set; }
        public string LicencePlate { get; set; }
        public string YearModel { get; set; }
        public string Colour { get; set; }
        



    }
}
