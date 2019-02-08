using System;
using System.Collections.Generic;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            for( int i=1; i<=255; i++){
                Console.WriteLine(i);
                }
            
            Console.WriteLine("****************");

            // for( int i=1; i<=100; i++){
            //     if( i%3==0 || i%5==0){
            //     Console.WriteLine(i);
            //     }
            // }

            // Console.WriteLine("****************");

            // for(int i=1; i<=100; i++){
            //     if(i%3==0 && i%5!=0){
            //         Console.WriteLine($"Fizz {i}");
            //     }
            //     else if( i%5==0 && i%3!=0){
            //         Console.WriteLine($"Buzz {i}");
            //     }
            //     else if(i%3==0 && i%5==0){
            //         Console.WriteLine($"FizzBuzz {i}");
            //     }
            // }
            
                //string[] myCars = new string[4] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
                        // // The 'Length' property tells us how many values are in the Array (4 in our example here). 
                        // // We can use this to determine where the loop ends: Length-1 is the index of the last value. 
                        // for (int idx = 0; idx < myCars.Length; idx++)
                        // {
                    //     Console.WriteLine("I own a {0}", myCars[idx]);
                    // }
            // List<string> bikes = new List<string>();
            //     //Use the Add function in a similar fashion to push
            //     bikes.Add("Kawasaki");
            //     bikes.Add("Triumph");
            //     bikes.Add("BMW");
            //     bikes.Add("Moto Guzzi");
            //     bikes.Add("Harley Davidson");
            //     bikes.Add("Suzuki");
            //     //Accessing a generic list value is the same as you would an array
            //     Console.WriteLine(bikes[2]); //Prints "BMW"
            //     Console.WriteLine("We currently know of {0} motorcycle manufacturers.", bikes.Count);


                // Console.WriteLine("The current manufacturers we have seen are:");
                // for (var idx = 0; idx < bikes.Count; idx++)
                // {
                // Console.WriteLine("-" + bikes[idx]);
                // }
                // // Insert a new item between a specific index
                // bikes.Insert(2, "Yamaha");
                // //Removal from Generic List
                // //Remove is a lot like Javascript array pop, but searches for a specified value
                // //In this case we are removing all manufacturers located in Japan
                // bikes.Remove("Suzuki");
                
                // bikes.RemoveAt(0); //RemoveAt has no return value however
                // //The updated list can then be iterated through using a foreach loop
                // Console.WriteLine("List of Non-Japanese Manufacturers:");
                // foreach (string manu in bikes)
                // {
                // Console.WriteLine("-" + manu);
                // }

                Dictionary<string,string> profile = new Dictionary<string,string>();
                    //Almost all the methods that exists with Lists are the same with Dictionaries
                    profile.Add("Name", "Speros");
                    profile.Add("Language", "PHP");
                    profile.Add("Location", "Greece");
                    Console.WriteLine("Instructor Profile");
                    Console.WriteLine("Name - " + profile["Name"]);
                    Console.WriteLine("From - " + profile["Location"]);
                    Console.WriteLine("Favorite Language - " + profile["Language"]);
        }
    }
}
