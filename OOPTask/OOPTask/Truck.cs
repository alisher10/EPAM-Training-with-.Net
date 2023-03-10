namespace OOPTask
{
    public class Truck
    {
        public Chassis chassis { get; set; }
        public Engine engine { get; set; }
        public Transmission transmission { get; set; }

        public string typeOfTracking { get; set; }

        public override string ToString()
        {
            return $"Truck Technical Characteristics\n" +
                   $" Info about chassis:\n" +
                   $" Wheels number is {chassis.WheelsNumber}\n" +
                   $" Permissible load is {chassis.PermissibleLoad}\n" +
                   $" Chassis number is {chassis.ChassisNumber}\n\n" +
                   $" Info about transmission:\n" +
                   $" Gears number {transmission.NumberOfGears}\n" +
                   $" Manufacturer {transmission.Manufacturer}\n" +
                   $" Type {transmission.Type}\n\n" +
                   $" Info about engine:\n" +
                   $" Power of engine {engine.Power}\n" +
                   $" Volume is {engine.Volume}\n" +
                   $" Type of engine {engine.Type}\n" +
                   $" Serial Number {engine.SerialNumber}\n" +
                   $" Type of tracking via satellite {typeOfTracking}\n\n";
        }
    }
}
