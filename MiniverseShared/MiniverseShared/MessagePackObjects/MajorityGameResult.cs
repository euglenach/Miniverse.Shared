using System;
using MessagePack;

namespace MiniverseShared.MessagePackObjects
{
    [MessagePackObject]
    public class MajorityGameResult
    {
        [Key(0)] public Ulid[] Majorities {get; set;}
        [Key(1)] public int[] NumTable {get; set;}

        public MajorityGameResult(Ulid[] majorities, int[] numTable)
        {
            Majorities = majorities;
            NumTable = numTable;
        }
    }
}
