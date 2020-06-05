using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NekoTweakMod.Items
{
	// This file shows a very simple example of a GlobalItem class. GlobalItem hooks are called on all items in the game and are suitable for sweeping changes like 
	// adding additional data to all items in the game. Here we simply adjust the damage of the Copper Shortsword item, as it is simple to understand. 
	// See other GlobalItem classes in ExampleMod to see other ways that GlobalItem can be used.
	public class Muramasa : GlobalItem
	{
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.Muramasa) { // Here we make sure to only change Copper Shortsword by checking item.type in an if statement
				item.damage = 26; // The damage your item deals
				//item.melee = true; // Whether your item is part of the melee class
				//item.width = 40; // The item texture's width
				//item.height = 40; // The item texture's height
				//item.useTime = 20; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
				//item.useAnimation = 20; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
				//item.knockBack = 6; // The force of knockback of the weapon. Maximum is 20
				//item.value = Item.buyPrice(gold: 1); // The value of the weapon in copper coins
				//item.rare = ItemRarityID.Green; // The rarity of the weapon, from -1 to 13. You can also use ItemRarityID.TheColorRarity
				//item.UseSound = SoundID.Item1; // The sound when the weapon is being used
				//item.autoReuse = true; // Whether the weapon can be used more than once automatically by holding the use button
				//item.crit = 6; // The critical strike chance the weapon has. The player, by default, has 4 critical strike chance
				//The useStyle of the item. 
				//Use useStyle 1 for normal swinging or for throwing
				//use useStyle 2 for an item that drinks such as a potion,
				//use useStyle 3 to make the sword act like a shortsword
				//use useStyle 4 for use like a life crystal,
				//and use useStyle 5 for staffs or guns
				//item.useStyle = ItemUseStyleID.SwingThrow; // 1 is the useStyle
			}
		}
	}
}
