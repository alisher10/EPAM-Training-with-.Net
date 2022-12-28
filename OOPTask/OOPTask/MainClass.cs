namespace OOPTask {
    public class MainClass
    {
        public static void Main()
        {
            
            Bus bus= new Bus();

            bus.chassis = new Chassis(6, 1000, "SNBUS123");
            bus.transmission = new Transmission(4, "Mercedes Benz", "Low Floor Bus");
            bus.engine = new Engine(400, 12, "Diesel", "SN123123");
            bus.size = "Very long";

            Console.WriteLine($"{bus}");

            Car car = new Car();

            car.chassis = new Chassis(4, 500, "SNCAR123");
            car.transmission = new Transmission(5, "Ford", "Sport Car");
            car.engine = new Engine(300, 75, "Electrical", "sn1231231");
            car.seatsNumber = 2;

            Console.WriteLine($"{car}");

            Truck truck = new Truck();

            truck.chassis = new Chassis(12, 5000, "SNTRUCK123");
            truck.transmission = new Transmission(6, "Man", "Heavy Truck");
            truck.engine = new Engine(600, 12, "Diesel", "sn123123");
            truck.typeOfTracking = "GPS";

            Console.WriteLine($"{truck}");

            Scooter scooter = new Scooter();

            scooter.chassis = new Chassis(2, 100, "SNSCOOTER123");
            scooter.transmission = new Transmission(3, "Xiaomi", "Lightweight");
            scooter.engine = new Engine(50, 20, "Electrical", "SN121312");
            scooter.driversLicenseCategory = "A";

            Console.WriteLine($"{scooter}");

            
        }
    }
}

