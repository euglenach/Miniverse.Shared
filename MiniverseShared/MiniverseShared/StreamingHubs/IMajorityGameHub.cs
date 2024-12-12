using System;
using System.Threading.Tasks;
using MagicOnion;
using MiniverseShared.MessagePackObjects;

namespace MiniverseShared.StreamingHubs
{
    public interface IMajorityGameHub : IStreamingHub<IMajorityGameHub, IMajorityGameReceiver>
    {
        ValueTask AskQuestion(string questionText, string[] choices);
        ValueTask Select(int index);
        ValueTask ResultOpen();
    }
    
    public interface IMajorityGameReceiver
    {
        void OnConnected();
        void OnAskedQuestion(MajorityGameQuestion question);
        void OnSelected(Ulid selectedPlayerUlid, int index);
        void OnResult(MajorityGameResult result);
    }
}
