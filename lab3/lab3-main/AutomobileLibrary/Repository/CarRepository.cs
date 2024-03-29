﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.DataAccess;
using AutomobileLibrary.Repository;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(int carId) => CarDAO.Instance.Remove(carId);

        public Car GetCarById(int carId) => CarDAO.Instance.GetCarByID(carId);


        public IEnumerable<Car> GetCars() => CarDAO.Instance.GetCarList();


        public void InsertCar(Car car) => CarDAO.Instance.AddNew(car);


        public void UpdateCar(Car car) => CarDAO.Instance.Update(car);
    }
}
