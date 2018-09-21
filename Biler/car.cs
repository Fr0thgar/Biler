using System;
using System.Text;

namespace Biler
{
    class Car
    {
        private string brand;
        private string model;
        private int year;
        private bool benzin;
        private string color;
        private string licenseplate;

        public Car(String brand, String model, int year, string color, string licenseplate, bool benzin) 
            : this(brand, model, year)
        {
            this.color = color;
            this.benzin = benzin;
            this.licenseplate = licenseplate;
        }

        public Car(String brand, String model, int year)
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

        public void Gear()
        {

        }

//        public override string ToString()
//        {
//            StringBuilder sb =new StringBuilder();
//            sb.AppendLine("+-------------------+");
//            sb.Append("|Brand:");
//            sb.Append("\t");
//            sb.Append(Brand);
//            return sb.ToString();
//        }
                public override string ToString()
        {
            string Benzin = null;
            if (this.benzin) Benzin = "Benzin";

            else Benzin = "Diesel, other brands are available";
           return $"+------------------------------------------------------+\n" +
                   $"|Brand: \t{brand,-39}| \n" +
                   $"|Model: \t{model,-39}| \n" +
                   $"|Year: \t\t{year,-39}|\n" +
                   $"|Benzin: \t{Benzin,-39}| \n" +
                   $"|Color: \t{color,-39}| \n" +
                   $"|Licenseplate: \t{licenseplate,-39}| \n" +
                   $"+------------------------------------------------------+";
        }
        
    }
}
