using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Injection
{
    internal class Lamp
    {
        // without dependancy injection
        public IBulb bulb;
        public Lamp()
        {
            bulb = new Bulb();
        }
        //with dependancy injection
        public Lamp(IBulb b)
        {
            bulb = b;
        }



        public void SwitchOn()
        {
            bulb.TurnOn();
        }

        public void SwitchOff()
        {
            bulb.TurnOff();
        }
    }
}
