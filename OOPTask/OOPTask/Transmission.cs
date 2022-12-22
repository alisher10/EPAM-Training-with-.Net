namespace OOPTask
{
    public class Transmission
    {
        public int NumberOfGears { get; }

        public string Manufacturer { get; }

        public string Type { get; }

        public Transmission(int numberOfGears, string manufacturer, string type) {

            if (numberOfGears > 0 && manufacturer.Length > 0 && type.Length > 0) {
                NumberOfGears= numberOfGears;
                Manufacturer= manufacturer; 
                Type= type; 
            }
            else {
                NumberOfGears = 0;
                Manufacturer = "Default";
                Type = "Default";
            }
        }
    }
}
