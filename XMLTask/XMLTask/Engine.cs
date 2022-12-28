namespace XmlTask
{
    public class Engine 
    {
        public int Power { get; set; }
        public int Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

        public Engine() { }

        public Engine(int power, int volume, string type, string serialNumber) {

            if (power > 0 && volume > 0 && type.Length > 0 && serialNumber.Length > 0)
            {
                Power = power;
                Volume = volume;
                Type = type;
                SerialNumber = serialNumber;
            }
            else {
                Power = 0;
                Volume = 0;
                Type= "unknown";
                SerialNumber = "unknown";
            }
        }

    }
}