using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class Smartphone : Product
    {
        protected double _DisplayDiagonal;
        protected int _RAM;
        protected int _BuiltMemory;
        protected int _BatteryCapacity;
        protected double DisplayDiagonal
        {
            get => _DisplayDiagonal;
            set
            {
                if (value > 0)
                    _DisplayDiagonal = value;
                else
                    throw new MyExceptions("DisplayDiagonal", "Smartphone");
            }
        }
        protected int RAM
        {
            get => _RAM;
            set
            {
                if (value > 0)
                    _RAM = value;
                else
                    throw new MyExceptions("RAM", "Smartphone");
            }
        }
        protected int BuiltMemory
        {
            get => _BuiltMemory;
            set
            {
                if (value > 0)
                    _BuiltMemory = value;
                else
                    throw new MyExceptions("BuiltMemory", "Smartphone");
            }
        }
        protected int BatteryCapacity
        {
            get => _BatteryCapacity;
            set
            {
                if (value > 0)
                    _BatteryCapacity = value;
                else
                    throw new MyExceptions("BatteryCapacity", "Smartphone");
            }
        }
        public Smartphone(string name, double price, int count, double displayDiagonal, int rAM, int builtMemory, int batteryCapacity)
            : base(name, price, count)
        {
            DisplayDiagonal = displayDiagonal;
            RAM = rAM;
            BuiltMemory = builtMemory;
            BatteryCapacity = batteryCapacity;
        }
        public Smartphone()
        {
            DisplayDiagonal = 1;
            RAM = 1;
            BuiltMemory = 1;
            BatteryCapacity = 1;
        }
        public override string Display()
        {
            return $"{Name} {Price} {Count} {DisplayDiagonal} {RAM} {BuiltMemory} {BatteryCapacity}";
        }
    }
}
