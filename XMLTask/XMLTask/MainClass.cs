using System.Xml.Serialization;

namespace XmlTask
{
    class MainClass
    {
        static void Main()
        {
            SerializeListToXmlFile();
        }

        private static void SerializeListToXmlFile()
        {

            var vehicleList = new List<Vehicle>()
            {
                new Bus() {
                    chassis = new Chassis(6, 1000, "SNBUS123"),
                    engine = new Engine(400, 12, "diesel", "sn123123"),
                    transmission = new Transmission(4, "Mercedes Benz", "Low floor bus"),
                },

                new Car() {
                    chassis = new Chassis(4, 500, "SNCAR123"),
                    engine = new Engine(300, 75, "electrical", "sn123123"),
                    transmission = new Transmission(5, "Ford", "Sport Car"),
                },

                new Truck() {
                    chassis = new Chassis(12, 5000, "SNTRUCK123"),
                    engine = new Engine(600, 12, "diesel", "sn123123"),
                    transmission = new Transmission(6, "Man", "Heavy Truck"),
                },

                new Scooter() {
                    chassis = new Chassis(2, 100, "SNSCOOTER123"),
                    engine = new Engine(50, 20, "electrical", "sn123123"),
                    transmission = new Transmission(3, "Xiaomi", "Lightweight"),
                },
            };

            var xmlSerializer = new XmlSerializer(typeof(List<Vehicle>), new Type[] { typeof(Vehicle) });
            
            var relativePath = @"sample3000.xml";
            var baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var appStorageFolder = Path.Combine(baseFolder, "");
            var fullPath = Path.Combine(appStorageFolder, relativePath);

            using (var writer = new StreamWriter(fullPath))
            {
                xmlSerializer.Serialize(writer, vehicleList);
            }
        }

    }

}