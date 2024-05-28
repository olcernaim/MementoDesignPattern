using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class ToyCar
    {
        public string _color;

        public string GetColor() { return _color; }
        public void SetColor(string value)
        {
            _color = value;
            Console.WriteLine($"Car color changed to {_color}.");
        }

        public ToyCarMemento SaveState()
        {
            return new ToyCarMemento(GetColor());
        }

        public void RestoreState(ToyCarMemento memento)
        {
            SetColor(memento.Color);
        }
    }
}
