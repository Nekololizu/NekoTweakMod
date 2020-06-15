using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Buffs
{
    public class IsWaterWet : ModPlayer // ModPlayer hook allows us to change modded/vanilla effects happening for the player
    {
        public override void PreUpdateBuffs() // allows us to add buffs to the player for specific situations
        {
            if (player.wet) // Checks if the player is wet/standing in water
            {
                player.AddBuff(BuffID.Wet, 899); // gives the debuff "wet" permanently while in water, and for 15 seconds after
            }
        }
    }
}