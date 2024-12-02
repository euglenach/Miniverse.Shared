using System;
using MessagePack;

namespace MiniverseShared.MessagePackObjects
{
    [MessagePackObject]
    public class Room
    {
        [Key(0)] public string RoomName { get; set; }
    }
}
