using System.Xml.Serialization;

namespace XmlTask
{
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Scooter))]

    [Serializable]

    public abstract class Vehicle
    {
    }
}
