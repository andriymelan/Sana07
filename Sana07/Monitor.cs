using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class _Monitor : Product
    {
        protected int UpdateFrequency { get; set; }
        protected double DisplayDiagonal { get; set; }
        protected string MatrixType { get; set; }
        protected string Color { get; set; }
        public _Monitor(string name, double price, int count, int updateFrequency, double displayDiagonal, string matrixType, string color)
            : base(name, price, count)
        {
            UpdateFrequency = updateFrequency;
            DisplayDiagonal = displayDiagonal;
            MatrixType = matrixType;
            Color = color;
        }
        public _Monitor()
        {
            UpdateFrequency = 0;
            DisplayDiagonal = 0;
            MatrixType = "NM";
            Color = "NM";
        }
        public override string Display()
        {
            return $"{Name} {Price} {Count} {UpdateFrequency} {DisplayDiagonal} {MatrixType} {Color}";
        }
    }
}
