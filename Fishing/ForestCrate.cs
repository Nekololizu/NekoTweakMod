using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Terraria;

namespace NekoTweakMod.Fishing // where this file is located in the mods folders
{
    public class ForestCrate : ModItem // Here we are setting up the crate as an item while in the players inventory, and making it so it creates a tile when placed 
    {
        public override void SetStaticDefaults() // Allows us to set/change a modded items name/translations
        {
            DisplayName.SetDefault("Forest Crate"); // Changes the item name
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}"); // Changes items tooltip
        }
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12; // 16 = default, if no value is set
            item.maxStack = 99; // how many of the item the player can have in 1 slot in their inventory 
            item.useTurn = true; // Whether the player can turn around while the using animation is happening.
            item.useAnimation = 15; // how fast the animation happens
            item.useTime = 15; // how long the animation takes
            item.useStyle = ItemUseStyleID.SwingThrow; // how the animation will look
            item.autoReuse = true;  // will keep on swinging the item when trying to place it
            item.consumable = true; // if doing something with the item consumes/removes it 
            item.value = Item.sellPrice(0, 1, 0, 0); ; // sets the sale/purchase value of the item ( plat,gold,silver,copper)
            item.rare = ItemRarityID.Green; // sets the rarity of the item
            item.createTile = TileType<Fishing.ForestCratePlaced>(); // where the class is located in the namespace, where file is located in the mod folders~
            // for NekoTweakMod this is located in the Tiles folder
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            int choice = Main.rand.Next(7);
            if (choice == 0)
            {
                player.QuickSpawnItem(ItemID.Bunny);
            }
            else if (choice == 1)
            {
                player.QuickSpawnItem(ItemID.Swordfish);
            }
            if (choice != 1)
            {
                player.QuickSpawnItem(ItemID.Meowmere);
            }
            player.QuickSpawnItem(ItemID.IronBar);
        }
    }
}

// if (Main.hardMode)
// ItemID.Sets.IsFishingCrateHardmode
// public static bool[] IsFishingCrate = ItemID.Sets.Factory.CreateBoolSet(2334, 2335, 2336, 3203, 3204, 3205, 3206, 3207, 3208, 4405, 4407, 4877, 5002, 3979, 3980, 3981, 3982, 3983, 3984, 3985, 3986, 3987, 4406, 4408, 4878, 5003);
// public static bool[] IsFishingCrateHardmode = ItemID.Sets.Factory.CreateBoolSet(3979, 3980, 3981, 3982, 3983, 3984, 3985, 3986, 3987, 4406, 4408, 4878, 5003);