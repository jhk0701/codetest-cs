using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using CodeTest;
using System.Drawing;
using System.Threading;

namespace Test
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            JoyStick joystick = new JoyStick();
            Console.WriteLine(joystick.Sol("JAN")); // "JEROEN"
        }
    }
}
