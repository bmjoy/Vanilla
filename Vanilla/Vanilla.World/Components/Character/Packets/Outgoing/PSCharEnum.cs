﻿namespace Vanilla.World.Components.Character.Packets.Outgoing
{
    using System;
    using System.Collections.Generic;
    using Vanilla.Core.Network.Packet;
    using Vanilla.Core.Opcodes;
    using Vanilla.Database.Character.Models;

    public class PSCharEnum : WorldPacket
    {
        public PSCharEnum(List<Character> characters) : base(WorldOpcodes.SMSG_CHAR_ENUM)
        {
            this.Write((byte)characters.Count);

            foreach (Character character in characters)
            {
                this.Write((ulong)character.GUID);
                this.WriteCString(character.Name);
                this.Write((byte)character.Race);
                this.Write((byte)character.Class);

                this.Write((byte)character.Gender);

                byte[] playerBytes = BitConverter.GetBytes(character.PlayerBytes);
                byte[] playerBytes2 = BitConverter.GetBytes(character.PlayerBytes2);

                this.Write((byte)playerBytes[0]); // Skin
                this.Write((byte)playerBytes[1]); // Face
                this.Write((byte)playerBytes[2]); // HairStyle
                this.Write((byte)playerBytes[3]); // HairColor
                this.Write((byte)playerBytes2[0]); // Accessory
                this.Write((byte)character.Level);

                this.Write(0); // Zone ID
                Write((int)character.Map);
                Write(character.PositionX);
                Write(character.PositionY);
                Write(character.PositionZ);

                this.Write(0); // Guild ID
                this.Write(0); // Character Flags

                this.Write((byte)0); // // Login Flags?

                this.Write(0); // Pet DisplayID
                this.Write(0); // Pet Level
                this.Write(0); // Pet FamilyID

                

                for (int itemSlot = 0; itemSlot < 19; itemSlot++)
                {
                     this.Write(0);
                     this.Write((byte)0);
                    /*
                    if (equipment[itemSlot] != null)
                    {
                        Write(equipment[itemSlot].displayid); // Item DisplayID
                        Write((byte)equipment[itemSlot].InventoryType); // Item Inventory Type
                    }
                    */
                }

                this.Write(0); // first bag display id
                this.Write((byte)0); // first bag inventory type
            }
        }
    }
}