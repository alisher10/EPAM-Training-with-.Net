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
                new Bus {
                    chassis = new Chassis {
                        WheelsNumber = 6,
                        PermissibleLoad = 1000,
                        ChassisNumber = "SNBUS123",
                    }, 
                    engine = new Engine
                    {
                        Power = 400,
                        Volume = 12,
                        Type = "diesel",
                        SerialNumber = "sn12313213"
                    },
                    transmission = new Transmission {
                        NumberOfGears = 4,
                        Manufacturer = "Mercedes Benz",
                        Type = "Low floor bus"
                    },
                },

                new Car {
                    chassis = new Chassis
                    {
                        WheelsNumber = 4,
                        PermissibleLoad = 500,
                        ChassisNumber = "SNCAR123"
                    },
                    transmission = new Transmission
                    {
                        NumberOfGears = 5,
                        Manufacturer = "Ford",
                        Type = "Sport Car"
                    },
                    engine = new Engine
                    {
                        Power = 300,
                        Volume = 75,
                        Type = "Electrical",
                        SerialNumber = "sn12313213"
                    },
                },
                
                new Truck {
                    chassis = new Chassis
                    {
                        WheelsNumber = 12,
                        PermissibleLoad = 5000,
                        ChassisNumber = "SNTRUCK123"
                    },
                    transmission = new Transmission
                    {
                        NumberOfGears = 6,
                        Manufacturer = "MAN",
                        Type = "Heavy truck"
                    },
                    engine = new Engine
                    {
                        Power = 600,
                        Volume = 12,
                        Type = "Diesel",
                        SerialNumber = "sn12313213"
                    },
                },

                new Scooter {
                    chassis = new Chassis
                    {
                        WheelsNumber = 2,
                        PermissibleLoad = 100,
                        ChassisNumber = "SNSCOOTER123"
                    },
                    transmission = new Transmission
                    {
                        NumberOfGears = 3,
                        Manufacturer = "Xiaomi",
                        Type = "Lightweight"
                    },
                    engine = new Engine
                    {
                        Power = 50,
                        Volume = 20,
                        Type = "Electrical",
                        SerialNumber = "sn12313213"
                    },
                },
            };

            var xmlSerializer = new XmlSerializer(typeof(List<Vehicle>), new Type[] { typeof(Vehicle) });
            
            var relativePath = @"sample.xml";
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