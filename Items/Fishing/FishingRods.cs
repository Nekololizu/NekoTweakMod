using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class FishingRods : GlobalItem // class name & vanilla hook
    {
        public override void SetDefaults(Item item) // SetDefaults allows you to set/change properties of items
        { // Single line "if" statements as we are only changing 1 property
            if (item.type == ItemID.WoodFishingPole) item.fishingPole = 15; // sets fishing power to 15%
            if (item.type == ItemID.ReinforcedFishingPole) item.fishingPole = 20;
            //if (item.type == ItemID.ScarabFishingRod) item.fishingPole = 30;
            //if (item.type == ItemID.ChumCaster) item.fishingPole = 30;
            if (item.type == ItemID.FiberglassFishingPole) item.fishingPole = 30;
            if (item.type == ItemID.SittingDucksFishingRod) item.fishingPole = 33;
            if (item.type == ItemID.FisherofSouls) item.fishingPole = 35;
            if (item.type == ItemID.Fleshcatcher) item.fishingPole = 37;
            if (item.type == ItemID.MechanicsRod) item.fishingPole = 45;
            if (item.type == ItemID.HotlineFishingHook) item.fishingPole = 47;

        }
    }
}