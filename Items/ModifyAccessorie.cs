using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class ModifyAccessorie : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (item.type == ItemID.FeralClaws)
            {
                player.meleeSpeed -= 0.12f; // Gives -12% melee speed
                player.kbGlove = false; // Sets this item as a knockback glove
                if (player.HeldItem.melee || player.HeldItem.summon) // if the player is holding/using either a melee or summoner weapon 
                    // Thanks to Oli for telling me about player.helditem
                {
                    player.releaseUseItem = true; // Makes the accessory give autoReuse/AutoSwing to the players item/weapon
                }

            }
            {
                //single-line "if" statement examples, changing 1 property only for each statement
                if (item.type == ItemID.TitanGlove) player.meleeSpeed += 0.12f; // 12% increased melee speed
                if (item.type == ItemID.Shackle) player.aggro += 50; // increases players aggro by 50+
            }
            {
                if (item.type == ItemID.FireGauntlet)
                {
                    player.meleeDamage += 0.02f;// 2% increase
                    player.meleeSpeed += 0.02f;
                    if (player.HeldItem.melee || player.HeldItem.summon) player.releaseUseItem = true;
                }
            }
            {
                if (item.type == ItemID.MechanicalGlove)
                {
                    if (player.HeldItem.melee || player.HeldItem.summon) player.releaseUseItem = true;
                }
            }
            {
                if (item.type == ItemID.PowerGlove)
                {
                    if (player.HeldItem.melee || player.HeldItem.summon) player.releaseUseItem = true;
                }
            }
        }
    }
}