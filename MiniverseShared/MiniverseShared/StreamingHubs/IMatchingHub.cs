using System;
using System.Threading.Tasks;
using MagicOnion;
using MiniverseShared.MessagePackObjects;

namespace MiniverseShared.StreamingHubs
{
    public interface IMatchingHub : IStreamingHub<IMatchingHub, IMatchingReceiver>
    {
        ValueTask JoinAsync(Player player, Ulid roomUlid);
    }

    public interface IMatchingReceiver
    {
        void OnJoin();
        void OnLeave();
    }
}
