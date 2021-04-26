using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    public enum Headers : byte
    {
        Queue,
        Start,
        Stop,
        Pause,
        Chunk
    }
}
