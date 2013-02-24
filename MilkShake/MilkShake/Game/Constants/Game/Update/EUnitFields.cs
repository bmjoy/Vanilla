﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Milkshake.Game.Constants.Game.Update
{
    enum EObjectFields
    {
        OBJECT_FIELD_GUID = 0x00, // Size:2
        OBJECT_FIELD_TYPE = 0x02, // Size:1
        OBJECT_FIELD_ENTRY = 0x03, // Size:1
        OBJECT_FIELD_SCALE_X = 0x04, // Size:1
        OBJECT_FIELD_PADDING = 0x05, // Size:1
        OBJECT_END = 0x06,
    };

    public enum EUnitFields
    {
        UNIT_FIELD_CHARM = 0x00 + 0x06, // Size:2
        UNIT_FIELD_SUMMON = 0x02 + 0x06, // Size:2
        UNIT_FIELD_CHARMEDBY = 0x04 + 0x06, // Size:2
        UNIT_FIELD_SUMMONEDBY = 0x06 + 0x06, // Size:2
        UNIT_FIELD_CREATEDBY = 0x08 + 0x06, // Size:2
        UNIT_FIELD_TARGET = 0x0A + 0x06, // Size:2
        UNIT_FIELD_PERSUADED = 0x0C + 0x06, // Size:2
        UNIT_FIELD_CHANNEL_OBJECT = 0x0E + 0x06, // Size:2
        UNIT_FIELD_HEALTH = 0x10 + 0x06, // Size:1
        UNIT_FIELD_POWER1 = 0x11 + 0x06, // Size:1
        UNIT_FIELD_POWER2 = 0x12 + 0x06, // Size:1
        UNIT_FIELD_POWER3 = 0x13 + 0x06, // Size:1
        UNIT_FIELD_POWER4 = 0x14 + 0x06, // Size:1
        UNIT_FIELD_POWER5 = 0x15 + 0x06, // Size:1
        UNIT_FIELD_MAXHEALTH = 0x16 + 0x06, // Size:1
        UNIT_FIELD_MAXPOWER1 = 0x17 + 0x06, // Size:1
        UNIT_FIELD_MAXPOWER2 = 0x18 + 0x06, // Size:1
        UNIT_FIELD_MAXPOWER3 = 0x19 + 0x06, // Size:1
        UNIT_FIELD_MAXPOWER4 = 0x1A + 0x06, // Size:1
        UNIT_FIELD_MAXPOWER5 = 0x1B + 0x06, // Size:1
        UNIT_FIELD_LEVEL = 0x1C + 0x06, // Size:1
        UNIT_FIELD_FACTIONTEMPLATE = 0x1D + 0x06, // Size:1
        UNIT_FIELD_BYTES_0 = 0x1E + 0x06, // Size:1
        UNIT_VIRTUAL_ITEM_SLOT_DISPLAY = 0x1F + 0x06, // Size:3
        UNIT_VIRTUAL_ITEM_SLOT_DISPLAY_01 = 0x20 + 0x06,
        UNIT_VIRTUAL_ITEM_SLOT_DISPLAY_02 = 0x21 + 0x06,
        UNIT_VIRTUAL_ITEM_INFO = 0x22 + 0x06, // Size:6
        UNIT_VIRTUAL_ITEM_INFO_01 = 0x23 + 0x06,
        UNIT_VIRTUAL_ITEM_INFO_02 = 0x24 + 0x06,
        UNIT_VIRTUAL_ITEM_INFO_03 = 0x25 + 0x06,
        UNIT_VIRTUAL_ITEM_INFO_04 = 0x26 + 0x06,
        UNIT_VIRTUAL_ITEM_INFO_05 = 0x27 + 0x06,
        UNIT_FIELD_FLAGS = 0x28 + 0x06, // Size:1
        UNIT_FIELD_AURA = 0x29 + 0x06, // Size:48
        UNIT_FIELD_AURA_LAST = 0x58 + 0x06,
        UNIT_FIELD_AURAFLAGS = 0x59 + 0x06, // Size:6
        UNIT_FIELD_AURAFLAGS_01 = 0x5a + 0x06,
        UNIT_FIELD_AURAFLAGS_02 = 0x5b + 0x06,
        UNIT_FIELD_AURAFLAGS_03 = 0x5c + 0x06,
        UNIT_FIELD_AURAFLAGS_04 = 0x5d + 0x06,
        UNIT_FIELD_AURAFLAGS_05 = 0x5e + 0x06,
        UNIT_FIELD_AURALEVELS = 0x5f + 0x06, // Size:12
        UNIT_FIELD_AURALEVELS_LAST = 0x6a + 0x06,
        UNIT_FIELD_AURAAPPLICATIONS = 0x6b + 0x06, // Size:12
        UNIT_FIELD_AURAAPPLICATIONS_LAST = 0x76 + 0x06,
        UNIT_FIELD_AURASTATE = 0x77 + 0x06, // Size:1
        UNIT_FIELD_BASEATTACKTIME = 0x78 + 0x06, // Size:2
        UNIT_FIELD_OFFHANDATTACKTIME = 0x79 + 0x06, // Size:2
        UNIT_FIELD_RANGEDATTACKTIME = 0x7a + 0x06, // Size:1
        UNIT_FIELD_BOUNDINGRADIUS = 0x7b + 0x06, // Size:1
        UNIT_FIELD_COMBATREACH = 0x7c + 0x06, // Size:1
        UNIT_FIELD_DISPLAYID = 0x7d + 0x06, // Size:1
        UNIT_FIELD_NATIVEDISPLAYID = 0x7e + 0x06, // Size:1
        UNIT_FIELD_MOUNTDISPLAYID = 0x7f + 0x06, // Size:1
        UNIT_FIELD_MINDAMAGE = 0x80 + 0x06, // Size:1
        UNIT_FIELD_MAXDAMAGE = 0x81 + 0x06, // Size:1
        UNIT_FIELD_MINOFFHANDDAMAGE = 0x82 + 0x06, // Size:1
        UNIT_FIELD_MAXOFFHANDDAMAGE = 0x83 + 0x06, // Size:1
        UNIT_FIELD_BYTES_1 = 0x84 + 0x06, // Size:1
        UNIT_FIELD_PETNUMBER = 0x85 + 0x06, // Size:1
        UNIT_FIELD_PET_NAME_TIMESTAMP = 0x86 + 0x06, // Size:1
        UNIT_FIELD_PETEXPERIENCE = 0x87 + 0x06, // Size:1
        UNIT_FIELD_PETNEXTLEVELEXP = 0x88 + 0x06, // Size:1
        UNIT_DYNAMIC_FLAGS = 0x89 + 0x06, // Size:1
        UNIT_CHANNEL_SPELL = 0x8a + 0x06, // Size:1
        UNIT_MOD_CAST_SPEED = 0x8b + 0x06, // Size:1
        UNIT_CREATED_BY_SPELL = 0x8c + 0x06, // Size:1
        UNIT_NPC_FLAGS = 0x8d + 0x06, // Size:1
        UNIT_NPC_EMOTESTATE = 0x8e + 0x06, // Size:1
        UNIT_TRAINING_POINTS = 0x8f + 0x06, // Size:1
        UNIT_FIELD_STAT0 = 0x90 + 0x06, // Size:1
        UNIT_FIELD_STAT1 = 0x91 + 0x06, // Size:1
        UNIT_FIELD_STAT2 = 0x92 + 0x06, // Size:1
        UNIT_FIELD_STAT3 = 0x93 + 0x06, // Size:1
        UNIT_FIELD_STAT4 = 0x94 + 0x06, // Size:1
        UNIT_FIELD_RESISTANCES = 0x95 + 0x06, // Size:7
        UNIT_FIELD_RESISTANCES_01 = 0x96 + 0x06,
        UNIT_FIELD_RESISTANCES_02 = 0x97 + 0x06,
        UNIT_FIELD_RESISTANCES_03 = 0x98 + 0x06,
        UNIT_FIELD_RESISTANCES_04 = 0x99 + 0x06,
        UNIT_FIELD_RESISTANCES_05 = 0x9a + 0x06,
        UNIT_FIELD_RESISTANCES_06 = 0x9b + 0x06,
        UNIT_FIELD_BASE_MANA = 0x9c + 0x06, // Size:1
        UNIT_FIELD_BASE_HEALTH = 0x9d + 0x06, // Size:1
        UNIT_FIELD_BYTES_2 = 0x9e + 0x06, // Size:1
        UNIT_FIELD_ATTACK_POWER = 0x9f + 0x06, // Size:1
        UNIT_FIELD_ATTACK_POWER_MODS = 0xa0 + 0x06, // Size:1
        UNIT_FIELD_ATTACK_POWER_MULTIPLIER = 0xa1 + 0x06, // Size:1
        UNIT_FIELD_RANGED_ATTACK_POWER = 0xa2 + 0x06, // Size:1
        UNIT_FIELD_RANGED_ATTACK_POWER_MODS = 0xa3 + 0x06, // Size:1
        UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER = 0xa4 + 0x06, // Size:1
        UNIT_FIELD_MINRANGEDDAMAGE = 0xa5 + 0x06, // Size:1
        UNIT_FIELD_MAXRANGEDDAMAGE = 0xa6 + 0x06, // Size:1
        UNIT_FIELD_POWER_COST_MODIFIER = 0xa7 + 0x06, // Size:7
        UNIT_FIELD_POWER_COST_MODIFIER_01 = 0xa8 + 0x06,
        UNIT_FIELD_POWER_COST_MODIFIER_02 = 0xa9 + 0x06,
        UNIT_FIELD_POWER_COST_MODIFIER_03 = 0xaa + 0x06,
        UNIT_FIELD_POWER_COST_MODIFIER_04 = 0xab + 0x06,
        UNIT_FIELD_POWER_COST_MODIFIER_05 = 0xac + 0x06,
        UNIT_FIELD_POWER_COST_MODIFIER_06 = 0xad + 0x06,
        UNIT_FIELD_POWER_COST_MULTIPLIER = 0xae + 0x06, // Size:7
        UNIT_FIELD_POWER_COST_MULTIPLIER_01 = 0xaf + 0x06,
        UNIT_FIELD_POWER_COST_MULTIPLIER_02 = 0xb0 + 0x06,
        UNIT_FIELD_POWER_COST_MULTIPLIER_03 = 0xb1 + 0x06,
        UNIT_FIELD_POWER_COST_MULTIPLIER_04 = 0xb2 + 0x06,
        UNIT_FIELD_POWER_COST_MULTIPLIER_05 = 0xb3 + 0x06,
        UNIT_FIELD_POWER_COST_MULTIPLIER_06 = 0xb4 + 0x06,
        UNIT_FIELD_PADDING = 0xb5 + 0x06,
        UNIT_END = 0xb6 + 0x06,

        PLAYER_DUEL_ARBITER = 0x00 + 0xb6 + 0x06, // Size:2
        PLAYER_FLAGS = 0x02 + 0xb6 + 0x06, // Size:1
        PLAYER_GUILDID = 0x03 + 0xb6 + 0x06, // Size:1
        PLAYER_GUILDRANK = 0x04 + 0xb6 + 0x06, // Size:1
        PLAYER_BYTES = 0x05 + 0xb6 + 0x06, // Size:1
        PLAYER_BYTES_2 = 0x06 + 0xb6 + 0x06, // Size:1
        PLAYER_BYTES_3 = 0x07 + 0xb6 + 0x06, // Size:1
        PLAYER_DUEL_TEAM = 0x08 + 0xb6 + 0x06, // Size:1
        PLAYER_GUILD_TIMESTAMP = 0x09 + 0xb6 + 0x06, // Size:1
        PLAYER_QUEST_LOG_1_1 = 0x0A + 0xb6 + 0x06, // count = 20
        PLAYER_QUEST_LOG_1_2 = 0x0B + 0xb6 + 0x06,
        PLAYER_QUEST_LOG_1_3 = 0x0C + 0xb6 + 0x06,
        PLAYER_QUEST_LOG_LAST_1 = 0x43 + 0xb6 + 0x06,
        PLAYER_QUEST_LOG_LAST_2 = 0x44 + 0xb6 + 0x06,
        PLAYER_QUEST_LOG_LAST_3 = 0x45 + 0xb6 + 0x06,
        PLAYER_VISIBLE_ITEM_1_CREATOR = 0x46 + 0xb6 + 0x06, // Size:2, count = 19
        PLAYER_VISIBLE_ITEM_1_0 = 0x48 + 0xb6 + 0x06, // Size:8
        PLAYER_VISIBLE_ITEM_1_PROPERTIES = 0x50 + 0xb6 + 0x06, // Size:1
        PLAYER_VISIBLE_ITEM_1_PAD = 0x51 + 0xb6 + 0x06, // Size:1
        PLAYER_VISIBLE_ITEM_LAST_CREATOR = 0x11e + 0xb6 + 0x06,
        PLAYER_VISIBLE_ITEM_LAST_0 = 0x120 + 0xb6 + 0x06,
        PLAYER_VISIBLE_ITEM_LAST_PROPERTIES = 0x128 + 0xb6 + 0x06,
        PLAYER_VISIBLE_ITEM_LAST_PAD = 0x129 + 0xb6 + 0x06,
        PLAYER_FIELD_INV_SLOT_HEAD = 0x12a + 0xb6 + 0x06, // Size:46
        PLAYER_FIELD_PACK_SLOT_1 = 0x158 + 0xb6 + 0x06, // Size:32
        PLAYER_FIELD_PACK_SLOT_LAST = 0x176 + 0xb6 + 0x06,
        PLAYER_FIELD_BANK_SLOT_1 = 0x178 + 0xb6 + 0x06, // Size:48
        PLAYER_FIELD_BANK_SLOT_LAST = 0x1a6 + 0xb6 + 0x06,
        PLAYER_FIELD_BANKBAG_SLOT_1 = 0x1a8 + 0xb6 + 0x06, // Size:12
        PLAYER_FIELD_BANKBAG_SLOT_LAST = 0xab2 + 0xb6 + 0x06,
        PLAYER_FIELD_VENDORBUYBACK_SLOT_1 = 0x1b4 + 0xb6 + 0x06, // Size:24
        PLAYER_FIELD_VENDORBUYBACK_SLOT_LAST = 0x1ca + 0xb6 + 0x06,
        PLAYER_FIELD_KEYRING_SLOT_1 = 0x1cc + 0xb6 + 0x06, // Size:64
        PLAYER_FIELD_KEYRING_SLOT_LAST = 0x20a + 0xb6 + 0x06,
        PLAYER_FARSIGHT = 0x20c + 0xb6 + 0x06, // Size:2
        PLAYER_FIELD_COMBO_TARGET = 0x20e + 0xb6 + 0x06, // Size:2
        PLAYER_XP = 0x210 + 0xb6 + 0x06, // Size:1
        PLAYER_NEXT_LEVEL_XP = 0x211 + 0xb6 + 0x06, // Size:1
        PLAYER_SKILL_INFO_1_1 = 0x212 + 0xb6 + 0x06, // Size:384
        PLAYER_CHARACTER_POINTS1 = 0x392 + 0xb6 + 0x06, // Size:1
        PLAYER_CHARACTER_POINTS2 = 0x393 + 0xb6 + 0x06, // Size:1
        PLAYER_TRACK_CREATURES = 0x394 + 0xb6 + 0x06, // Size:1
        PLAYER_TRACK_RESOURCES = 0x395 + 0xb6 + 0x06, // Size:1
        PLAYER_BLOCK_PERCENTAGE = 0x396 + 0xb6 + 0x06, // Size:1
        PLAYER_DODGE_PERCENTAGE = 0x397 + 0xb6 + 0x06, // Size:1
        PLAYER_PARRY_PERCENTAGE = 0x398 + 0xb6 + 0x06, // Size:1
        PLAYER_CRIT_PERCENTAGE = 0x399 + 0xb6 + 0x06, // Size:1
        PLAYER_RANGED_CRIT_PERCENTAGE = 0x39a + 0xb6 + 0x06, // Size:1
        PLAYER_EXPLORED_ZONES_1 = 0x39b + 0xb6 + 0x06, // Size:64
        PLAYER_REST_STATE_EXPERIENCE = 0x3db + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_COINAGE = 0x3dc + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_POSSTAT0 = 0x3DD + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_POSSTAT1 = 0x3DE + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_POSSTAT2 = 0x3DF + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_POSSTAT3 = 0x3E0 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_POSSTAT4 = 0x3E1 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_NEGSTAT0 = 0x3E2 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_NEGSTAT1 = 0x3E3 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_NEGSTAT2 = 0x3E4 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_NEGSTAT3 = 0x3E5 + 0xb6 + 0x06, // Size:1,
        PLAYER_FIELD_NEGSTAT4 = 0x3E6 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_RESISTANCEBUFFMODSPOSITIVE = 0x3E7 + 0xb6 + 0x06, // Size:7
        PLAYER_FIELD_RESISTANCEBUFFMODSNEGATIVE = 0x3EE + 0xb6 + 0x06, // Size:7
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS = 0x3F5 + 0xb6 + 0x06, // Size:7
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG = 0x3FC + 0xb6 + 0x06, // Size:7
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT = 0x403 + 0xb6 + 0x06, // Size:7
        PLAYER_FIELD_BYTES = 0x40A + 0xb6 + 0x06, // Size:1
        PLAYER_AMMO_ID = 0x40B + 0xb6 + 0x06, // Size:1
        PLAYER_SELF_RES_SPELL = 0x40C + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_PVP_MEDALS = 0x40D + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_BUYBACK_PRICE_1 = 0x40E + 0xb6 + 0x06, // count=12
        PLAYER_FIELD_BUYBACK_PRICE_LAST = 0x419 + 0xb6 + 0x06,
        PLAYER_FIELD_BUYBACK_TIMESTAMP_1 = 0x41A + 0xb6 + 0x06, // count=12
        PLAYER_FIELD_BUYBACK_TIMESTAMP_LAST = 0x425 + 0xb6 + 0x06,
        PLAYER_FIELD_SESSION_KILLS = 0x426 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_YESTERDAY_KILLS = 0x427 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_LAST_WEEK_KILLS = 0x428 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_THIS_WEEK_KILLS = 0x429 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_THIS_WEEK_CONTRIBUTION = 0x42a + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_LIFETIME_HONORABLE_KILLS = 0x42b + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_LIFETIME_DISHONORABLE_KILLS = 0x42c + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_YESTERDAY_CONTRIBUTION = 0x42d + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_LAST_WEEK_CONTRIBUTION = 0x42e + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_LAST_WEEK_RANK = 0x42f + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_BYTES2 = 0x430 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_WATCHED_FACTION_INDEX = 0x431 + 0xb6 + 0x06, // Size:1
        PLAYER_FIELD_COMBAT_RATING_1 = 0x432 + 0xb6 + 0x06, // Size:20

        PLAYER_END = 0x446 + 0xb6 + 0x06
    };
}