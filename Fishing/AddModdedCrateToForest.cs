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
            // if hardmode 
            if (Main.hardMode && liquidType == 2) // if its hardmode & the liquid is water
            {
                if (Main.rand.NextBool(3, 100)) // 3, 100 = 3% chance or 3/100 chance 
                {
                    caughtType = ItemType<Fishing.Items.ForestCrate>();
                }
            }
            // Liquid types, 0 is water, 1 is lava, 2 is honey
            // Main.rand.Next(1, 100) == 0) is the catch % chance to catch the Crate & the chance required to get it
            // n/100 chance or 1 = 1%
            // Main.rand.Next(100), Would generates a number between 0 & 99 instead if there is no specified chance
            {
                // if prehardmode 
                if (!Main.hardMode && liquidType == 2) // if its not hardmode & the liquid is water
                {
                    if (Main.rand.NextBool(3, 100))
                    {
                        caughtType = ItemType<Fishing.Items.ForestCrate>();
                    }
                }
            }
        }
    }
}

// Examples how to check "if" hardmode ~
// Main.hardMode & !Main.hardMode(if its not hardmode)
//NPC.downedSlimeKing

/*
  Main.rand explanations
 
Main.rand.Next(100)
^this picks a number between 0 and 99
Main.rand.Next(100) generates a number between 0 and 99

Next(5, 10) will get you the values 5, 6, 7, 8, 9
Just like how Next(5) will only get you 0, 1, 2, 3, 4 and not 5

Main.rand.Next(1) == 0) 
Main.rand.Next(100) == 0) == 0 is the same as 1/100 or 1%

Main.rand.NextBool(97, 100) // 97% chance
Next(min, max) will get you a value from min to (max - 1)

Main.rand.NextBool(100) is the same as Main.rand.Next(100) == 0
also Next(100) can't return 100

Lyker,Teok,iScalieable & absoluteAquarian, trying to explain this to me^
*/
