using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Dodge";
            car1.Model = "Neon";
            car1.VIN = "VIN-A1";

            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Equinox";
            car2.VIN = "VIN-A2";

            Book b1 = new Book();
            b1.Author = "Charlie Cuddy";
            b1.Title = "Learning .NET";
            b1.ISBN = "0-000-00000-0";
            */




            /* OLD STYLE... allowed you to add anything to the collection...
               so if searching for car.Make and their was a book in the collection
               there was not a big issue... can remove it but still not ideal.
            */
            /*
            //ArrayLists are dynamically sized, 
            //cool features like sorting, remove items
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */



            // ##### Probably the MOST POPULAR form of COLLECTIONS ###### 

            /*
            // List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            // myList.Add(b1);  won't even allow us to add a book to the car list

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
            }
            */





            /*
            // ##### DICTIONARIES are another popular collection however
            // TKey is unique to each entry, like the work you look up
            // TValue is the definition... any data type... written as....
            // Dictionary<TKey, TValue>

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["VIN-A1"].Make);
            Console.WriteLine(myDictionary["VIN-A2"].Model);
            */

            /*
            // we can initialize like we saw before in arrays
            //string[] names = {"Charlie", "Jenny", "Josie", "Jax", "Penny"};

            // Object Initializer syntax
            // No need for a Constructor
            Car car1 = new Car() { Make = "BMW", Model = "Super Awesome", VIN = "VIN-A3" };
            Car car2 = new Car() { Make = "Lexus", Model = "So fast and pretty", VIN = "VIN-A4" };
            */

            // COLLECTION INITIALIZER

            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "VIN-A5" },
                new Car { Make = "Something else", Model = "another one", VIN = "VIN-A6" }
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
