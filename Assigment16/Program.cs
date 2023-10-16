using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment16
{
    internal class Smartphone
    {

        public string IMEINo { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name} (IMEI: {IMEINo}, Model: {Model}, Price: {Price})";
        }
    }

    public class Program
        {
            public static void Main(string[] args)
        {
            LinkedListExample();




            Console.ReadLine();
        }

        private static void LinkedListExample()
        {
            LinkedList<(int, Smartphone)> linkedList = new LinkedList<(int, Smartphone)>();

            Smartphone smartphone1 = new Smartphone
            {
                IMEINo = "1234567890",
                Name = "iPhone 12",
                Model = "12",
                Price = 799.99
            };

            Smartphone smartphone2 = new Smartphone
            {
                IMEINo = "2345678901",
                Name = "Samsung Galaxy S21",
                Model = "S21",
                Price = 799.99
            };

            linkedList.AddLast((1, smartphone1));
            linkedList.AddLast((2, smartphone2));

            Console.WriteLine("Linked List of Smartphones:");
            foreach (var (id, phone) in linkedList)
            {
                Console.WriteLine($"ID: {id}, Smartphone: {phone}");
            }
        }

    }

    }

