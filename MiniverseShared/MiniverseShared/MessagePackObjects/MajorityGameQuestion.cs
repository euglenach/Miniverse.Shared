using System;
using MessagePack;

namespace MiniverseShared.MessagePackObjects
{
    [MessagePackObject]
    public class MajorityGameQuestion
    {
        [Key(0)] public Ulid AskedPlayerUlid { get; set; }
        [Key(1)] public string QuestionText {get; set; }
        [Key(2)] public string[] Choices { get; set; }
    }
}
