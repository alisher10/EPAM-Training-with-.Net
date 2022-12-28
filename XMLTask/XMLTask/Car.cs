using System.Xml.Serialization;

namespace XmlTask
{
    [XmlInclude(typeof(Car))]

    [Serializable]
    public class Car : Vehicle
    {
        public Chassis chassis { get; set; }
        public Engine engine { get; set; }
        public Transmission transmission { get; set; }
        public int seatsNumber { get; set; }

    }
}
