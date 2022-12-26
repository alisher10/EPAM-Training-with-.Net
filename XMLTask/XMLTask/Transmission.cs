namespace XmlTask
{
    public class Transmission
    {
        public int NumberOfGears { get; set;  }
        public string Manufacturer { get; set;  }
        public string Type { get; set; }
        
        public Transmission() { }


        public Transmission(int numberOfGears, string manufacturer, string type) {

            if (numberOfGears > 0 && manufacturer.Length > 0 && type.Length > 0)
            {
                NumberOfGears = numberOfGears;
                Manufacturer = manufacturer;
                Type = type;
            }
            else { 
                NumberOfGears = 0;
                Manufacturer = "unknown";
                Type = "unknown";
            }
        }
    }
}
