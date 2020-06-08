using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
    public class ModifyEquipment : GlobalItem // class name & vanilla hook
    {
        public override void SetDefaults(Item item) // SetDefaults allows you to set/change properties of items
        {
            // if (item.type == ItemID.BabyBirdStaff) // disabled until tmod v1.4 
            // specifies what item to change
            {
               // item.damage = 9; // changes the items damage
                //item.knockBack = 0;
            }
            if (item.type == ItemID.WormScarf) item.defense = 2; // Single line if statement as we are only changing 1 property
            if (item.type == ItemID.Muramasa) item.damage = 26; 
            if (item.type == ItemID.MiningShirt) item.value = Item.buyPrice(0, 4, 0, 0); // changes the sale value
            if (item.type == ItemID.MiningPants) item.value = Item.buyPrice(0, 4, 0, 0); // (0, 0, 0, 0); plat,gold,silver,copper
            {
                if (item.type == ItemID.ReaverShark)
                {
                    item.useTime = 19; // Makes it sligthly faster
                    item.useAnimation = 19;
                }
            }
        }
    }
}
/*
Other item. alternatives if you want to change something else

item.CloneDefaults(ItemID.GoldenKey); // Gives you all the default values for an item
item.damage = 26; // The damage your item deals
item.melee = true; // Whether your item is part of the melee class
item.width = 40; // The item texture's width
item.height = 40; // The item texture's height
item.useTime = 20; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
item.useAnimation = 20; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
item.knockBack = 6; // The force of knockback of the weapon. Maximum is 20
item.value = Item.buyPrice(gold: 1); // The value of the weapon in copper coins
item.rare = ItemRarityID.Green; // The rarity of the weapon, from -1 to 13. You can also use ItemRarityID.TheColorRarity
item.UseSound = SoundID.Item1; // The sound when the weapon is being used
item.autoReuse = true; // Whether the weapon can be used more than once automatically by holding the use button
item.crit = 6; // The critical strike chance the weapon has. The player, by default, has 4 critical strike chance

The useStyle of the item. 
Use useStyle 1 for normal swinging or for throwing
use useStyle 2 for an item that drinks such as a potion,
use useStyle 3 to make the sword act like a shortsword
use useStyle 4 for use like a life crystal,
and use useStyle 5 for staffs or guns
item.useStyle = ItemUseStyleID.SwingThrow; // 1 is the useStyle
 */
