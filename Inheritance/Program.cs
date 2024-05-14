using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal-Done
            // give this class 4 members that all Animals have in common-Done


            // Create a class Bird-Done
            // give this class 4 members that are specific to Bird-Done
            // Set this class to inherit from your Animal Class-Done

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile-Done
            // Set this class to inherit from your Animal Class-Done


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Bird1 = new Bird()
            {
                Size = "Small",
                Type = "Eagle",
                CanFly = true,
                Color = "Black",
                Age = 2,
                LegCount = 2
            };
            Console.WriteLine($"Here are some details regarding your bird:\nSize: {Bird1.Size}\nType: {Bird1.Type}\nCan it fly? {Bird1.CanFly}\nColor: {Bird1.Color}\nAge: {Bird1.Age}\nLeg Count: {Bird1.LegCount}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var snake = new Reptile()
            {
                Type = "Anaconda",
                IsPoisonus = true,
                Color= "Dark grey",
                Length = "19.2in",
                Age = 5,
                LandSeaAir = "Land",
                LegCount = 0,
                IsNocturnal = false
            };

            Console.WriteLine($"Here are some details regarding your reptile:\nType: {snake.Type} \nIs it poisonus? {snake.IsPoisonus} \nColor: {snake.Color} \nLength: {snake.Length}\nDoes it live on land, in the sea, or in the sky? {snake.LandSeaAir}\nIs it nocturnal? {snake.IsNocturnal}\nAge: {snake.Age}\nLeg Count: {snake.LegCount}");
        }
    }
}
