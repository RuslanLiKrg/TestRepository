using System;
using System.Linq;
using HomeEquipment.Models;

namespace HomeEquipment
{
    class Program
    {
       
        static void Main(string[] args)
        {

            HomeEquipmentParent[] arrayEquipments = new HomeEquipmentParent[3];
            arrayEquipments[0] = new Television();
            arrayEquipments[1] = new Fridge();
            arrayEquipments[2] = new Fridge();
            arrayEquipments[2].Name = "Ноутбук";
            foreach (var t in arrayEquipments)
            {
                Console.WriteLine($"equipment name: {t.Name} \n brand name: {t.Brand} \n Output: {t.CalcPowerOutPut()} \n\n" );
            }
            Console.WriteLine("введите начальный параметр мощности  для поиска: ");
            int start = int.Parse( Console.ReadLine());
            Console.WriteLine("введите конечный параметр мощности  для поиска: ");

            int end = int.Parse(Console.ReadLine());
            SearchEquipmentByOutPut(arrayEquipments, start, end);
            Console.ReadLine();
        }
        public static void Sort(HomeEquipmentParent[] homeEquipmentParents)
        {
            var newSortArray = homeEquipmentParents.OrderBy(n => n.Name).ToList();
            for (int i = 0; i < homeEquipmentParents.Length; i++)
            {
                homeEquipmentParents[i] = newSortArray[i];
                
            }
        }
        public static void SearchEquipmentByOutPut(HomeEquipmentParent[] homeEquipmentParents, int startParameter, int endParametr)
        {
            Console.WriteLine("Приборы, соответсвующие заданным параметрам: ");

            foreach (var item in homeEquipmentParents)
            {
                if (item.CalcPowerOutPut() >= startParameter && item.CalcPowerOutPut() <= endParametr )
                {
                    Console.WriteLine(item.Name);
                }
            }
        }


    }
}
