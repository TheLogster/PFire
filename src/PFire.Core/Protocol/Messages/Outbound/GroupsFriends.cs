﻿using System.Collections.Generic;

namespace PFire.Core.Protocol.Messages.Outbound
{
    internal sealed class GroupsFriends : XFireMessage
    {
        public GroupsFriends() : base(XFireMessageType.GroupsFriends)
        {
            UserIds = new List<int>();
            GroupIds = new List<int>();
        }

        [XMessageField(0x01)]
        public List<int> UserIds { get; }

        [XMessageField(0x19)]
        public List<int> GroupIds { get; }
    }
}
