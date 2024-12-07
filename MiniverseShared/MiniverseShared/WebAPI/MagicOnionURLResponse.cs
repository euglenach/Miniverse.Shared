using MessagePack;

namespace MiniverseShared.WebAPI
{
    [MessagePackObject]
    public class MagicOnionURLResponse
    {
        public MagicOnionURLResponse(string url)
        {
            URL = url;
        }

        [Key(0)] public string URL { get; set; }
    }
}
