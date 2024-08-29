using workshop.wwwapi.Models;

namespace workshop.wwwapi.Data
{
    public static class VehicleData
    {
        private static List<Car> _cars = new List<Car>()
        {
            new Car(){Id = 100, Make = "Volkswagen", Model = "Camper"}
        };

        public static List<Car> GetVehicles()
        {
            return _cars;
        }

        public static Car AddVehicle(Car entity)
        {
            // Check if exists
            // Find a suitable id
            _cars.Add(entity);

            return entity;
        }
    }
}
