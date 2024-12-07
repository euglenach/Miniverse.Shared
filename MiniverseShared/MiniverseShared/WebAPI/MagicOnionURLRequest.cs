using MessagePack;

namespace MiniverseShared.WebAPI
{
    [MessagePackObject]
    public class MagicOnionURLRequest
    {
        [Key(0)] public string Index{get;set;}
    }
}
