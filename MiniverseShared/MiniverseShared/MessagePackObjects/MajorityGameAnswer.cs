using System;
using MessagePack;

namespace MiniverseShared.MessagePackObjects
{
    [MessagePackObject]
    public class MajorityGameAnswer
    {
        [Key(0)] public Ulid PlayerUlid { get;set;}
        [Key(1)] public int Index { get; set; }
    }
}
