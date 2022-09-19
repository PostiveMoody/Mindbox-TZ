using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    public interface IShape
    {
        public double GetArea();

        public string FigureName { get; }
    }
}
