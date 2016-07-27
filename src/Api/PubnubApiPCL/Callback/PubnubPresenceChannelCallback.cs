﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubnubApi
{
    internal class PubnubPresenceChannelCallback
    {
        public Action<PresenceAck> PresenceRegularCallback;
        public Action<ConnectOrDisconnectAck> ConnectCallback;
        public Action<ConnectOrDisconnectAck> DisconnectCallback;
        public Action<PubnubClientError> ErrorCallback;

        public PubnubPresenceChannelCallback()
        {
            PresenceRegularCallback = null;
            ConnectCallback = null;
            DisconnectCallback = null;
            ErrorCallback = null;
        }
    }
}