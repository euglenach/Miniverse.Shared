using System;
using MessagePack;

namespace MiniverseShared.MessagePackObjects
{
    [MessagePackObject]
    public record Player
    {
        [Key(0)] public Ulid Ulid { get; set; }
        [Key(1)] public string Name{ get; set; }

        public Player(Ulid ulid, string name)
        {
            Ulid = ulid;
            Name = name;
        }
    }
}
