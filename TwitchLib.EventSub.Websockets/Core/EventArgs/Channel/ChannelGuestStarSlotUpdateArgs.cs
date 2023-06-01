using TwitchLib.EventSub.Core.SubscriptionTypes.Channel;
using TwitchLib.EventSub.Websockets.Core.Models;

namespace TwitchLib.EventSub.Websockets.Core.EventArgs.Channel
{
    public class ChannelGuestStarSlotUpdateArgs : TwitchLibEventSubEventArgs<EventSubNotification<ChannelGuestStarSlotUpdate>>
    { }
}