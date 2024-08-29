﻿using workshop.wwwapi.Models;

namespace workshop.wwwapi.Data
{
    public static class CarData
    {
        private static List<Car> _cars = new List<Car>();

        public static List<Car> GetCars()
        {
            return _cars;
        }

        public static Car AddCar(Car entity)
        {
            // Check if exists
            // Find a suitable id
            _cars.Add(entity);

            return entity;
        }
    }
}
