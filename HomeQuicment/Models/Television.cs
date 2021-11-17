using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeEquipment.Models
{
    class Television : HomeEquipmentParent
    {
        public Television()
        {
            
            Name = "Телевизор";
            AmperageInner = 5;
            Weight = 15;
            Brand = MyBrand.LG;
        }

       

        public override void PlugIn()
        {
            Console.WriteLine($"{Name} вставлен в розетку");
        }
        public override void TurnOn()
        {
            Console.WriteLine($"{Name} включен!!!");
        }
    }
}
