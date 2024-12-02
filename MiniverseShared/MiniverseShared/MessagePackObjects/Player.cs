using System;
using MessagePack;

namespace MiniverseShared.MessagePackObjects
{
    [MessagePackObject]
    public class Player
    {
        [Key(0)] public Ulid Ulid { get; set; }
        [Key(1)] public string Name{ get; set; }
    }
}
