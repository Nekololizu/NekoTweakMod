using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace NekoTweakMod.Items.ModdedItems
{
    public class HoneyAbsorbantSponge : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Honey Absorbant Sponge"); // Changes the item name
            Tooltip.SetDefault("Capable of soaking up an endless amount of honey"); // Changes items tooltip/s
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuperAbsorbantSponge);
        }
        public override bool UseItem(Player player) // allows us to change what happens when we use an item
        {
            if (player.whoAmI != Main.myPlayer) // Checks if the player is the right one, and not another player etc in multiplayer
                return false;
            {
                Point16 tilepos = Main.MouseWorld.ToTileCoordinates16(); // grabs the x & y cooordinates from where the mouse is currently at
                Main.tile[tilepos.X, tilepos.Y].liquidType(); // decides what type of liquid to should be at x & y 
                Main.tile[tilepos.X, tilepos.Y].liquid = byte.MinValue; // decides what amount of liquid should be at x & y 
                _ = Main.tile[tilepos.X, tilepos.Y].liquid <= 0; // removes liquid
                {
                    if (Main.netMode == NetmodeID.MultiplayerClient) // checks if its singleplayer or multiplayer
                    {
                        NetMessage.sendWater(tilepos.X, tilepos.Y); // if its multiplayer send a message to the server that we are sending liquid
                    }
                    else
                    {
                        Liquid.AddWater(tilepos.X, tilepos.Y); // if its singleplayer just add the liquid
                    }
                    return true;
                }
            }
        }
    }
}