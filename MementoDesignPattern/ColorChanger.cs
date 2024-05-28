using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class ColorChanger
    {
        private ToyCarMemento _memento;

        public void ChangeColor(ToyCar car, string color)
        {
            _memento = car.SaveState();
            car.SetColor(color);
        }

        public void UndoColorChange(ToyCar car)
        {
            car.RestoreState(_memento);
        }

    }
}
