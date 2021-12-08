using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        public string Model { get; }

        public string Color { get; }
        public string Mark { get; }
        public List<Car> Cars { get; }

        public Car(List<Car> cars)
        {
            Cars = cars;
        }

        public Car(string model, string color, string mark)
        {
            Model = model;
            Color = color;
            Mark = mark;
        }
        /// <summary>
        /// Cette classe est utilisée pour enlever le dernière objet "Car" ajouter à List<Car>.
        /// </summary>
        /// <param name="cars"></param>
        public void RemoveLastCarAdded(List<Car> cars)
        {
            int carToRemove = cars.Count();
            cars.Remove(cars[carToRemove - 1]);
        }
        /// <summary>
        /// Cette classe est utilisé pour retourner une list<Car> contenant une couleur 
        /// spicifique passer en paramètre.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public List<Car> GetallCarWithThatColor(string color)
        {
            foreach (Car car in Cars)
            {
                if (car.Color.ToString() == color)
                {
                    Cars.Add(car);
                }
            }
            return Cars;
        }
    }
}
