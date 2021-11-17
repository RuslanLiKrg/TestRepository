using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeEquipment.Interfaces;

namespace HomeEquipment
{
    enum MyBrand
    {
        LG = 1, SAMSUNG, INDESIT, APPLE
    }
    abstract class HomeEquipmentParent : IHomeEquipment
    {
        protected const int voltage = 220;
        protected string name;
        private MyBrand brand;

        public MyBrand Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected int amperageInner;

        public int AmperageInner
        {
            get { return amperageInner; }
            set { amperageInner = value; }
        }

        public int Weight { get; set; }


        public virtual void TurnOn()
        {
            Console.WriteLine($" Прибор включен");
        }

        public void TurnOff()
        {
            Console.WriteLine("Прибор выключен");
        }

        public virtual void PlugIn()
        {
            Console.WriteLine("Розетка вставлена");
        }

        public int CalcPowerOutPut()
        {
            return amperageInner * voltage;
        }
       
    }
}
