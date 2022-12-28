namespace XmlTask
{
    public class Chassis
    {
        public int WheelsNumber { get; set; }
        public int PermissibleLoad { get; set; }
        public string ChassisNumber { get; set; }

        public Chassis() { }

        public Chassis(int wheelsNumber, int permissibleLoad, string chassisNumber)
        {

            if (wheelsNumber > 0 && permissibleLoad > 0 && chassisNumber.Length > 0)
            {
                WheelsNumber = wheelsNumber;
                PermissibleLoad = permissibleLoad;
                ChassisNumber = chassisNumber;
            }
            else
            {
                WheelsNumber = 0;
                PermissibleLoad = 0;
                ChassisNumber = "unknown";
            }
        }
    }

}
