﻿using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.trvelReady();
        }
    }
}
