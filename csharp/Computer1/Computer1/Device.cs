using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_in_Csharp
{
    public abstract class Device
    {
        public Device(string name, string make)
        {
            _make = make;
            _name = name;
        }
        protected string _name;
        protected string _make;

        public abstract void StartDevice();

        public abstract void ShutDown();
    }
}
