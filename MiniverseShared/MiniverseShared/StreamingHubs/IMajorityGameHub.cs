using System;
using System.Threading.Tasks;
using MagicOnion;
using MiniverseShared.MessagePackObjects;

namespace MiniverseShared.StreamingHubs
{
    public interface IMajorityGameHub : IStreamingHub<IMajorityGameHub, IMajorityGameReceiver>
    {
        ValueTask AskQuestion(string questionText);
        ValueTask Select(int index);
        ValueTask ResultAsync();
    }
    
    public interface IMajorityGameReceiver
    {
        void OnAskedQuestion(MajorityGameQuestion question);
        void OnSelected(Ulid answerPlayerUlid, int index);
        void OnResult(MajorityGameResult result);
    }
}
