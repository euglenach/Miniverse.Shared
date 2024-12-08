using System;
using MessagePack;

namespace MiniverseShared.MessagePackObjects
{
    [MessagePackObject]
    public record MajorityGameRoomInfo
    {
        [Key(0)] public Ulid Ulid { get; set; }

        public MajorityGameRoomInfo(Ulid ulid)
        {
            Ulid = ulid;
        }
    }
}
