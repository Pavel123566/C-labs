using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Phone : Device
    {
        public bool DoubleSim { get; set; }
        public PhoneCaseType PhoneCase { get; set; }
        public bool Camera { get; set; }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("DoubleSim: " + DoubleSim);
            Console.WriteLine("PhoneCase: " + PhoneCase);
            Console.WriteLine("Camera: " + Camera);
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Input DoubleSim (+/-): ");
            DoubleSim = Check.ReadBool();
            Console.WriteLine("Input PhoneCase \n" +
                "(1-Classic, 2-Flip, 3-Slider): ");
            PhoneCase = (PhoneCaseType)Check.ReadInt(1, 3);
            Console.WriteLine("Input Camera (+/-): ");
            Camera = Check.ReadBool();
        }
    }
}
