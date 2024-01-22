using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class Smartphone : Product
    {
        protected double DisplayDiagonal { get; set; }
        protected int RAM { get; set; }
        protected int BuiltMemory { get; set; }
        protected int BatteryCapacity { get; set; }
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
            DisplayDiagonal = 0;
            RAM = 0;
            BuiltMemory = 0;
            BatteryCapacity = 0;
        }
        public override string Display()
        {
            return $"{Name} {Price} {Count} {DisplayDiagonal} {RAM} {BuiltMemory} {BatteryCapacity}";
        }
    }
}
