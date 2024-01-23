using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class _Monitor : Product
    {
        protected int _UpdateFrequency;
        protected double _DisplayDiagonal;
        protected string _MatrixType;
        protected string _Color;
        protected int UpdateFrequency
        {
            get => _UpdateFrequency;
            set
            {
                if (value > 0)
                    _UpdateFrequency = value;
                else
                    throw new MyExceptions("UpdateFrequency", "_Monitor");
            }
        }
        protected double DisplayDiagonal
        {
            get => _DisplayDiagonal;
            set
            {
                if (value > 0)
                    _DisplayDiagonal = value;
                else
                    throw new MyExceptions("DisplayDiagonal", "_Monitor");
            }
        }
        protected string MatrixType
        {
            get => _MatrixType;
            set
            {
                if (value != "")
                    _MatrixType = value;
                else
                    throw new MyExceptions("MatrixType", "_Monitor");
            }
        }
        protected string Color
        {
            get => _Color;
            set
            {
                if (value != "")
                    _Color = value;
                else
                    throw new MyExceptions("Color", "_Monitor");
            }
        }
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
            UpdateFrequency = 1;
            DisplayDiagonal = 1;
            MatrixType = "NM";
            Color = "NM";
        }
        public override string Display()
        {
            return $"{Name} {Price} {Count} {UpdateFrequency} {DisplayDiagonal} {MatrixType} {Color}";
        }
    }
}
