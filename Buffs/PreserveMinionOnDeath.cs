using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class PreserveMinionOnDeath : ModPlayer
    {
        public override void OnRespawn(Player player)
        {
            if (!player.HasItem(ItemID.SlimeStaff))
            {
                player.AddBuff(BuffID.BabySlime, 3600);
            }
            else
            {
                return;
            }
        }
    }
}

/*
 if (player.HasItem(ItemID.SlimeStaff)) // checks if the player has the specified item in their inventory 

 player.AddBuff(BuffID.BabySlime, 3600); 

player.ItemCheck(ItemID.SlimeStaff);
*/