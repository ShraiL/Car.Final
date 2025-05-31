// LashaMurgvaLominadzeShraieri.Final.Models/Car.cs
namespace LashaMurgvaLominadzeShraieri.Final.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
        public int Speed { get; set; }

        public Car(string model, double weight, int speed)
        {
            Model = model;
            Weight = weight;
            Speed = speed;
        }

        public Car() { } // Default constructor for database retrieval

        public override string ToString()
        {
            return $"{ID} {Model}"; // Display ID and Model in the ListBox
        }
    }
}
