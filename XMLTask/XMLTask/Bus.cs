using System.Xml.Serialization;

namespace XmlTask
{
    [XmlInclude(typeof(Bus))]

    [Serializable]
    public class Bus : Vehicle
    {
        public Chassis chassis { get; set; }
        public Engine engine { get; set; }
        public Transmission transmission { get; set; }
    }
}
