namespace OOPTask
{
    public class Engine
    {
        public int Power { get; }

        public int Volume { get; }

        public string Type { get; }

        public string SerialNumber { get; }

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
                Type = "Default";
                SerialNumber = "SNDefault";
            }
        }

    }
}
