using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeEquipment.Models
{
    class Fridge : HomeEquipmentParent
    {
        public Fridge()
        {
            Name = "Холодильник";
            Weight = 60;
            AmperageInner = 12;
            Brand = MyBrand.INDESIT;
        }
        public override void TurnOn()
        {
            Console.Write(Name + " ");
            base.TurnOn();
        }
        public override void PlugIn()
        {
            Console.WriteLine($"{Name} вставлен в розетку!!!");
        }
    }
}
