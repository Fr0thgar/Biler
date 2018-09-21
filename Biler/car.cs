using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biler
{
    class car
    {
        private string brand;
        private string model;
        private int year;
        private bool benzin;
        private string color;
        private string licenseplate;

        public car(String brand, String model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public string Licenseplate
        {
            get { return licenseplate; }
            set { licenseplate = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool Benzin
        {
            get { return benzin; }
        }
        
        public string Model 
        {
            get { return model; }
        }
        
        public string Brand
        {
            get { return brand; }
        }

        public int Year
        {
            get { return year; }
        }

    }
}
