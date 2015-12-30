﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using eCPU.Intel8080;

namespace eCPU
{
    public interface IArcadeGame
    {
        void Load();

        Image GetScreen();

        void KeyDown(Keys key);
        void KeyUp(Keys key);

        void Run();
        void RunInstructions(int numOfInstructions);

        long CountOfInstructions { get; }
        long CountOfCycles { get; }

        i8080 CPU { get; }
    }
}
