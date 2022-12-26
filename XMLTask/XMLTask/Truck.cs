using System.Xml.Serialization;

namespace XmlTask
{
    [XmlInclude(typeof(Truck))]

    [Serializable]
    public class Truck : Vehicle
    {
        public Chassis chassis { get; set; }
        public Engine engine { get; set; }
        public Transmission transmission { get; set; }
    }
}
