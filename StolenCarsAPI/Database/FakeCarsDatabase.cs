using CarsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CarsAPI.Database
{
    public class FakeCarsDatabase
    {
        
        public List<CarDetail> CardDetails  { get; set; } 

        public FakeCarsDatabase()
        {
            PopulateDatabase(); 
        }

        public string GetCardDetailByLicense(string licencePlate)
        {
            var carDetail = CardDetails.Where(x => x.LicencePlate == licencePlate).FirstOrDefault();

            return string.Format("The FullInformation of the Cars {0} {1} {2} {3} ", carDetail.LicencePlate, carDetail.Model, carDetail.Colour, carDetail.YearModel);
        }

        public List<string> GetCardDetailByMake(string make)
        {
            var carDetails = CardDetails.Where(x => x.Model == make).ToList();

            var returnStringList = new List<string>();

            foreach (var carDetail in carDetails)
                returnStringList.Add(string.Format("The FullInformation of the Cars {0} {1} {2} {3} ", carDetail.LicencePlate, carDetail.Model, carDetail.Colour, carDetail.YearModel));

            return returnStringList;
        }

        public List<string> GetCardDetailById(int id)
        {
            var carDetails = CardDetails.Where(x => x.Id ==id).ToList();

            var returnStringList = new List<string>();

            foreach (var carDetail in carDetails)
                returnStringList.Add(string.Format("The FullInformation of the Cars {0} {1} {2} {3} ", carDetail.LicencePlate, carDetail.Model, carDetail.Colour, carDetail.YearModel));

            return returnStringList;
        }

        public void PopulateDatabase()
        {
            CardDetails = new List<CarDetail>();

            var carDetail = new CarDetail()
            {
                Id = 1,
                Model = "SkyLine",
                LicencePlate = "CA568845",
                YearModel = "2011",
                Colour = "Red"
            };

            CardDetails.Add(carDetail);

            carDetail = new CarDetail()
            {
                Id = 1,
                Model = "Toyota",
                LicencePlate = "CA554741",
                YearModel = "2009",
                Colour = "Silver"
            };

            CardDetails.Add(carDetail);

            carDetail = new CarDetail()
            {
                Id = 1,
                Model = "VW",
                LicencePlate = "CA683547",
                YearModel = "2014",
                Colour = "REEN"
            };

            CardDetails.Add(carDetail);

        }

    }
}
