using System;
using System.Threading.Tasks;
using MagicOnion;
using MiniverseShared.MessagePackObjects;

namespace MiniverseShared.StreamingHubs
{
    public interface IMatchingHub : IStreamingHub<IMatchingHub, IMatchingReceiver>
    {
        ValueTask CreateRoomAsync(Player player);
        ValueTask JoinRoomAsync(Ulid roomUlid, Player player);
    }

    public interface IMatchingReceiver
    {
        void OnJoin(Player player);
        void OnJoinSelf(MajorityGameRoomInfo roomInfo);
        void OnLeave(Ulid playerUlid);
    }
}
