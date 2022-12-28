using System.Xml.Serialization;

namespace XmlTask
{
    [XmlInclude(typeof(Scooter))]

    [Serializable]
    public class Scooter : Vehicle
    {
        public Chassis chassis { get; set; }
        public Engine engine { get; set; }
        public Transmission transmission { get; set; }
        public string driversLicenseCategory { get; set; }

    }
}
