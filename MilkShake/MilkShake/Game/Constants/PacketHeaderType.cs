﻿using Milkshake.Communication;
using Milkshake.Network;

namespace Milkshake.Game.Constants
{
    public enum PacketHeaderType : byte
    {
        AuthCmsg = 1,
        AuthSmsg = 3,
        WorldSmsg = 4,
        WorldCmsg = 6
    }

    public static class PacketHeaderExtension
    {
        public static PacketHeaderType Parse(this RealmServerOpCode opCode)
        {
            return opCode.ToString().StartsWith("CMSG") ? PacketHeaderType.WorldCmsg : PacketHeaderType.WorldSmsg;
        }

        public static PacketHeaderType Parse(this AuthServerOpCode opCode)
        {
            return PacketHeaderType.AuthSmsg;
        }
    }
}
