﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Milkshake.Network;

namespace Milkshake.Communication.Outgoing.World
{
    public class LoginVerifyWorld : ServerPacket
    {
        public LoginVerifyWorld(int mapID, float X, float Y, float Z, float Rotation) : base(WorldOpcodes.SMSG_LOGIN_VERIFY_WORLD)
        {
            Write(mapID);
            Write(X);
            Write(Y);
            Write(Z);
            Write(Rotation); // orientation
        }
    }
}
