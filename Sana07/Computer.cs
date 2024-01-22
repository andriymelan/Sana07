using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class Computer:Product
    {
        protected int PowerOfPowerSupply {  get; set; }
        protected int RAM_Memory { get; set; }
        protected int VideoMemory { get; set; }
        protected int SSD_Memory { get; set; }
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
            PowerOfPowerSupply = 0;
            RAM_Memory = 0;
            VideoMemory = 0;
            SSD_Memory = 0;
        }
        public override string Display()
        {
            return $"{Name} {Price} {Count} {PowerOfPowerSupply} {RAM_Memory} {VideoMemory} {SSD_Memory}";
        }
    }
}
