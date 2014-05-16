//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vanilla.World.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class quest_template
    {
        public int entry { get; set; }
        public byte Method { get; set; }
        public short ZoneOrSort { get; set; }
        public byte MinLevel { get; set; }
        public byte QuestLevel { get; set; }
        public int Type { get; set; }
        public int RequiredClasses { get; set; }
        public int RequiredRaces { get; set; }
        public int RequiredSkill { get; set; }
        public int RequiredSkillValue { get; set; }
        public int RepObjectiveFaction { get; set; }
        public int RepObjectiveValue { get; set; }
        public int RequiredMinRepFaction { get; set; }
        public int RequiredMinRepValue { get; set; }
        public int RequiredMaxRepFaction { get; set; }
        public int RequiredMaxRepValue { get; set; }
        public byte SuggestedPlayers { get; set; }
        public long LimitTime { get; set; }
        public int QuestFlags { get; set; }
        public byte SpecialFlags { get; set; }
        public int PrevQuestId { get; set; }
        public int NextQuestId { get; set; }
        public int ExclusiveGroup { get; set; }
        public int NextQuestInChain { get; set; }
        public int SrcItemId { get; set; }
        public byte SrcItemCount { get; set; }
        public int SrcSpell { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Objectives { get; set; }
        public string OfferRewardText { get; set; }
        public string RequestItemsText { get; set; }
        public string EndText { get; set; }
        public string ObjectiveText1 { get; set; }
        public string ObjectiveText2 { get; set; }
        public string ObjectiveText3 { get; set; }
        public string ObjectiveText4 { get; set; }
        public int ReqItemId1 { get; set; }
        public int ReqItemId2 { get; set; }
        public int ReqItemId3 { get; set; }
        public int ReqItemId4 { get; set; }
        public int ReqItemCount1 { get; set; }
        public int ReqItemCount2 { get; set; }
        public int ReqItemCount3 { get; set; }
        public int ReqItemCount4 { get; set; }
        public int ReqSourceId1 { get; set; }
        public int ReqSourceId2 { get; set; }
        public int ReqSourceId3 { get; set; }
        public int ReqSourceId4 { get; set; }
        public int ReqSourceCount1 { get; set; }
        public int ReqSourceCount2 { get; set; }
        public int ReqSourceCount3 { get; set; }
        public int ReqSourceCount4 { get; set; }
        public int ReqCreatureOrGOId1 { get; set; }
        public int ReqCreatureOrGOId2 { get; set; }
        public int ReqCreatureOrGOId3 { get; set; }
        public int ReqCreatureOrGOId4 { get; set; }
        public int ReqCreatureOrGOCount1 { get; set; }
        public int ReqCreatureOrGOCount2 { get; set; }
        public int ReqCreatureOrGOCount3 { get; set; }
        public int ReqCreatureOrGOCount4 { get; set; }
        public int ReqSpellCast1 { get; set; }
        public int ReqSpellCast2 { get; set; }
        public int ReqSpellCast3 { get; set; }
        public int ReqSpellCast4 { get; set; }
        public int RewChoiceItemId1 { get; set; }
        public int RewChoiceItemId2 { get; set; }
        public int RewChoiceItemId3 { get; set; }
        public int RewChoiceItemId4 { get; set; }
        public int RewChoiceItemId5 { get; set; }
        public int RewChoiceItemId6 { get; set; }
        public int RewChoiceItemCount1 { get; set; }
        public int RewChoiceItemCount2 { get; set; }
        public int RewChoiceItemCount3 { get; set; }
        public int RewChoiceItemCount4 { get; set; }
        public int RewChoiceItemCount5 { get; set; }
        public int RewChoiceItemCount6 { get; set; }
        public int RewItemId1 { get; set; }
        public int RewItemId2 { get; set; }
        public int RewItemId3 { get; set; }
        public int RewItemId4 { get; set; }
        public int RewItemCount1 { get; set; }
        public int RewItemCount2 { get; set; }
        public int RewItemCount3 { get; set; }
        public int RewItemCount4 { get; set; }
        public int RewRepFaction1 { get; set; }
        public int RewRepFaction2 { get; set; }
        public int RewRepFaction3 { get; set; }
        public int RewRepFaction4 { get; set; }
        public int RewRepFaction5 { get; set; }
        public int RewRepValue1 { get; set; }
        public int RewRepValue2 { get; set; }
        public int RewRepValue3 { get; set; }
        public int RewRepValue4 { get; set; }
        public int RewRepValue5 { get; set; }
        public int RewOrReqMoney { get; set; }
        public long RewMoneyMaxLevel { get; set; }
        public int RewSpell { get; set; }
        public int RewSpellCast { get; set; }
        public int RewMailTemplateId { get; set; }
        public long RewMailDelaySecs { get; set; }
        public int PointMapId { get; set; }
        public float PointX { get; set; }
        public float PointY { get; set; }
        public int PointOpt { get; set; }
        public int DetailsEmote1 { get; set; }
        public int DetailsEmote2 { get; set; }
        public int DetailsEmote3 { get; set; }
        public int DetailsEmote4 { get; set; }
        public long DetailsEmoteDelay1 { get; set; }
        public long DetailsEmoteDelay2 { get; set; }
        public long DetailsEmoteDelay3 { get; set; }
        public long DetailsEmoteDelay4 { get; set; }
        public int IncompleteEmote { get; set; }
        public int CompleteEmote { get; set; }
        public int OfferRewardEmote1 { get; set; }
        public int OfferRewardEmote2 { get; set; }
        public int OfferRewardEmote3 { get; set; }
        public int OfferRewardEmote4 { get; set; }
        public long OfferRewardEmoteDelay1 { get; set; }
        public long OfferRewardEmoteDelay2 { get; set; }
        public long OfferRewardEmoteDelay3 { get; set; }
        public long OfferRewardEmoteDelay4 { get; set; }
        public int StartScript { get; set; }
        public int CompleteScript { get; set; }
    }
}