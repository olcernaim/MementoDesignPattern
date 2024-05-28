using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class ToyCarMemento
    {
        public string Color { get; }

        public ToyCarMemento(string color)
        {
            Color = color;
        }
    }
}
