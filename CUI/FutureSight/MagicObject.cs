using System;
using System.Collections;
using System.Collections.Generic;

namespace FutureSight
{
    public class MagicObject
    {
        public MagicCard Card = new MagicCard();
        public MagicCharacteristics Characteristics = new MagicCharacteristics();

        public IEnumerable<MagicAbility> GetAllActivations()
        {
            foreach (var item in Characteristics.ActivateAbility) { yield return item; }
            foreach (var item in Characteristics.ManaAbility) { yield return item; }
            foreach (var item in Characteristics.LoyaltyAbility) { yield return item; }
        }

        // 発生源や対象等が存在しない時のダミー
        public static MagicObject None;
        public static List<IMagicTarget> EmptyList;
        static MagicObject()
        {
            None = new MagicObject();
            EmptyList = new List<IMagicTarget>();
        }
    }

    public class MagicCard
    {
        public MagicPlayer Controller = new MagicPlayer();
        public string FlipCardName;
        public string TransformCardName;
        public string SplitCardName;
        public Dictionary<ReplacementEffectType, MagicEvent> ReplacementOrPreventEffectMap = new Dictionary<ReplacementEffectType, MagicEvent>();
        public List<MagicDamage> DealtDamages = new List<MagicDamage>();
    }

    public class MagicCharacteristics
    {
        public string Name;
        public string ManaCost;
        public string Color;
        public string ColorIndicator;
        public string CardType;
        public string SpecialType;
        public string SubType;
        public string RuleText;
        public List<MagicAbility> StaticAbility = new List<MagicAbility>();
        public List<MagicAbility> ActivateAbility = new List<MagicAbility>();
        public List<MagicAbility> ManaAbility = new List<MagicAbility>();
        public List<MagicAbility> TriggeredAbility = new List<MagicAbility>();
        public List<MagicAbility> SpellAbility = new List<MagicAbility>();
        public List<MagicAbility> LoyaltyAbility = new List<MagicAbility>();
        public string Power;
        public string Toughness;
        public string Loyalty;
        public string HandModifier;
        public string LifeModifier;
    }
}