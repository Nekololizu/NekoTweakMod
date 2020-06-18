using Terraria.DataStructures;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;

namespace NekoTweakMod.Items.ModdedItems
{
    public class BottomlessHoneyBucket : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bottomless Honey Bucket"); // Changes the item name
            Tooltip.SetDefault("Contains an endless amount of honey"); // Changes items tooltip/s
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.BottomlessBucket); // clones properties of the specified item
        }
        public override bool UseItem(Player player) // allows us to change what happens when we use an item
        {
            if (player.whoAmI != Main.myPlayer && !player.noBuilding) // Checks if the player is the right one, and not another player etc in multiplayer
            return false;
            {
                int range = 2; // extra tool range after default range
                Vector2 adjustedPos = player.position / 16;
                float xDist = Math.Abs(Player.tileTargetX - adjustedPos.X);
                float yDist = Math.Abs(Player.tileTargetY - adjustedPos.Y);
                if (xDist > Player.tileRangeX + range || yDist > Player.tileRangeY + range)
                {
                    return false;
                }
            }
            // Thanks to mariothedog, Champion Mod for this range check^
            {
                Point16 tilepos = Main.MouseWorld.ToTileCoordinates16(); // grabs the x & y cooordinates from where the mouse is currently at
                // thanks to absoluteAquarian for telling me about point16 for easy mouse pos checking
                Main.PlaySound(SoundID.Splash, (int)player.position.X, (int)player.position.Y, 1, 1f, 0f); // plays soundid 19(splash) when using the item at the player 
                Main.tile[tilepos.X, tilepos.Y].liquidType(2); // decides what type of liquid to should be at x & y 
                Main.tile[tilepos.X, tilepos.Y].liquid = byte.MaxValue; // decides what amount of liquid should be at x & y 
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