﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCPU.Intel8080;

namespace eCPU.Machine8080
{
    public class ShiftOffsetDevice : IOutputDevice
    {
        private object _lock;
        private byte _shiftOffset = 0x00;

        public byte Read()
        {
            lock (_lock)
            {
                return _shiftOffset;
            }
        }

        public void Write(byte data)
        {
            lock(_lock)
            {
                _shiftOffset = (byte)(data & 0x07);
            }
        }
    }
}
