﻿using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.EventSub.Core.SubscriptionTypes.Channel;
using TwitchLib.EventSub.Websockets.Core.Models;

namespace TwitchLib.EventSub.Websockets.Core.EventArgs.Channel
{
    public class ChannelSuspiciousUserMessageArgs : TwitchLibEventSubEventArgs<EventSubNotification<ChannelSuspiciousUserMessage>>
    {
    }
}