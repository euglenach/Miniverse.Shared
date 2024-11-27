using System;
using MessagePack;

namespace MiniverseShared
{
    [MessagePackObject]
    public class Nanka
    {
        [Key(0)] public string Name {get;set;}
        [Key(1)] public int Value1 {get;set;}
    }
}
