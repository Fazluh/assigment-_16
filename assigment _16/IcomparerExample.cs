using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assigment__16
{
    internal class IcomparerExample : IComparer<SmartPhone>
    {
        public int Compare(SmartPhone x, SmartPhone y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    internal class SmartPhone : IComparable<SmartPhone>
    {
       
        public String IMEINo { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public int CompareTo(SmartPhone other)
        {
            return Name.CompareTo(other.Name);
        }
        public override string ToString()
        {
            return $"{Name} (IMEI: {IMEINo}, Model: {Model}, Price: {Price})";
        }
    }
    //public class SmartphoneDict
    //{
    //    Dictionary<int, SmartPhone> dit = new Dictionary<int, SmartPhone>
    //    {
    //        {1,new SmartPhone{IMEINo="998876756",Name="Blackberry",Model="v6",Price=56000} },
    //        {2,new SmartPhone{IMEINo="9986756",Name="Google",Model="Pixel",Price=66000}}
    //    };
    //    Dictionary<int, SmartPhone> dit2 = new Dictionary<int, SmartPhone>
    //    {
    //        { 3,new SmartPhone { IMEINo = "9876756", Name = "Nokia", Model = "Lumia", Price = 36000 } },
    //         { 4,new SmartPhone { IMEINo = "987123456756", Name = "Samsung", Model = "Galaxy s22", Price = 46000 } }
    //    };

    //}


    public class Program
    {
        static void Main(string[] args)
        {
            WorkingWithList();

            WorkingWithDictiobary();

            Console.ReadLine();
        }

        private static void WorkingWithList()
        {
            List<SmartPhone> phoneList = new List<SmartPhone>();
            phoneList.Add(new SmartPhone { IMEINo = "1223322324", Name = "Samsung", Model = "Galaxy A34", Price = 32000 });

            phoneList.Add(new SmartPhone { IMEINo = "1223328724", Name = "Samsung", Model = "Galaxy s23 Ultra", Price = 144000 });

            phoneList.Add(new SmartPhone { IMEINo = "23323322324", Name = "Apple", Model = "Iphone 15", Price = 132000 });

            phoneList.Add(new SmartPhone { IMEINo = "122332230984", Name = "Oppo", Model = "Reno 8", Price = 22000 });

            phoneList.Add(new SmartPhone { IMEINo = "12983322324", Name = "Vivo", Model = "V8", Price = 18000 });

            Console.WriteLine("Before Sorting : ");

            foreach (var phone in phoneList)
            {
                Console.WriteLine(phone);
            }
            phoneList.Sort();
            Console.WriteLine("--------------------------");
            Console.WriteLine("\n After Sorting");
            foreach (var phone in phoneList)
            {
                Console.WriteLine(phone);
            }
            phoneList.Sort(new IcomparerExample());
            Console.WriteLine("----------------------");
            Console.WriteLine("\nAfter sorting based on Name (Using Icomaprarer");
            foreach (var item in phoneList)
            {
                Console.WriteLine(item);
            }
        }

        private static void WorkingWithDictiobary()
        {
            Dictionary<int, SmartPhone> dic = new Dictionary<int, SmartPhone>
        {
            {1,new SmartPhone{IMEINo="998876756",Name="Blackberry",Model="v6",Price=56000} },
            {2,new SmartPhone{IMEINo="9986756",Name="Google",Model="Pixel",Price=66000}}
        };
            Console.WriteLine("-------------------");
            Console.WriteLine("First Dict is :");
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Dictionary<int, SmartPhone> dic2 = new Dictionary<int, SmartPhone>
        {
            { 3,new SmartPhone { IMEINo = "9876756", Name = "Nokia", Model = "Lumia", Price = 36000 } },
                {6,new SmartPhone {IMEINo="998876756",Name="Blackberry",Model="v6",Price=56000} },
             { 4,new SmartPhone { IMEINo = "987123456756", Name = "Samsung", Model = "Galaxy s22", Price = 46000 } }
        };
            Console.WriteLine("-------------------");
            Console.WriteLine("Second Dict is :");
            foreach (var item in dic2)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Dictionary<int, SmartPhone> concatedDic = dic.Concat(dic2).ToDictionary(d => d.Key, d => d.Value);


            Dictionary<int, SmartPhone> intersecteddDic = dic2.Intersect(dic).ToDictionary(d => d.Key, d => d.Value);
            Console.WriteLine("-----------------");
            Console.WriteLine("Concatenated Dict:");
            foreach (var phone in concatedDic)
                Console.WriteLine(phone.Key + " " + phone.Value);
            Console.WriteLine("--------------------");
            Console.WriteLine("\nIntersected Dict:");
            foreach (var phone in intersecteddDic)
                Console.WriteLine(phone.Key + " " + phone.Value);
        }
    }
}
