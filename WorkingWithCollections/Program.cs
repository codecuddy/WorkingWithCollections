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
            Car car1 = new Car();
            car1.Make = "Dodge";
            car1.Model = "Neon";

            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Equinox";

            Book b1 = new Book();
            b1.Author = "Charlie Cuddy";
            b1.Title = "Learning .NET";
            b1.ISBN = "0-000-00000-0";

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

            Console.ReadLine();
        }
    }

    class Car
    {
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
