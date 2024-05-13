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
                size = "small",
                type = "Eagle",
                canFly = true,
                color = "Black",
                age = 2,
                legCount = 2
            };
            Console.WriteLine($"Here are some details regarding your bird:\nSize: {Bird1.size}\nType: {Bird1.type}\nCan it fly? {Bird1.canFly}\nColor: {Bird1.color}\nAge: {Bird1.age}\nLeg Count: {Bird1.legCount}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var snake = new Reptile()
            {
                age = 5,
                landSeaAir = "Land",
                legCount = 0,
                isNocturnal = false
            };

            Console.WriteLine($"Here are some details regarding your reptile:\nDoes it live on land, in the sea, or in the sky? {snake.landSeaAir}\nIs it nocturnal? {snake.isNocturnal}\nAge: {snake.age}\nLeg Count: {snake.legCount}");
        }
    }
}
