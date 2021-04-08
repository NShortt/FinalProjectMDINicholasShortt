using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectMDINicholasShortt
{
    /// <summary>
    /// A class to hold the information on a car, and give a small summary
    /// </summary>
    class Car
    {
        // Static private variable to hold the number of cars.
        private static int carCount = 0;
        // Private variable to hold the car's identification number.
        private int carId = 0;
        // Private variable to hold the car's make.
        private string carMake = String.Empty;
        // Private variable to hold the customer's model.
        private string carModel = String.Empty;
        // Private variable to hold the customer's year.
        private int carYear = 0;
        // Private variable to hold the customer's price. 
        private double carPrice = 0.0;
        // Private variable to hold the car's status.
        private bool carNewStatus = false;

        /// <summary>
        /// Constructor - Default - creates a new car object.
        /// </summary>
        public Car()
        {
            carCount += 1;
            carId = carCount;
        }

        /// <summary>
        /// Constructor - Parameterized - creates a new car object
        /// </summary>
        /// <param name="make">Car's title</param>
        /// <param name="model">Car's first name</param>
        /// <param name="year">Car's last name</param>
        /// <param name="price">Car's price</param>
        /// <param name="newStatus">true if a car is a new car</param>
        public Car(string make, string model, int year, double price, bool newStatus) : this()
        {
            // Set all of the instance variables within this class using the values
            // passed into this constructor.
            carMake = make;
            carModel = model;
            carYear = year;
            carPrice = price;
            carNewStatus = newStatus;
        }

        /// <summary>
        /// Count ReadOnly Property - Gets the number of cars that have been instantiated/created
        /// </summary>
        public int Count
        {
            get
            {
                return carCount;
            }
        }

        /// <summary>
        /// IdentificationNumber ReadOnly Property - Gets a specific cars' identification number
        /// </summary>
        public int Id
        {
            get
            {
                return carId;
            }
        }

        /// <summary>
        /// NewStatus Property - >Gets and Sets the New status of a car
        /// </summary>
        public bool NewStatus
        {
            get
            {
                return carNewStatus;
            }
            set
            {
                carNewStatus = value;
            }
        }

        /// <summary>
        /// Make property - Gets and Sets the make of a car
        /// </summary>
        public string Make
        {
            get
            {
                return carMake;
            }
            set
            {
                carMake = value;
            }
        }

        /// <summary>
        /// Model property - Gets and Sets the model of a car
        /// </summary>
        public string Model
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }

        /// <summary>
        /// Year property - Gets and Sets the year of a car
        /// </summary>
        public int Year
        {
            get
            {
                return carYear;
            }
            set
            {
                carYear = value;
            }
        }

        /// <summary>
        /// Price property - Gets and Sets the price of a car
        /// </summary>
        public double Price
        {
            get
            {
                return carPrice;
            }
            set
            {
                carPrice = value;
            }
        }

        /// <summary>
        /// GetSummary is a function that a summary based on the private properties within the class scope
        /// </summary>
        /// <returns>string describing the car</returns>
        public string GetSummary()
        {
            return "This is a " + (carNewStatus ? "new " : "used ") + carYear + " " + carMake + " " + carModel + " for " + carPrice.ToString("c");
        }
    }
}
