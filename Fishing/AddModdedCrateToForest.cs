using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
namespace NekoTweakMod.Fishing

{
    public class AddModdedCrateToForest : ModPlayer
    {
        public static bool PlayerIsInForest(Player player) // Technically, the Forest biome doesn't have an ID.  It's the default biome when no other biomes are present.
        {
            return !player.ZoneJungle
                && !player.ZoneDungeon
                && !player.ZoneCorrupt
                && !player.ZoneCrimson
                && !player.ZoneHoly
                && !player.ZoneSnow
                && !player.ZoneUndergroundDesert
                && !player.ZoneGlowshroom
                && !player.ZoneMeteor
                && !player.ZoneBeach
                && player.ZoneOverworldHeight;

        }
        public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
        {
            if (liquidType == 2 && Main.rand.Next(1) == 0) // if hardmode
            // Liquid types, 0 is water, 1 is lava, 2 is honey
            // Main.rand.Next(1) == 0) is the catch % chance to catch the Crate
            // n/100 chance or 1 = 100%
            {
                caughtType = ItemType<Fishing.Items.ForestCrate>();
            }
            {
                if (liquidType == 2 && Main.rand.Next(1) == 0) // if prehardmode
                {
                    caughtType = ItemType<Fishing.Items.ForestCrate>();
                }
            }
        }
    }
}
/*
Main.rand.Next(1) == 0) 
Main.rand.NextBool(97)
^^how do these even work~
*/