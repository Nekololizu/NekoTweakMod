using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class UpdateAccessories : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (item.type == ItemID.FeralClaws)
            {
                player.meleeSpeed -= 0.12f; // Gives -12% melee speed
                player.kbGlove = false; // Sets this item as a knockback glove
                player.releaseUseItem = true; // Gives the accessory autoReuse/AutoSwing
            }
           // if(item.noMelee)
             //   player.releaseUseItem = false;
            {
                //single-line "if" statement examples, changing 1 property only for each if statement
                if (item.type == ItemID.TitanGlove) player.meleeSpeed += 0.12f; // 12% increased melee speed
                if (item.type == ItemID.Shackle) player.aggro += 50; // increases players aggro by 50+
                if (item.type == ItemID.PowerGlove) player.releaseUseItem = true;
                if (item.type == ItemID.MechanicalGlove) player.releaseUseItem = true;
            }
            {
                if (item.type == ItemID.FireGauntlet)
                {
                    player.releaseUseItem = true;
                    player.meleeDamage += 0.02f;// 2% increase
                    player.meleeSpeed += 0.02f;
                }
            }
        }
    }
}