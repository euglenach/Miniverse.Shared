using System;
using System.Collections.Generic;
using MessagePack;

namespace MiniverseShared.MessagePackObjects
{
    [MessagePackObject]
    public record MajorityGameRoomInfo
    {
        [Key(0)] public Ulid Ulid { get; set; }
        [Key(1)] public List<Player> Players{get;set;}
        [Key(3)] public MajorityGameQuestion? Question { get; set; }

        public MajorityGameRoomInfo(Ulid ulid, List<Player> players, MajorityGameQuestion? question)
        {
            Ulid = ulid;
            Players = players;
            Question = question;
        }
    }
}
