using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UseTheWorstFirstAndDropStone;
using System.Threading.Tasks;
using ModSettings;

namespace UseTheWorstFirstAndDropStone
{

    internal enum Decoy
    {
        DEFAULT, STONE, TINDER, CATTAIL
    }

    internal class UseTheWorstFirstAndDropStoneSettings : JsonModSettings
    {
        [Section("Drop Feature")]
        [Name("Replace decoy by : ")]
        [Description("Allow you to replace items dropped with the decoy hotkey ('3') by the selected item")]
        [Choice("Default", "Stones", "Tinders", "Cattail Heads")]
        public Decoy decoy = Decoy.STONE;

        [Section("Worst condition first")]
        [Name("Bedrolls")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool bedroll = true;

        [Section("Worst condition first : Lights ")]
        [Name("Torch")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool torch = true;

        [Name("Firestriker")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool firestriker = true;

        [Name("Matches (both)")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool matches = true;

        [Name("Bow")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool bow = true;

        [Name("Revolver")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool revolver = true;

        [Name("Rifle")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool rifle = true;

        [Name("Can Opener")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool canOpener = true;

        [Name("Prybar")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool prybar = true;

        [Name("Hatchets (both)")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool hatchets = true;

        [Name("Knives (both)")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool knives = true;

        [Name("Hammer")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool hammer = true;

        [Name("Snare")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool snare = true;

        [Name("Cooking Pot")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool cookingPot = true;

        [Name("Recycled Can")]
        [Description("YES : The worst condition will be used first\nNO : Default")]
        public bool recycledCan = true;

        protected override void OnConfirm()
        {
            base.OnConfirm();
        }

    }

    internal static class Settings
    {

        public static UseTheWorstFirstAndDropStoneSettings settings;

        public static void OnLoad()
        {
            settings = new UseTheWorstFirstAndDropStoneSettings();
            settings.AddToModSettings("Use The Worst First And Drop Stone");
        }
    }


}
