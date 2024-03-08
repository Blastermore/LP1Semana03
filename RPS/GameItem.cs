using System;

namespace RPS
{
    [Flags]
    enum GameItems
    {
        Rock = 1 << 0,
        Paper = 1 << 1,
        Scissors = 1 << 2,
    }
}
