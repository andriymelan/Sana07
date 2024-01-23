using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class Computer : Product
    {
        protected int _PowerOfPowerSupply;
        protected int _RAM_Memory;
        protected int _VideoMemory;
        protected int _SSD_Memory;
        protected int PowerOfPowerSupply
        {
            get => _PowerOfPowerSupply;
            set
            {
                if (value > 0)
                    _PowerOfPowerSupply = value;
                else
                    throw new MyExceptions("PowerOfPowerSupply", "Compute");
            }
        }
        protected int RAM_Memory
        {
            get => _RAM_Memory;
            set
            {
                if (value > 0)
                    _RAM_Memory = value;
                else
                    throw new MyExceptions("RAM_Memory", "Compute");
            }
        }
        protected int VideoMemory
        {
            get => _VideoMemory;
            set
            {
                if (value > 0)
                    _VideoMemory = value;
                else
                    throw new MyExceptions("VideoMemory", "Compute");
            }
        }
        protected int SSD_Memory
        {
            get => _SSD_Memory;
            set
            {
                if (value > 0)
                    _SSD_Memory = value;
                else
                    throw new MyExceptions("SSD_Memory", "Compute");
            }
        }
        public Computer(string name, double price, int count, int powerOfPowerSupply, int rAM_Memory, int videoMemory, int sSD_Memory)
            : base(name, price, count)
        {
            PowerOfPowerSupply = powerOfPowerSupply; 
            RAM_Memory = rAM_Memory;
            VideoMemory = videoMemory;
            SSD_Memory = sSD_Memory;
        }
        public Computer()
        {
            PowerOfPowerSupply = 1;
            RAM_Memory = 1;
            VideoMemory = 1;
            SSD_Memory = 1;
        }
        public override string Display()
        {
            return $"{Name} {Price} {Count} {PowerOfPowerSupply} {RAM_Memory} {VideoMemory} {SSD_Memory}";
        }
    }
}
