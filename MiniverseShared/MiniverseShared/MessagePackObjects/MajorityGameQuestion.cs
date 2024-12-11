using System;
using MessagePack;

namespace MiniverseShared.MessagePackObjects
{
    [MessagePackObject]
    public class MajorityGameQuestion
    {
        [Key(0)] public Ulid SessionUlid { get; set; }
        [Key(1)] public Ulid AskedPlayerUlid { get; set; }
        [Key(2)] public string QuestionText {get; set; }
        [Key(3)] public string[] Choices { get; set; }
    }
}
